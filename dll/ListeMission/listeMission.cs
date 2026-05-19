using System.Drawing;
using System.Windows.Forms;

namespace ListeMission
{
    public partial class listeMission : UserControl
    {
        //attributs
        private string budget, nomPlanete, depart, retour, chef, nomImage;

        //Constructeur de base
        public listeMission()
        {
            InitializeComponent();
        }

        //Constructeur complet
        public listeMission(string budget, string nomPlanete, string depart, string retour, string chef, string nomImage)
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.FixedSingle;


            this.budget = "Budget : " + budget;
            this.nomPlanete = nomPlanete;
            this.depart = "Départ : " + depart;
            this.retour = "Retour : " + retour;
            this.chef = "Chef : " + chef;
            this.nomImage = nomImage;

            chargerInterface();


        }

        public string Budget { get => budget; set => budget = value; }
        public string NomPlanete { get => nomPlanete; set => nomPlanete = value; }
        public string Depart { get => depart; set => depart = value; }
        public string Retour { get => retour; set => retour = value; }
        public string Chef { get => chef; set => chef = value; }
        public string NomImage { get => nomImage; set => nomImage = value; }

        public void chargerInterface()
        {
            lblBudget.Text = this.budget;
            lbNom.Text = this.nomPlanete;
            lblDepart.Text = this.depart;
            lblRetour.Text = this.retour;
            lblChef.Text = this.chef;
            if (nomImage != string.Empty)
            {
                pcbPlanete.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbPlanete.SizeMode = PictureBoxSizeMode.Zoom;
                pcbPlanete.Image = Image.FromFile(this.nomImage);
            }
        }



    }

}

