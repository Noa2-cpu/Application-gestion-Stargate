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
    public partial class AfficherCaptureAlien : UserControl
    {
        public AfficherCaptureAlien()
        {
            InitializeComponent();
        }

        private void AfficherCaptureAlien_Load(object sender, EventArgs e)
        {

        }

        public void chargerDonnees(DataRow ligne)
        {
            string nom = ligne["NomEspece"].ToString();
            string objectif = "Objectif initial : " + ligne["ObjectifInitial"].ToString();
            string nbCapture = "nombre de capture : " + ligne["NbCaptures"].ToString();
            string captureAtteinte = "taux de reussite : " + ligne["TauxReussite"].ToString() + "%";

            LblNom.Text = nom;
            LblObjectif.Text = objectif;
            LblNbr.Text = nbCapture;
            LblPourcentage.Text = captureAtteinte;


            PcbAlien.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbAlien.SizeMode = PictureBoxSizeMode.Zoom;
            PcbAlien.Image = Image.FromFile(@"..\..\img\prisonnieralien.png");
        }

        private void LblPourcentage_Click(object sender, EventArgs e)
        {

        }

        private void AfficherCaptureAlien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
