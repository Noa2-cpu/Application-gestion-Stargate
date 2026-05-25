using ListeMission;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SAE24
{
    public partial class DetailMissions : Form
    {
        string nomPlanete;
        int numero;
        public DetailMissions()
        {
            InitializeComponent();
        }

        public DetailMissions(string nomPlanete, int numero)
        {
            InitializeComponent();
            this.nomPlanete = nomPlanete;
            this.numero = numero;
            
        }

        private void DetailMissions_Load(object sender, EventArgs e)
        {
            string chargerDocument = @"SELECT * 
                                       FROM Mission        
                                       WHERE nomPlanete = @planete AND numero = @numero;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(chargerDocument, Connexion.Connec);
            da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da.SelectCommand.Parameters.AddWithValue("@numero", numero);

            DataTable dt = new DataTable();
            da.Fill(dt);

            LblTitre.Text = "Mission " + nomPlanete + " " + numero;

            string img = @"..\..\img\" + nomPlanete + ".jpg";

            PbAfficherPlanete.SizeMode = PictureBoxSizeMode.CenterImage;
            PbAfficherPlanete.SizeMode = PictureBoxSizeMode.Zoom;
            PbAfficherPlanete.Image = Image.FromFile(img);

            LblDepart.Text += dt.Rows[0]["dateDepart"].ToString();
            LblRetour.Text += dt.Rows[0]["dateRetour"].ToString();

            LblBudget.Text += dt.Rows[0]["budget"].ToString() + " €";

            RtbFeuilleRoute.Text = dt.Rows[0]["feuilleDeRoute"].ToString();


            string chargerAstro = @"SELECT m.nom, m.prenom, c.matriculeMembre
                                    FROM Composer c
                                    JOIN Membre m ON c.matriculeMembre = m.matricule
                                    WHERE c.nomPlanete = @planete AND c.numeroMission = @numero;";


            SQLiteDataAdapter da2 = new SQLiteDataAdapter(chargerAstro, Connexion.Connec);
            da2.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da2.SelectCommand.Parameters.AddWithValue("@numero", numero);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            int startX = 10;
            int x = 10;
            int y = 20;
            int hSpace = 5; // espace horizontal entre contrôles
            int vSpace = 5; // espace vertical entre contrôles

            foreach (DataRow dr in dt2.Rows)
            {
                string matricule = dr["matriculeMembre"].ToString();
                if (matricule.StartsWith("M"))
                {
                    string nom = dr["nom"].ToString();
                    string prenom = dr["prenom"].ToString();
                    string imgAstro = @"..\..\img\Militaire.png";

                    MilitaireCivil militaireCivil = new MilitaireCivil(nom, prenom, imgAstro);
                    // Initialiser l'affichage du UserControl (remplit labels et image)
                    militaireCivil.chargerInterface();

                    // Si le contrôle dépasse la largeur du groupbox, passer à la ligne suivante
                    if (x + militaireCivil.Width > GrpEscouade.ClientSize.Width - 20)
                    {
                        x = startX;
                        y += militaireCivil.Height + vSpace;
                    }

                    militaireCivil.Location = new System.Drawing.Point(x, y);
                    panel1.Controls.Add(militaireCivil);

                    x += militaireCivil.Width + hSpace;
                }
                else
                {
                    string nomC = dr["nom"].ToString();
                    string prenomC = dr["prenom"].ToString();
                    string imgAstroC = @"..\..\img\Civil.png";

                    MilitaireCivil militaireCivil = new MilitaireCivil(nomC, prenomC, imgAstroC);
                    // Initialiser l'affichage du UserControl (remplit labels et image)
                    militaireCivil.chargerInterface();

                    // Si le contrôle dépasse la largeur du groupbox, passer à la ligne suivante
                    if (x + militaireCivil.Width > GrpEscouade.ClientSize.Width - 20)
                    {
                        x = startX;
                        y += militaireCivil.Height + vSpace;
                    }

                    militaireCivil.Location = new System.Drawing.Point(x, y);
                    panel1.Controls.Add(militaireCivil);

                    x += militaireCivil.Width + hSpace;
                }
            }

            string chargerCaptures = @"SELECT o.objectif, o.idEspeceEnnemi, es.nom
                                       FROM ObjectifCapture o
                                       JOIN Ennemi e ON o.idEspeceEnnemi = e.idEspece
                                       JOIN Espece es ON e.idEspece = es.id
                                       WHERE o.nomPlanete = @planete AND o.numeroMission = @numero;";

            SQLiteDataAdapter da3 = new SQLiteDataAdapter(chargerCaptures, Connexion.Connec);
            da3.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da3.SelectCommand.Parameters.AddWithValue("@numero", numero);

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            int x2 = 10;
            int y2 = 20;

            foreach (DataRow dr in dt3.Rows) 
            {
                string NbCaptures = dr["nom"].ToString() + " --> " + dr["objectif"].ToString() + " prise(s).";

                Label LblAfficherNbCaptures = new Label();
                LblAfficherNbCaptures.AutoSize = true;
                LblAfficherNbCaptures.Text = NbCaptures;
                LblAfficherNbCaptures.Location = new System.Drawing.Point(x2, y2);


                GrpObjectifCapture.Controls.Add(LblAfficherNbCaptures);

                y2 += LblAfficherNbCaptures.Height;
            }
        }

        private void RtbFeuilleRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
           
        }
    }
}
