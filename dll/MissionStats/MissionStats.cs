using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionStats
{
    public partial class MissionStats: UserControl
    {
        private string budgetInitial, nomPlanete, budgetActuel, nomImage;
        public MissionStats()
        {
            InitializeComponent();
        }
        //Constructeur complet
        public MissionStats(string budgetInitial, string nomPlanete, string budgetActuel, string nomImage)
        {
            InitializeComponent();

            this.BudgetInitial = "Budget initial : " + budgetInitial + " €";
            this.nomPlanete = nomPlanete;
            this.BudgetActuel = "Budget actuel : " + budgetActuel + " €";
            this.nomImage = nomImage;

            this.Load += (s, e) => chargerInterface();


        }

        public string NomPlanete { get => nomPlanete; set => nomPlanete = value; }
        

        public string NomImage { get => nomImage; set => nomImage = value; }
        public string BudgetInitial { get => budgetInitial; set => budgetInitial = value; }
        public string BudgetActuel { get => budgetActuel; set => budgetActuel = value; }


        public void chargerInterface()
        {
            // Nom de la mission centré avec retour à la ligne
            lbNom.AutoSize = false;
            lbNom.Width = this.Width - 10;
            lbNom.Left = 5;
            lbNom.Height = 50; // ← Hauteur fixe pour 2 lignes
            lbNom.TextAlign = ContentAlignment.MiddleCenter;
            lbNom.ForeColor = Color.White;
            lbNom.Text = this.nomPlanete;

            // Budget initial avec retour à la ligne
            lblBudgetIni.AutoSize = false;
            lblBudgetIni.Width = this.Width - 10;
            lblBudgetIni.MaximumSize = new Size(this.Width - 10, 0);
            lblBudgetIni.AutoSize = true;
            lblBudgetIni.Text = this.budgetInitial;

            // Budget actuel avec retour à la ligne
            lblBudgetActu.AutoSize = false;
            lblBudgetActu.Width = this.Width - 10;
            lblBudgetActu.MaximumSize = new Size(this.Width - 10, 0);
            lblBudgetActu.AutoSize = true;
            lblBudgetActu.Text = this.budgetActuel;
            this.Paint += MissionsStats_Paint;
            if (nomImage != string.Empty && System.IO.File.Exists(NomImage))
            {
                try
                {
                    pcbPlanete.SizeMode = PictureBoxSizeMode.Zoom;
                    pcbPlanete.Image = Image.FromFile(NomImage);
                }
                catch
                {
                    pcbPlanete.Image = null;
                }
            }
        }

        private void MissionsStats_Paint(object sender, PaintEventArgs e)
        {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid,
                Color.LightGoldenrodYellow, 2, ButtonBorderStyle.Solid);
        }


    }
}
