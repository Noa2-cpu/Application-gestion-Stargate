using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class CreationMission : Form
    {
        
        public CreationMission()
        {
            InitializeComponent();
        }

        

        private void CreationMission_Load(object sender, EventArgs e)
        {
            string remplirCombo1 = "SELECT nom FROM Planete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCombo1, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CboChoisirPlanete.Items.Add(dr.GetString(0));
                }
            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            string remplirCombo2 = @"SELECT m.nom || ' ' || m.prenom || ' - ' || mi.grade, mi.matriculeMembre
                                     FROM Membre m 
                                     Join Militaire mi ON mi.matriculeMembre = m.matricule 
                                     WHERE mi.grade = 'Capitaine'";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCombo2, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CboChefMission.Items.Add(dr.GetString(0));
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            

            BtnValider.Enabled = false;
        }

        private void BtnPlanete_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(numero) FROM Mission WHERE nomPlanete = @planete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@planete", CboChoisirPlanete.SelectedItem);

                int numeroMission = 0;

                object resultat = cmd.ExecuteScalar();

                if (resultat != DBNull.Value && resultat != null)
                {
                    numeroMission = Convert.ToInt32(resultat);
                }

                numeroMission++;

                if (CboChoisirPlanete.SelectedItem == null)
                {
                    errorProvider1.SetError(CboChoisirPlanete, "Veuillez choir une planète où aller");
                    CboChoisirPlanete.Focus();
                }
                else
                {
                    LblAfficherPlanete.Text = "Nom de la mission : " + CboChoisirPlanete.SelectedItem.ToString() + " - " + numeroMission.ToString();
                    errorProvider1.Clear();
                    label1.Enabled = false;
                    CboChoisirPlanete.Enabled = false;
                    BtnPlanete.Enabled = false;
                    LblAfficherPlanete.Enabled = false;
                    BtnValider.Enabled = true;
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtNbPersonne_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                TxtObjDatabaz.Focus();
            }
        }

        private void TxtObjDatabaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                TxtBudget.Focus();
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            bool valide = true;

            errorProvider1.Clear();

            // Chef de mission
            if (CboChefMission.SelectedItem == null)
            {
                errorProvider1.SetError(CboChefMission, "Veuillez choisir un chef de mission.");

                valide = false;
            }

            // Dates
            if (DtpDepart.Value.Date >= DtpRetour.Value.Date)
            {
                errorProvider1.SetError(DtpRetour, "La date de retour doit être différente de celle du départ.");

                valide = false;
            }

            // Nombre de personnes
            if (string.IsNullOrWhiteSpace(TxtNbPersonne.Text))
            {
                errorProvider1.SetError(TxtNbPersonne, "Veuillez saisir le nombre de personnes.");

                valide = false;
            }

            // Quantité de Databaz
            if (string.IsNullOrWhiteSpace(TxtObjDatabaz.Text))
            {
                errorProvider1.SetError(TxtObjDatabaz, "Veuillez saisir la quantité de Databaz.");

                valide = false;
            }

            // Budget
            if (string.IsNullOrWhiteSpace(TxtBudget.Text))
            {
                errorProvider1.SetError(TxtBudget, "Veuillez saisir le budget de la mission.");

                valide = false;
            }

            if (valide)
            {
                string sql = "SELECT MAX(numero) FROM Mission WHERE nomPlanete = @planete";

                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                    cmd.Parameters.AddWithValue("@planete", CboChoisirPlanete.SelectedItem);

                    int numeroMission = 0;

                    object resultat = cmd.ExecuteScalar();

                    if (resultat != DBNull.Value && resultat != null)
                    {
                        numeroMission = Convert.ToInt32(resultat);
                    }

                    numeroMission++;

                    CboChefMission.ValueMember = "mi.matriculeMember";

                    string ajouterMission = @"
                    INSERT INTO Mission 
                    (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget)
                    VALUES
                    (@planete, @numero, @nb, @depart, @retour, @chef, @feuille, @databaz, @budget);
                    ";

                    SQLiteCommand cmd2 = new SQLiteCommand(ajouterMission, Connexion.Connec);

                    cmd2.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                    cmd2.Parameters.AddWithValue("@numero", numeroMission);
                    cmd2.Parameters.AddWithValue("@nb", TxtNbPersonne.Text);
                    cmd2.Parameters.AddWithValue("@depart", DtpDepart.Value);
                    cmd2.Parameters.AddWithValue("@retour", DtpRetour.Value);
                    cmd2.Parameters.AddWithValue("@chef", CboChefMission.SelectedValue);
                    cmd2.Parameters.AddWithValue("@feuille", RtbFeuilleRoute.Text);
                    cmd2.Parameters.AddWithValue("@databaz", TxtObjDatabaz.Text);
                    cmd2.Parameters.AddWithValue("@budget", TxtBudget.Text);

                    cmd2.ExecuteNonQuery();
                }
                catch(SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void TxtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                BtnValider_Click(sender, e);
            }
        }
    }
}
