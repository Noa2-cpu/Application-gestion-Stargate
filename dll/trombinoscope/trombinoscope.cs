using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trombinoscope
{
    // Déclarer le delegate EN DEHORS de la classe
    public delegate void PlaneteCliqueeHandler(string nomPlanete);

    public partial class trombinoscope : UserControl
    {
        // Déclarer l'événement
        public event PlaneteCliqueeHandler PlaneteCliquee;

        private string nom, img;
        private bool estSurvole = false;

        public trombinoscope()  
        {
            InitializeComponent();
        }

        public trombinoscope(string nom, string image)
        {
            InitializeComponent();
            this.Nom = nom;
            this.img = image;
            chargerComposant();

            this.Click += Trombinoscope_Click;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += Trombinoscope_Click;
            }

            this.MouseEnter += (s, e) => { estSurvole = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { estSurvole = false; this.Invalidate(); };
            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += (s, e) => { estSurvole = true; this.Invalidate(); };
                ctrl.MouseLeave += (s, e) => { estSurvole = false; this.Invalidate(); };
            }
        }

        private void Trombinoscope_Click(object sender, EventArgs e)
        {
            PlaneteCliquee?.Invoke(this.Nom);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Img { get => img; set => img = value; }

        public void chargerComposant()
        {
            this.BackColor = Color.Black;
            this.lblNom.ForeColor = Color.White;
            this.lblNom.Text = nom;
            this.lblNom.Dock = DockStyle.None;
            this.lblNom.AutoSize = false;
            this.lblNom.Width = this.Width - 10;
            this.lblNom.Height = 30;
            this.lblNom.Left = 5;
            this.lblNom.Top = this.Height - 35;
            this.lblNom.TextAlign = ContentAlignment.MiddleCenter;
            if (img != string.Empty)
            {
                pcbDuNom.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbDuNom.SizeMode = PictureBoxSizeMode.Zoom;
                pcbDuNom.Image = Image.FromFile(this.img);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (estSurvole)
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    Color.LightGoldenrodYellow, 3, ButtonBorderStyle.Solid,
                    Color.LightGoldenrodYellow, 3, ButtonBorderStyle.Solid,
                    Color.LightGoldenrodYellow, 3, ButtonBorderStyle.Solid,
                    Color.LightGoldenrodYellow, 3, ButtonBorderStyle.Solid);
            }
        }
    }
}