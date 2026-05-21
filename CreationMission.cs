using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SAE24
{
    public partial class CreationMission : Form
    {

        public CreationMission()
        {
            InitializeComponent();
        }

        // Table contenant les membres disponibles (source liée à la ComboBox)
        private DataTable dtMembres;

        //Table contenant les aliens disponibles (source liée à la ComboBox)
        private DataTable dtAliens;

        // Liste des matricules sélectionnés (ce que l'on souhaite conserver sans créer de classe)
        private List<string> selectedMatricules = new List<string>();

        private int currentNumeroMission;

        private void CreationMission_Load(object sender, EventArgs e)
        {
            //remplir la combobox avec les planètes
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
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }


            //remplir la combobox du chef de mission
            string remplirCombo2 = @"SELECT m.nom || ' ' || m.prenom || ' - ' || mi.grade AS prenomcomplet, mi.matriculeMembre AS matricule
                                     FROM Membre m 
                                     Join Militaire mi ON mi.matriculeMembre = m.matricule 
                                     WHERE mi.grade = 'Capitaine' AND m.matricule NOT IN (SELECT co.matriculeMembre
						                                                                  FROM Composer co
						                                                                  JOIN Mission mis ON co.numeroMission = mis.numero
						                                                                  WHERE @dateDepart <= mis.dateRetour
						                                                                  AND @dateRetour >= mis.dateDepart);";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCombo2, Connexion.Connec);

                cmd.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                CboChefMission.DataSource = dt;
                CboChefMission.DisplayMember = "prenomcomplet";
                CboChefMission.ValueMember = "matricule";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            //remplir la combobox pour choisir les membres de la mission en deux temps : d'abord avec les civils puis avec les militaires.
            string remplirCivils = @"SELECT m.nom || ' ' || m.prenom || ' - Civil : ' || c.Specialite AS nomcomplet, m.matricule AS matricule
                                         FROM Membre m
                                         JOIN Civil c ON m.matricule = c.matriculeMembre
                                         WHERE m.matricule NOT IN (SELECT co.matriculeMembre
						                                           FROM Composer co
						                                           JOIN Mission mi ON  co.numeroMission = mi.numero
						                                           WHERE @dateDepart <= mi.dateRetour
						                                           AND @dateRetour >= mi.dateDepart);";

            string remplirMilitaires = @"SELECT m.nom || ' ' || m.prenom || ' - Militaire : ' || mi.grade AS nomcomplet, m.matricule as matricule
                                             FROM Membre m
                                             JOIN Militaire mi ON m.matricule = mi.matriculeMembre
                                             WHERE m.matricule NOT IN (SELECT co.matriculeMembre
						                                               FROM Composer co
						                                               JOIN Mission mi ON co.numeroMission = mi.numero
						                                               WHERE @dateDepart <= mi.dateRetour
						                                               AND @dateRetour >= mi.dateDepart);";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCivils, Connexion.Connec);
                SQLiteCommand cmd2 = new SQLiteCommand(remplirMilitaires, Connexion.Connec);

                cmd.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));

                dtMembres = new DataTable();

                dtMembres.Load(cmd.ExecuteReader());
                dtMembres.Load(cmd2.ExecuteReader());

                CboChoisirMembre.DataSource = dtMembres;
                CboChoisirMembre.DisplayMember = "nomcomplet";
                CboChoisirMembre.ValueMember = "matricule";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }


            //remplir la combobox des aliens
            string remplirAliens = @"SELECT es.nom || ' - ' || es.couleur AS nomcomplet, e.idEspece AS ID
                                    FROM Ennemi e
                                    JOIN Espece es ON e.idEspece = es.id;";
            
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirAliens, Connexion.Connec);

                dtAliens = new DataTable();

                dtAliens.Load(cmd.ExecuteReader());

                CboAliens.DataSource = dtAliens;
                CboAliens.DisplayMember = "nomcomplet";
                CboAliens.ValueMember = "ID";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
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
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
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

            if (string.IsNullOrWhiteSpace(RtbFeuilleRoute.Text))
            {
                errorProvider1.SetError(RtbFeuilleRoute, "Veuillez saisir quelques informations pour la feuille de route..");

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
                    currentNumeroMission = numeroMission;

                    string ajouterMission = @"
                    INSERT INTO Mission 
                    (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget)
                    VALUES
                    (@planete, @numero, @nb, @depart, @retour, @chef, @feuille, @databaz, @budget);
                    ";

                    SQLiteCommand cmd2 = new SQLiteCommand(ajouterMission, Connexion.Connec);

                    cmd2.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                    cmd2.Parameters.AddWithValue("@numero", numeroMission.ToString());
                    cmd2.Parameters.AddWithValue("@nb", TxtNbPersonne.Text);
                    cmd2.Parameters.AddWithValue("@depart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("@retour", DtpRetour.Value.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("@chef", CboChefMission.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("@feuille", RtbFeuilleRoute.Text);
                    cmd2.Parameters.AddWithValue("@databaz", TxtObjDatabaz.Text);
                    cmd2.Parameters.AddWithValue("@budget", TxtBudget.Text);

                    /*cmd2.ExecuteNonQuery();*/
                    LstAfficherMembre.Items.Add(CboChefMission.Text);
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;

                    LblNbPersonnes.Text = TxtNbPersonne.Text;
                }
                catch (SQLiteException err)
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

        private void RtbFeuilleRoute_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnAjouterMembre_Click(object sender, EventArgs e)
        {
            string membre = CboChoisirMembre.GetItemText(CboChoisirMembre.SelectedItem);

            errorProvider1.Clear();

            if (!LstAfficherMembre.Items.Contains(membre))
            {
                LstAfficherMembre.Items.Add(membre);

                // Récupérer le matricule depuis l'élément sélectionné
                string matricule = CboChoisirMembre.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(matricule))
                {
                    selectedMatricules.Add(matricule);
                }

                // Supprimer la ligne correspondante du DataTable lié pour mettre à jour la ComboBox
                if (dtMembres != null && CboChoisirMembre.SelectedItem is DataRowView drv)
                {
                    dtMembres.Rows.Remove(drv.Row);
                }

                int nbMaximum;

                if (int.TryParse(TxtNbPersonne.Text, out nbMaximum))
                {
                    int nbActuel = LstAfficherMembre.Items.Count;

                    int restant = nbMaximum - nbActuel;

                    LblNbPersonnes.Text = "" + restant;

                    if (restant <= 0)
                    {
                        CboChoisirMembre.Enabled = false;
                        BtnAjouterMembre.Enabled = false;
                        BtnValiderMembre.Enabled = true;
                    }
                    else
                    {
                        CboChoisirMembre.Enabled = true;
                        BtnAjouterMembre.Enabled = true;
                        BtnValiderMembre.Enabled = false;
                    }
                }
                else
                {
                    LblNbPersonnes.Text = "Veuillez saisir un nombre valide.";
                }
            }
            else
            {
                errorProvider1.SetError(LstAfficherMembre, "Le membre est déjà sélectionné.");
            }
        }

        private void BtnValiderMembre_Click(object sender, EventArgs e)
        {

            string ajouterMembreSQL = @"INSERT INTO Composer 
                                        (nomPlanete, numeroMission, matriculeMembre)
                                        VALUES
                                        (@planete, @numero, @matricule)";


            // Insérer chaque matricule sélectionné précédemment
            foreach (var matricule in selectedMatricules)
            {
                SQLiteCommand cmd2 = new SQLiteCommand(ajouterMembreSQL, Connexion.Connec);

                cmd2.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                cmd2.Parameters.AddWithValue("@numero", currentNumeroMission.ToString());
                cmd2.Parameters.AddWithValue("@matricule", matricule);
                
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void TxtNombreCapture_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                BtnAjouterAliens_Click(sender, e);
            }
        }

        private void BtnAjouterAliens_Click(object sender, EventArgs e)
        {

        }
    }
}
