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
            UIStyle.LoadFont("Orbitron-Regular.ttf", 10f);
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
        }

        // Méthode publique pour recharger l'affichage des missions
        public void RefreshMissions()
        {
            string sql = @"SELECT m.nomPlanete, mi.nom || ' ' || mi.prenom, dateDepart, dateRetour, budget, m.numero FROM Mission m
                                JOIN Composer c ON m.numero = c.numeroMission
                                JOIN Membre mi ON mi.matricule = c.matriculeMembre 
                                WHERE m.matriculeChef = matricule
                                ORDER BY 1;";

            SQLiteDataReader dr;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            dr = cmd.ExecuteReader();

            flowLayoutPanel1.Controls.Clear();

            int x = 337;
            int y = 26;
            while (dr.Read())
            {
                string nom = dr.GetString(0);
                string chef = dr.GetString(1);
                string depart = dr.GetString(2);
                string retour = dr.GetString(3);
                string budget = dr.GetInt32(4).ToString();
                int numero = dr.GetInt32(5);
                string img = @"..\..\img\" + nom + ".jpg";

                listeMission lstMission = new listeMission(budget, nom, depart, retour, chef, img);
                lstMission.Location = new System.Drawing.Point(x, y);
                // stocker les informations essentielles dans le Tag pour pouvoir les récupérer
                lstMission.Tag = Tuple.Create(nom, numero);
                flowLayoutPanel1.Controls.Add(lstMission);
                lstMission.afficheur = detailMission;

                y += 100;
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
