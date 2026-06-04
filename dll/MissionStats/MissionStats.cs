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

            this.BudgetInitial = "Budget initial : " + budgetInitial;
            this.nomPlanete = nomPlanete;
            this.BudgetActuel = "Budget actuel : " + budgetActuel;
            this.nomImage = nomImage;

            chargerInterface();


        }

        public string NomPlanete { get => nomPlanete; set => nomPlanete = value; }
        

        public string NomImage { get => nomImage; set => nomImage = value; }
        public string BudgetInitial { get => budgetInitial; set => budgetInitial = value; }
        public string BudgetActuel { get => budgetActuel; set => budgetActuel = value; }


        public void chargerInterface()
        {
            lblBudgetActu.Text = this.budgetActuel;
            lbNom.Text = this.nomPlanete;
            lblBudgetIni.Text = this.budgetInitial;
            this.lbNom.ForeColor = Color.White;
            this.lbNom.AutoSize = false;
            this.lbNom.TextAlign = ContentAlignment.MiddleCenter;
            if (nomImage != string.Empty)
            {
                pcbPlanete.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbPlanete.SizeMode = PictureBoxSizeMode.Zoom;
                pcbPlanete.Image = Image.FromFile(this.nomImage);
            }
        }



    
    }
}
