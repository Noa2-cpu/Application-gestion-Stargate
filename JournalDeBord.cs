using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SAE24
{
    public partial class GrpContact : Form
    {
        private DataTable dtEvenements = new DataTable();

        private BindingSource bsEvenements = new BindingSource();

        string nomPlanete;
        int numeroMission;
        public GrpContact()
        {
            InitializeComponent();
        }

        public GrpContact(string nom, int numero)
        {
            InitializeComponent();
            this.nomPlanete = nom;
            this.numeroMission = numero;
        }

        private void GrpContact_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT dateJ, commentaires
                           FROM JournalDeBord
                           WHERE nomplanete = @planete AND numero = @numero;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);
            da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            da.Fill(dtEvenements);
            bsEvenements.DataSource = dtEvenements;

            AfficherEvenement();


            string chargerContact = @"SELECT c.dateC, c.sommeVersee, c.appreciation, i.nom AS nom
                                      FROM Informateur i
                                      JOIN Contact c ON i.nomCode = c.nomCodeInformateur
                                      WHERE c.nomPlanete = @planete AND c.numeroMission = @numero;";

            SQLiteDataAdapter da2 = new SQLiteDataAdapter(chargerContact, Connexion.Connec);
            da2.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da2.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            DgvAfficherContact.DataSource = dt2;

            string chargerDepense = @"SELECT d.id, d.dateD, d.motif, d.montant, t.libelle
                                      FROM Depense d
                                      JOIN TypeDepense t 
                                      ON d.idTypeDepense = t.id
                                      WHERE d.nomPlanete = 'Sckxyss' AND d.numeroMission = 1;";

            SQLiteDataAdapter da3 = new SQLiteDataAdapter(chargerDepense, Connexion.Connec);
            da3.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da3.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            DgvDepenses.DataSource = dt3;
        }

        private void AfficherEvenement()
        {
            if (bsEvenements.Count > 0)
            {
                DataRowView row = (DataRowView)bsEvenements.Current;

                LblEvenement.Text = row["commentaires"].ToString();
                LblDate.Text = row["dateJ"].ToString();
                LblNav.Text = " / " + bsEvenements.Count;
                TxtNumeroEvenement.Text =(bsEvenements.Position + 1).ToString();
            }
            else
            {
                LblEvenement.Text = "Aucun événement enregistré.";
                LblDate.Text = string.Empty;
                MessageBox.Show("Aucun événement trouvé pour cette planète et ce numéro de mission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAllerPremier_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveFirst();

            AfficherEvenement();
        }

        private void BtnReculer1_Click(object sender, EventArgs e)
        {
            bsEvenements.MovePrevious();

            AfficherEvenement();
        }

        private void BtnAvancer1_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveNext();

            AfficherEvenement();
        }

        private void BtnAllerDernier_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveLast();

            AfficherEvenement();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtNumeroEvenement.Text, out int numero))
            {
                if (numero >= 1 && numero <= bsEvenements.Count)
                {
                    bsEvenements.Position = numero - 1;

                    AfficherEvenement();
                }
            }
        }

        private void TxtNumeroEvenement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
