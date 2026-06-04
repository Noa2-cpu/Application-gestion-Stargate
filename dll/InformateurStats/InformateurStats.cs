using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformateurStats
{
    public partial class InformateurStats: UserControl
    {
        private string code, origine, recu, img;
        public InformateurStats()
        {
            InitializeComponent();
        }

        public InformateurStats(string code, string origine, string recu, string img)
        {
            InitializeComponent();
            this.code = "Code : " + code;
            this.origine = "Espèce d'origine : " + origine;
            this.recu = "Reçu : " + recu + " €";
            this.img = img;
            chargerComposant();
        }

        public string Code { get => code; set => code = value; }
        public string Origine { get => origine; set => origine = value; }
        public string Recu { get => recu; set => recu = value; }
        public string Img { get => img; set => img = value; }

        private void chargerComposant()
        {
            this.lblCode.Text = code;
            this.lblOrigine.Text = origine;
            this.lblRecu.Text = recu;
            this.Paint += InformateurStats_Paint;
            if (img != string.Empty && System.IO.File.Exists(img))
            {
                try
                {
                    pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbImage.Image = Image.FromFile(img);
                }
                catch
                {
                    pcbImage.Image = null;
                }
            }


        }
        private void InformateurStats_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
            Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid);
        }
    }
}
