using System.Drawing;
using System.Drawing.Configuration;
using System.Windows.Forms;

namespace ListeMission
{
    public delegate void afficherDetails(object sender, System.EventArgs e);
    public partial class listeMission: UserControl
    {
        //attributs
        private string budget, nomPlanete, depart, retour, chef, nomImage;
        private Color couleur;

        //Constructeur de base
        public listeMission()
        {
            InitializeComponent();
        }

        //Constructeur complet
        public listeMission(string budget, string nomPlanete, string depart, string retour, string chef, string nomImage, Color couleur)
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.FixedSingle;


            this.budget = "Budget : " + budget;
            this.nomPlanete = nomPlanete;
            this.depart = "Départ : " + depart;
            this.retour = "Retour : " + retour;
            this.chef = "Chef : " + chef;
            this.nomImage = nomImage;
            this.Couleur = couleur;

            chargerInterface();

            
        }

        public string Budget { get => budget; set => budget = value; }
        public string NomPlanete { get => nomPlanete; set => nomPlanete = value; }
        public string Depart { get => depart; set => depart = value; }
        public string Retour { get => retour; set => retour = value; }

        private void btnDetail_Click(object sender, System.EventArgs e)
        {
            if (this.afficheur != null)
            {
                this.afficheur(sender, e);
            }
        }

        public string Chef { get => chef; set => chef = value; }
        public string NomImage { get => nomImage; set => nomImage = value; }
        public Color Couleur { get => couleur; set => couleur = value; }

        public afficherDetails afficheur;
       
        public void chargerInterface()
        {
            lblBudget.Text = this.budget;
            lbNom.Text = this.nomPlanete;
            lblDepart.Text = this.depart;
            lblRetour.Text = this.retour;
            lblChef.Text = this.chef;
            this.BackColor = Couleur;
            if (nomImage != string.Empty)
            {
                pcbPlanete.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbPlanete.SizeMode = PictureBoxSizeMode.Zoom;
                pcbPlanete.Image = Image.FromFile(this.nomImage);
            }
        }



    }

}

