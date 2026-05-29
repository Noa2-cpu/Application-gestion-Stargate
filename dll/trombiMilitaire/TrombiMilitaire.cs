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
            chargerComposant();

        }

        public string Nom { get => nom; set => nom = value; }
        public string Img { get => img; set => img = value; }

        public void chargerComposant()
        {
            this.BackColor = Color.Black;
            this.lblNom.ForeColor = Color.White;
            this.lblNom.Text = nom;
            this.lblNom.AutoSize = false;
            this.lblNom.Dock = DockStyle.None;
            this.lblNom.AutoSize = false;
            this.lblNom.Width = this.Width - 10;   // ← Moins large que le UC
            this.lblNom.Height = 30;
            this.lblNom.Left = 5;                  // ← 5px depuis la gauche
            this.lblNom.Top = this.Height - 35;    // ← 5px depuis le bas
            this.lblNom.TextAlign = ContentAlignment.MiddleCenter;
            this.Paint += ListeMission_Paint;
            if (img != string.Empty)
            {
                pcbDuNom.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbDuNom.SizeMode = PictureBoxSizeMode.Zoom;
                pcbDuNom.Image = Image.FromFile(this.img);
            }
        }

        private void ListeMission_Paint(object sender, PaintEventArgs e)
        {
           
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid);
        }
    }
}
