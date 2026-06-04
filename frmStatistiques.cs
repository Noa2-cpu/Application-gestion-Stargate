using DepenseMission;
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
using trombiMilitaire;
using Trombinoscope;

namespace SAE24
{
    public partial class frmStatistiques : Form
    {
        public frmStatistiques()
        {
            InitializeComponent();
        }

        private void frmStatistiques_Load(object sender, EventArgs e)
        {
            UIStyle.LoadFont("Orbitron-Regular.ttf");
            UIStyle.Apply(this);

            flpDepenses.AutoScroll = false;
            flpDepenses.WrapContents = false;
            flpDepenses.FlowDirection = FlowDirection.LeftToRight;

            // Activer le scroll horizontal manuellement
            flpDepenses.HorizontalScroll.Enabled = true;
            flpDepenses.HorizontalScroll.Visible = true;
            flpDepenses.AutoScroll = true;

            flpMissions.AutoScroll = false;
            flpMissions.WrapContents = false;
            flpMissions.FlowDirection = FlowDirection.LeftToRight;

            // Activer le scroll horizontal manuellement
            flpMissions.HorizontalScroll.Enabled = true;
            flpMissions.HorizontalScroll.Visible = true;
            flpMissions.AutoScroll = true;

            // Couleur du texte des onglets
            tbcStats.DrawMode = TabDrawMode.OwnerDrawFixed;
            tbcStats.DrawItem += tabControl1_DrawItem;

            string sql = @"SELECT DISTINCT m.matricule, m.nom || ' ' || m.prenom as NomPrenom
                   FROM Membre m
                   JOIN Mission mis ON m.matricule = mis.matriculeChef";

            SQLiteDataReader dr;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboMilitaire.Items.Add(dr.GetString(1));
            }

            listeMissionPlanete();
            ListeDepense();
            chargerListeMission10();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tbcStats.TabPages[e.Index];
            Rectangle rect = tbcStats.GetTabRect(e.Index);

            Color couleur;

            if (e.Index == tbcStats.SelectedIndex)
                couleur = Color.Blue;
            else
                couleur = Color.Black;

            TextRenderer.DrawText(
                e.Graphics,
                tabPage.Text,
                tbcStats.Font,
                rect,
                couleur,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter
            );
        }

        private void cboMilitaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            

        }


        public void chargerListeMission10()
        {
            string sql = @"SELECT m.nomPlanete AS Planete,
                                   m.nomPlanete || m.numero AS Mission,
                                   m.budget AS BudgetInitial,
                                   SUM(d.montant) AS TotalDepenses,
                                   (m.budget - SUM(d.montant)) AS BudgetActuel
                            FROM Mission m
                            JOIN Depense d ON m.nomPlanete = d.nomPlanete 
                                           AND m.numero = d.numeroMission
                            WHERE m.numero IN (
                                SELECT numeroMission
                                FROM Composer
                                GROUP BY numeroMission
                                HAVING COUNT(matriculeMembre) > 10
                            )
                            GROUP BY m.numero, m.nomPlanete, m.budget
                            ORDER BY m.nomPlanete";

            SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            flpMissions.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string planete = @"..\..\img\" + row["Planete"].ToString() + ".jpg";      
                string mission = row["Mission"].ToString(); 
                string budgetInitial = row["BudgetInitial"].ToString();
                string totalDepenses = row["TotalDepenses"].ToString();
                string budgetActuel = row["BudgetActuel"].ToString();

                // Créer le UserControl avec les données
                MissionStats.MissionStats ucMission = new MissionStats.MissionStats(budgetInitial, mission, budgetActuel, planete);
                flpMissions.Controls.Add(ucMission);
                UIStyle.Apply(ucMission);
            }
        }

        public void listeMissionPlanete()
        {
            
            string sql = @"SELECT p.nom AS Planete, COUNT(m.numero) AS NombreMissions
                FROM Planete p
                LEFT JOIN Mission m ON p.nom = m.nomPlanete
                GROUP BY p.nom
                ORDER BY COUNT(m.numero) DESC;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);

            if (MesDatas.DsGlobal.Tables.Contains("Planete"))
                MesDatas.DsGlobal.Tables["Planete"].Clear();

            da.Fill(MesDatas.DsGlobal, "Planete");

            foreach (DataRow row in MesDatas.DsGlobal.Tables["Planete"].Rows)
            {
                string nomPlanete = row["Planete"].ToString();     
                string nbMissions = row["NombreMissions"].ToString();
                string img = @"..\..\img\" + nomPlanete + ".jpg";

                try
                {
                    trombinoscope tromb = new trombinoscope(nomPlanete, img);   
                    tromb.PlaneteCliquee += Tromb_PlaneteCliquee;
                    fwlpPlanete.Controls.Add(tromb);
                    UIStyle.Apply(tromb);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message + "\nPlanète : " + nomPlanete + "\nImage : " + img);
                }
            }
        }

        private void Tromb_PlaneteCliquee(string nomPlanete)
        {
            DataRow[] rows = MesDatas.DsGlobal.Tables["Planete"]
                             .Select("Planete = '" + nomPlanete + "'");

            if (rows.Length > 0)
            {
                string nbMissions = rows[0]["NombreMissions"].ToString(); 
                MessageBox.Show("Planète : " + nomPlanete + "\nNombre de missions : " + nbMissions);
            }
        }

        private void ListeDepense()
        {
            string sql = @"SELECT m.nomPlanete AS Planete,
                             m.nomPlanete || m.numero AS Mission, 
                             mem.nom || ' ' || mem.prenom AS Chef, 
                             CASE WHEN d.dateD LIKE '__/__/____' THEN d.dateD 
                             ELSE strftime('%d/%m/%Y', d.dateD) END 
                             || ' - ' || d.motif || ' - ' || d.montant || ' EUR' AS DepensePlusImportante 
                             FROM Depense d 
                             JOIN Mission m ON d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero 
                             JOIN Membre mem ON m.matriculeChef = mem.matricule 
                             JOIN (SELECT nomPlanete, numeroMission, MAX(montant) AS maxMontant 
                             FROM Depense 
                             GROUP BY nomPlanete, numeroMission) maxDep 
                             ON d.nomPlanete = maxDep.nomPlanete 
                             AND d.numeroMission = maxDep.numeroMission 
                             AND d.montant = maxDep.maxMontant 
                             ORDER BY m.nomPlanete";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);

            // Stocker dans le DataSet
            if (MesDatas.DsGlobal.Tables.Contains("DepensesImportantes"))
                MesDatas.DsGlobal.Tables["DepensesImportantes"].Clear();

            da.Fill(MesDatas.DsGlobal, "DepensesImportantes");

            // Debug : combien de lignes ?
            MessageBox.Show("Nombre de lignes : " + MesDatas.DsGlobal.Tables["DepensesImportantes"].Rows.Count);

            foreach (DataRow row in MesDatas.DsGlobal.Tables["DepensesImportantes"].Rows)
            {
                MessageBox.Show(row["Mission"].ToString()); // Affiche chaque mission

                string planete = @"..\..\img\" + row["Planete"].ToString() + ".jpg";
                string mission = row["Mission"].ToString();
                string chef = row["Chef"].ToString();
                string commentaire = row["DepensePlusImportante"].ToString();

                DepenseMission.DepenseMission ucDepense = new DepenseMission.DepenseMission(mission, chef, commentaire, planete);
                flpDepenses.Controls.Add(ucDepense);
                UIStyle.Apply(ucDepense);
            }
        }

        private void cboVoyage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cboMilitaire.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un chef de mission. ");
            }
            else
            {
                flpParticipant.Controls.Clear();
                string sql = @"SELECT DISTINCT m2.nom, m2.prenom, mil.grade, civ.Specialite
                             FROM Mission mis
                             JOIN Composer c2 ON mis.nomPlanete = c2.nomPlanete AND mis.numero = c2.numeroMission 
                             JOIN Membre m1 ON mis.matriculeChef = m1.matricule 
                             JOIN Membre m2 ON c2.matriculeMembre = m2.matricule 
                             LEFT JOIN Militaire mil ON m2.matricule = mil.matriculeMembre 
                             LEFT JOIN Civil civ ON m2.matricule = civ.matriculeMembre
                             WHERE m1.nom || ' ' || m1.prenom = '" + cboMilitaire.SelectedItem.ToString() +
                                 "' AND m2.matricule <> m1.matricule ORDER BY m2.nom, m2.prenom";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string grade = row["grade"].ToString();
                    string specialite = row["Specialite"].ToString();
                    string nom = row["nom"].ToString();
                    string prenom = row["prenom"].ToString();

                    if (grade != "")
                    {
                        string img = @"..\..\img\Militaire.png";
                        TrombiMilitaire trombi = new TrombiMilitaire(nom + " " + prenom, img);
                        flpParticipant.Controls.Add(trombi);
                        UIStyle.Apply(trombi);
                    }
                    else
                    {
                        string img = @"..\..\img\Civil.png";
                        TrombiMilitaire trombi = new TrombiMilitaire(nom + " " + prenom, img);
                        flpParticipant.Controls.Add(trombi);
                        UIStyle.Apply(trombi);
                    }
                }
            }
        }

        private void tbrnReinitialiser_Click(object sender, EventArgs e)
        {
            flpParticipant.Controls.Clear();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeInformateur()
        {

        }

        private void cboMilitaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fwlpPlanete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbcStats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flpParticipant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpMilitaire_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void grpMission_Enter(object sender, EventArgs e)
        {

        }

        private void flpMissions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void flpInformateur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void flpDepenses_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
