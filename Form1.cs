using SAE24;
using ListeMission;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace SAE24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIStyle.LoadFont("Orbitron-Regular.ttf");
            UIStyle.Apply(this);
            // Déléguer au rafraîchissement public pour permettre réutilisation
            try
            {            
                RefreshMissions();
                
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
                
             RefreshMissions();
            
        }

        // Méthode publique pour recharger l'affichage des missions
        public void RefreshMissions()
        {
            string sql = @"SELECT m.nomPlanete, mi.nom || ' ' || mi.prenom AS chef, m.dateDepart, m.dateRetour, m.budget, m.numero
                               FROM Mission m
                               JOIN Membre mi ON mi.matricule = m.matriculeChef
                               ORDER BY m.nomPlanete";
            SQLiteDataReader dr;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            dr = cmd.ExecuteReader();

            int x = 337;
            int y = 26;
            int i = 0;
            while (dr.Read())
            {
                string nom = dr.GetString(0);
                string nomMission = dr.GetString(0) + dr.GetInt16(5);
                string chef = dr.GetString(1);
                string departBrut = dr[2].ToString();
                string depart;
                string retourBrut = dr[3].ToString();
                int numero = dr.GetInt16(5);
                string retour;
                string img = @"..\..\img\" + nom + ".jpg";
                

                if (DateTime.TryParse(departBrut, out DateTime dep))
                {
                    depart = dep.ToString("dd/MM/yyyy");
                }
                else
                {
                    depart = departBrut;
                }

                if (DateTime.TryParse(retourBrut, out DateTime reto))
                {
                    retour = reto.ToString("dd/MM/yyyy");
                }
                else
                {
                    retour = retourBrut;
                }

                string budget = dr.GetInt32(4).ToString();

                DateTime dateRetour = Convert.ToDateTime(retourBrut);
                DateTime dateDepart = Convert.ToDateTime(departBrut);
                DateTime aujourdHui = DateTime.Today;
                Color color;
                if (dateRetour > aujourdHui && dateDepart < aujourdHui)
                {
                    color = Color.FromArgb(0, 3, 63);
                }
                else if (dateRetour < aujourdHui)
                {
                    color = Color.FromArgb(50, 50, 50); 
                }
                else
                {
                    color = Color.FromArgb(0, 60, 39); 
                }
                listeMission lstMission = new listeMission(budget, nomMission, depart, retour, chef, img, color);
                lstMission.Location = new System.Drawing.Point(x, y);
                lstMission.Tag = Tuple.Create(nom, numero);
                flpMissions.Controls.Add(lstMission);
                lstMission.afficheur = detailMission;
                UIStyle.ApplySansBackground(lstMission);

                y += 100;
                i++;

            }

            InitialiserDataSet();

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);

            MesDatas.DsGlobal.Tables["Mission"].Clear();

            da.Fill(MesDatas.DsGlobal, "Mission");
        }




        private void InitialiserDataSet()
        {
            if (!MesDatas.DsGlobal.Tables.Contains("Mission"))
            {
                DataTable dtMission = new DataTable("Mission");
                dtMission.Columns.Add("nomPlanete", typeof(string));
                dtMission.Columns.Add("numero", typeof(int));
                dtMission.Columns.Add("chef", typeof(string));
                dtMission.Columns.Add("dateDepart", typeof(string));
                dtMission.Columns.Add("dateRetour", typeof(string));
                dtMission.Columns.Add("budget", typeof(int));

                MesDatas.DsGlobal.Tables.Add(dtMission);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ConnexionAdmin = new ConnexionAdmin(this);
            ConnexionAdmin.ShowDialog();
        }

        private void detailMission(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ListeMission.listeMission uc = (ListeMission.listeMission)btn.Parent;

            // récupérer les informations stockées dans le Tag (nomPlanete, numero)
            if (uc.Tag is Tuple<string, int> info)
            {
                string nomPlanete = info.Item1;
                int numero = info.Item2;

                Form detailMission = new DetailMissions(nomPlanete, numero);
                detailMission.ShowDialog();
            }
            else
            {
                //si pas d'info
                Form detailMission = new DetailMissions();
                detailMission.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frmStat = new frmStatistiques();
            frmStat.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form RepertoireRaces = new RepertoireRaces();
            RepertoireRaces.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form RepertoirePlanete = new RepertoirePlanete();
            RepertoirePlanete.ShowDialog();
        }
    }
}
