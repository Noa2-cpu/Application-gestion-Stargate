using appliPandora;
using ListeMission;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string sql = @"SELECT m.nomPlanete, mi.nom || ' ' || mi.prenom, dateDepart, dateRetour, budget FROM Mission m
                                JOIN Composer c ON m.numero = c.numeroMission
                                JOIN Membre mi ON mi.matricule = c.matriculeMembre 
                                WHERE m.matriculeChef = matricule
                                ORDER BY 1;";

                SQLiteDataReader dr;
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                dr = cmd.ExecuteReader();

                int x = 337;
                int y = 26;
                int i = 0;
                while (dr.Read())
                {

                    string nom = dr.GetString(0);
                    string chef = dr.GetString(1);
                    string depart = dr.GetString(2);
                    string retour = dr.GetString(3);
                    string budget = dr.GetInt32(4).ToString();
                    string img = @"..\..\img\" + nom +".jpg";

                    listeMission lstMission = new listeMission(budget, nom, depart, retour, chef, img);
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
            catch(SQLiteException err)
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
            //Form ConnexionAdmin = new ConnexionAdmin(this);
            //ConnexionAdmin.ShowDialog();
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
