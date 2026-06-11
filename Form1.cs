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
                if (dateDepart > aujourdHui)
                {
                    color = Color.FromArgb(0, 3, 63);        // Bleu = à venir
                }
                else if (dateDepart <= aujourdHui && dateRetour >= aujourdHui)
                {
                    color = Color.FromArgb(0, 60, 39);       // Vert = en cours
                }
                else
                {
                    color = Color.FromArgb(50, 50, 50);      // Gris = terminée
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
            ListeMission.listeMission uc = (ListeMission.listeMission)sender;

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
            Form repertoirePlanetes = new RepertoirePlanetes();
            repertoirePlanetes.ShowDialog();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            flpMissions.Controls.Clear();
            AppliquerFiltres();
            chkbAVenir.Checked = false;
            chkbEnCours.Checked = false;
            chkbTerminer.Checked = false;
            txtbFiltre.Text = "";
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            flpMissions.Controls.Clear();
            RefreshMissions();
            chkbAVenir.Checked = false;
            chkbEnCours.Checked = false;
            chkbTerminer.Checked = false;
            txtbFiltre.Text = "";
        }

        private void AppliquerFiltres()
        {
            string filtre = "";

            // Filtre par nom de mission (TextBox)
            if (txtbFiltre.Text != "")
            {
                filtre += "nomPlanete LIKE '%" + txtbFiltre.Text + "%'";
            }

            // Filtre par statut (CheckBox)
            string filtreStatut = "";

            if (chkbEnCours.Checked)
                filtreStatut += "dateDepart <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND dateRetour >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";

            if (chkbTerminer.Checked)
            {
                if (filtreStatut != "") filtreStatut += " OR ";
                filtreStatut += "dateRetour < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            }

            if (chkbAVenir.Checked)
            {
                if (filtreStatut != "") filtreStatut += " OR ";
                filtreStatut += "dateDepart > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            }

            // Combiner nom + statut
            if (filtreStatut != "")
            {
                if (filtre != "") filtre += " AND ";
                filtre += "(" + filtreStatut + ")";
            }

            // Appliquer le filtre sur le DataSet
            DataView dv = new DataView(MesDatas.DsGlobal.Tables["Mission"]);
            dv.RowFilter = filtre;

            // Vider et réafficher les UserControls
            flpMissions.Controls.Clear();

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                string nom = row["nomPlanete"].ToString();
                string numero = row["numero"].ToString();
                string nomMission = nom + numero; // ← D'abord on crée nomMission
                string chef = row["chef"].ToString();
                string depart = row["dateDepart"].ToString();
                string retour = row["dateRetour"].ToString();
                string budget = row["budget"].ToString();
                string img = @"..\..\img\" + nom + ".jpg";

                DateTime dateDepart = Convert.ToDateTime(depart);
                DateTime dateRetour = Convert.ToDateTime(retour);
                DateTime aujourdhui = DateTime.Now;

                // Filtre par nom de mission ← ICI après nomMission
                if (txtbFiltre.Text != "" && !nomMission.ToLower().Contains(txtbFiltre.Text.ToLower()))
                    continue;

                // Filtre par statut
                bool enCours = aujourdhui >= dateDepart && aujourdhui <= dateRetour;
                bool terminee = dateRetour < aujourdhui;
                bool aVenir = dateDepart > aujourdhui;

                bool aucuneCochee = !chkbEnCours.Checked && !chkbTerminer.Checked && !chkbAVenir.Checked;

                if (!aucuneCochee)
                {
                    bool afficher = false;

                    if (chkbEnCours.Checked && enCours) afficher = true;
                    if (chkbTerminer.Checked && terminee) afficher = true;
                    if (chkbAVenir.Checked && aVenir) afficher = true;

                    if (!afficher) continue; 
                }

                Color couleur;
                if (aVenir)
                    couleur = Color.FromArgb(0, 3, 63);
                else if (enCours)
                    couleur = Color.FromArgb(0, 60, 39);
                else
                    couleur = Color.FromArgb(50, 50, 50);

                listeMission lstMission = new listeMission(budget, nomMission, depart, retour, chef, img, couleur);
                flpMissions.Controls.Add(lstMission);
                lstMission.afficheur = detailMission;
                UIStyle.ApplySansBackground(lstMission);
            }
        }

        private void btnAppliquer_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtbFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                flpMissions.Controls.Clear();
                AppliquerFiltres();
                txtbFiltre.Text = "";
                chkbAVenir.Checked = false;
                chkbEnCours.Checked = false;
                chkbTerminer.Checked = false;
            }
        }
    }
}
