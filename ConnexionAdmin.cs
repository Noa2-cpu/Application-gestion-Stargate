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
                MessageBox.Show("Veuillez remplir les champs requis.");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Veuillez remplir votre login.");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                MessageBox.Show("Veuillez remplir votre mot de passe.");
                txtMotDePasse.Focus();
                return;
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
                }
                else
                {
                    MessageBox.Show("Votre login ou mot de passe ne correspond pas !\nAccès refusé.", "Accès non-autorisé", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message, "erreur");
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
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
        }
    }
}
