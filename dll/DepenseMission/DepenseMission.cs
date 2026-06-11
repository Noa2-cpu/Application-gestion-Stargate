using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DepenseMission
{
    public partial class DepenseMission: UserControl
    {
        private string nomMission, nomChef, commentaire, nomImage;
        public DepenseMission()
        {
            InitializeComponent();
        }


        public DepenseMission(string nomMission, string nomChef, string commentaire, string nomImage)
        {
            InitializeComponent();

            this.nomMission = nomMission;
            this.nomChef = "Chef : " + nomChef;
            this.commentaire = "Commentaire : \n\n" + commentaire;
            this.nomImage = nomImage;

            chargerInterface();


        }

        public string NomMission { get => nomMission; set => nomMission = value; }
        public string NomChef { get => nomChef; set => nomChef = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public string NomImage { get => nomImage; set => nomImage = value; }

        public void chargerInterface()
        {
            lblChef.Text = this.nomChef;

            // Label nom mission centré avec retour à la ligne
            lblNomMission.AutoSize = false;
            lblNomMission.Height = 50;
            lblNomMission.TextAlign = ContentAlignment.MiddleCenter;
            lblNomMission.Text = this.nomMission;

            // Label commentaire
            lblCommentaire.AutoSize = false;
            lblCommentaire.Dock = DockStyle.Fill;
            lblCommentaire.MaximumSize = new Size(grpDepense.Width - 10, 0);
            lblCommentaire.AutoSize = true;
            lblCommentaire.Text = this.commentaire;

            this.Paint += DepenseMission_Paint;

            if (nomImage != string.Empty && System.IO.File.Exists(nomImage))
            {
                try
                {
                    pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbImage.Image = Image.FromFile(this.nomImage);
                }
                catch
                {
                    pcbImage.Image = null;
                }
            }
        }

        private void DepenseMission_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid);
        }
    }
}
