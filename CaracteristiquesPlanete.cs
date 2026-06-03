using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class CaracteristiquesPlanete : UserControl
    {
        public CaracteristiquesPlanete()
        {
            InitializeComponent();
        }

        public void chargerDonnees(DataRow ligne)
        {
            //Charge le text de UC
            string nomPlanete = ligne["NomPlanete"].ToString();
            int temperature = -500;
            if (Convert.IsDBNull(ligne["temperature"]))
            {
                lblTemperature.Text  = "Temperature : Non renseigner";
                lblTemperature.ForeColor = Color.Red;
            }
            else 
            { 
                temperature = Convert.ToInt32(ligne["temperature"]);
                lblTemperature.Text = temperature.ToString()+ "°C";
            }

            float gravite ;
            if (Convert.IsDBNull(ligne["gravite"]))
            {
                lblGravite.Text = "Gravité: Non renseigner";
                lblGravite.ForeColor = Color.Red;
            }
            else 
            { 
                gravite = Convert.ToSingle(ligne["gravite"]);
                lblGravite.Text ="Gravité : " + gravite.ToString();
            }

            bool possedeDataBaz;
            if (ligne["dataBazON"].ToString() == "1")
            {
                possedeDataBaz = true;
            }
            else { possedeDataBaz = false; }

            string rapportDeForce = ligne["RapportDeForce"].ToString();

            lblNomPlanete.Text = nomPlanete;

            if(possedeDataBaz) { 
                lblPresenceDataBaz.Text = "Présence de Databaz"; 
            }else { 
                lblPresenceDataBaz.Text = "Pas de Databaz";
            }

            lblRapportDeForce.Text = ligne["RapportDeForce"].ToString();
            lblRapportDeForce.Visible = false;

            //Charger les images

            string cheminImagePlanete = @"..\..\img\" + nomPlanete + ".jpg";
            string cheminImageTemperature = string.Empty;

            if (temperature == -500)
            {
                cheminImageTemperature = @"..\..\img\temperature\attention.jpg";
            }
            else if (temperature < -50)
            {
                cheminImageTemperature = @"..\..\img\temperature\froid.jpg";
            }
            else if (temperature <= 50)
            {

                cheminImageTemperature = @"..\..\img\temperature\tempere.jpg";
            }
            else
            {
                cheminImageTemperature = @"..\..\img\temperature\chaud.jpg";
            }

            try
            {
                picTemperature.Image = UniformiserTaille((Image.FromFile(cheminImageTemperature)), picTemperature.Size);
            picTemperature.SizeMode = PictureBoxSizeMode.CenterImage;
            
                picPlanete.Image = UniformiserTaille((Image.FromFile(cheminImagePlanete)), picPlanete.Size);
            picPlanete.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Image UniformiserTaille(Image imageOriginale, Size tailleCarre)
        {
                return new Bitmap(imageOriginale, tailleCarre);
        }

        private void plnPlanete_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lblNomPlanete.Text + " : " + lblRapportDeForce.Text);
        }

        private void picPlanete_MouseClick(object sender, MouseEventArgs e)
        {
            plnPlanete_MouseClick(sender,e);
        }
    }
}
