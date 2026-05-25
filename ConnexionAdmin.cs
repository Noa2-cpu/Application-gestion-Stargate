using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SAE24
{
    public partial class ConnexionAdmin : Form
    {
        private Form1 formulairePrecedent;
        public ConnexionAdmin()
        {
            InitializeComponent();
        }

        public ConnexionAdmin(Form1 f1)
        {
            InitializeComponent();
            formulairePrecedent = f1;
        }

        private void ConnexionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            formulairePrecedent.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) && string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                errorProvider1.SetError(txtLogin, "Veuillez remplir les champs nécesssaires");
                errorProvider1.SetError(txtMotDePasse, "Veuillez remplir les champs nécesssaires");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                errorProvider1.SetError(txtLogin, "Veuillez remplir votre login.");
                txtLogin.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                errorProvider1.SetError(txtMotDePasse, "Veuillez remplir votre mot de passe.");
                txtMotDePasse.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                string sql = "SELECT * FROM Admin;";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();

                bool authentifie = false;



                while (dr.Read())
                {
                    if (txtLogin.Text == dr.GetString(0) && BCrypt.Net.BCrypt.Verify(txtMotDePasse.Text, dr.GetString(1)))
                    {
                        authentifie = true;
                        break;
                    }
                }

                if (authentifie)
                {
                    MessageBox.Show("Authentification réussie !\nBienvenue à bord Commandant !", "Authentification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form CreationMission = new CreationMission();
                    CreationMission.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Votre login ou mot de passe ne correspond pas !\nAccès refusé.", "Accès non-autorisé", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLogin.Clear();
                    txtMotDePasse.Clear();
                    txtLogin.Focus();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message, "erreur");
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                txtMotDePasse.Focus();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtMotDePasse.UseSystemPasswordChar = false;
        }

        private void txtMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnValider_Click(sender, e);
            }

            if(e.KeyChar == 38)
            {
                txtLogin.Focus();
            }
        }
    }
}
