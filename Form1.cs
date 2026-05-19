using ListeMission;
using System;
using System.Data.SQLite;
using System.Drawing;
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
                int x2 = 630;
                int y2 = 75;
                int i = 0;
                while (dr.Read())
                {

                    string nom = dr.GetString(0);
                    string chef = dr.GetString(1);
                    string depart = dr.GetString(2);
                    string retour = dr.GetString(3);
                    string budget = dr.GetInt32(4).ToString();
                    string img = @"..\..\img\Mercure.jpg";

                    listeMission lstMission = new listeMission(budget, nom, depart, retour, chef, img);
                    lstMission.Location = new System.Drawing.Point(x, y);


                    Button btnMission = new Button();

                    btnMission.Location = new System.Drawing.Point(x2, y2);
                    btnMission.Name = "btn" + i;
                    btnMission.Size = new System.Drawing.Size(27, 27);
                    btnMission.TabIndex = i;
                    btnMission.UseVisualStyleBackColor = true;
                    btnMission.BackgroundImage = Image.FromFile(@"..\..\img\oeil.jpg");
                    btnMission.BackgroundImageLayout = ImageLayout.Zoom;


                    this.Controls.Add(lstMission);
                    this.Controls.Add(btnMission);

                    btnMission.BringToFront();

                    y2 += 100;
                    y += 100;
                    i++;
                }

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ConnexionAdmin = new ConnexionAdmin(this);
            ConnexionAdmin.ShowDialog();
        }
    }
}
