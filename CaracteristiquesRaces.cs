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
    public partial class CaracteristiquesRaces : UserControl
    {
        public CaracteristiquesRaces()
        {
            InitializeComponent();
        }

        public void chargerDonnees(DataRow ligne) {
            string nom = "--> " + ligne["nom"].ToString();
            string couleur = ligne["couleur"].ToString();
            string origine = ligne["Origine"].ToString();
            string type = ligne["TypeEspece"].ToString();
            string cheminImage = @"..\..\img\alien\" + couleur + ".jpg";

            lblNomRace.Text = nom;
            lblCouleurRace.Text = couleur;
            lblOrigineRace.Text = origine;

            switch (couleur)
            {
                case "Bleu":
                    lblCouleurRace.ForeColor = Color.Blue;
                    break;
                case "Gris":
                    lblCouleurRace.ForeColor = Color.Gray;
                    break;
                case "Marron":
                    lblCouleurRace.ForeColor = Color.Brown;
                    break;
                case "Orange":
                    lblCouleurRace.ForeColor = Color.Orange;
                    break;
                case "Pourpre":
                    lblCouleurRace.ForeColor = Color.DarkRed;
                    break;
                case "Rose":
                    lblCouleurRace.ForeColor = Color.Pink;
                    break;
                case "Vert":
                    lblCouleurRace.ForeColor = Color.Green;
                    break;
                case "Violet":
                    lblCouleurRace.ForeColor = Color.Purple;
                    break;
            }

            if (origine == "Origine inconnue")
            {
                lblOrigineRace.ForeColor = Color.Red;
            }

            if (type == "Alliée")
            {
                string instrumentPref = ligne["instrumentMusique"].ToString();
                lblInfoSpecifique.Text = "Instrument : " + instrumentPref;
                lblInfoSpecifique.ForeColor = Color.Green;

                string degBienveillance = "Bienveillance : " + ligne["degreBienveillance"].ToString();
                lblBienveilAgress.Text = degBienveillance;

            }
            else if (type == "Ennemie")
            {
                string armePref = ligne["typeArme"].ToString();
                lblInfoSpecifique.Text = "Arme : " + armePref;
                lblInfoSpecifique.ForeColor = Color.Red;

                string degAgressivite = "Agressivité : " + ligne["degreAgressivite"].ToString();
                lblBienveilAgress.Text = degAgressivite;
            }
            else
            {
                lblBienveilAgress.Text = type;
                lblInfoSpecifique.Visible = false;
            }
            try
            {
                picRaceImage.Image = UniformiserTaille(Image.FromFile(cheminImage), picRaceImage.Size);
                picRaceImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private Image UniformiserTaille(Image imageOriginale, Size tailleCarre)
        {
            return new Bitmap(imageOriginale, tailleCarre);
        }
        private void CaracteristiquesRaces_Load(object sender, EventArgs e)
        {

        }
    }
}
