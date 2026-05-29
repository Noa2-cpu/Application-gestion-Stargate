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
            try
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

                    string nom = dr.GetString(0) + dr.GetInt16(5);
                    string chef = dr.GetString(1);
                    string departBrut = dr[2].ToString();
                    string depart;
                    string retourBrut = dr[3].ToString();
                    string retour;

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
                    string img = @"..\..\img\" + dr.GetString(0) +".jpg";

                    DateTime dateRetour = Convert.ToDateTime(retourBrut);
                    DateTime dateDepart = Convert.ToDateTime(departBrut);
                    DateTime aujourdHui = DateTime.Today;
                    Color color;
                    if (dateRetour > aujourdHui && dateDepart < aujourdHui)
                    {
                        color = Color.DarkGreen;
                    }
                    else if (dateRetour < aujourdHui)
                    {
                        color = Color.DarkGray;
                    }
                    else
                    {
                        color = Color.DarkBlue;
                    }



                    listeMission lstMission = new listeMission(budget, nom, depart, retour, chef, img, color);
                    lstMission.Location = new System.Drawing.Point(x, y);
                    flowLayoutPanel1.Controls.Add(lstMission);
                    lstMission.afficheur = detailMission;

                    y += 100;
                    i++;

                }

                InitialiserDataSet();

                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);

                MesDatas.DsGlobal.Tables["Mission"].Clear();

                da.Fill(MesDatas.DsGlobal, "Mission");

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InitialiserDataSet()
        {
            if (!MesDatas.DsGlobal.Tables.Contains("Mission"))
            {
                DataTable dtMission = new DataTable("Mission");
                dtMission.Columns.Add("nomPlanete", typeof(string));
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

            Form form = new Form();
            form.ShowDialog();
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
    }
}
