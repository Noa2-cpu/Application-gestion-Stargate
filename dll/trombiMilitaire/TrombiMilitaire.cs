using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trombiMilitaire
{
    public partial class TrombiMilitaire: UserControl
    {
        private string nom, img;
        public TrombiMilitaire()
        {
            InitializeComponent();
        }

        public TrombiMilitaire(string nom, string image)
        {
            InitializeComponent();
            this.Nom = nom;
            this.img = image;

            this.Load += (s, e) => {
                lblNom.AutoSize = false;
                lblNom.Width = this.Width;
                lblNom.Left = 0;
                lblNom.TextAlign = ContentAlignment.MiddleCenter;
                lblNom.MinimumSize = new Size(this.Width, 40);
                lblNom.MaximumSize = new Size(this.Width, 0);
                lblNom.AutoSize = true;
                lblNom.Text = nom;
                lblNom.Top = this.Height - lblNom.Height - 10;
                chargerComposant(); 
            };
        }

        public string Nom { get => nom; set => nom = value; }
        public string Img { get => img; set => img = value; }

        public void chargerComposant()
        {
            this.Paint += TrombiMilitaire_Paint;

            if (img != string.Empty && System.IO.File.Exists(img))
            {
                try
                {
                    pcbDuNom.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbDuNom.Image = Image.FromFile(img);
                }
                catch
                {
                    pcbDuNom.Image = null;
                }
            }
        }

        private void TrombiMilitaire_Paint(object sender, PaintEventArgs e)
        {
           
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid);
        }
    }
}
