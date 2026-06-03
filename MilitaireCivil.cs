using ListeMission;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public delegate void afficherDetailsMilitaireCivil(object sender, EventArgs e);
    public partial class MilitaireCivil : UserControl
    {
        string nom, prenom, img;
        public MilitaireCivil()
        {
            InitializeComponent();
        }

        public MilitaireCivil(string nom, string prenom, string img)
        {
            InitializeComponent();
            this.nom = nom;
            this.prenom = prenom;
            this.img = img;
        }

        public afficherDetailsMilitaireCivil afficheur;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string NomImage { get => img; set => img = value; }

        private void MilitaireCivil_Click(object sender, EventArgs e)
        {
            if (this.afficheur != null)
            {
                this.afficheur(sender, e);
            }
        }

        public void chargerInterface()
        {
            LblNom.Text = nom;
            LblPrenom.Text = prenom;
            if (NomImage != string.Empty)
            {
                PcbPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
                PcbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                PcbPhoto.Image = Image.FromFile(this.NomImage);
            }
        }





        private void MilitaireCivil_Load(object sender, EventArgs e)
        {

        }
    }
}
