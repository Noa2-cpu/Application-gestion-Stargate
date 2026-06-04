using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SAE24
{
    public partial class GrpContact : Form
    {
        private DataTable dtEvenements = new DataTable();

        private BindingSource bsEvenements = new BindingSource();

        string nomPlanete;
        int numeroMission;
        double taux;
        public GrpContact()
        {
            InitializeComponent();
        }

        public GrpContact(string nom, int numero)
        {
            InitializeComponent();
            this.nomPlanete = nom;
            this.numeroMission = numero;
        }

        private void GrpContact_Load(object sender, EventArgs e)
        {
            UIStyle.LoadFont("Orbitron-Regular.ttf");
            UIStyle.Apply(this);
            string sql = @"SELECT dateJ, commentaires
                           FROM JournalDeBord
                           WHERE nomplanete = @planete AND numero = @numero;";

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);
            da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            da.Fill(dtEvenements);
            bsEvenements.DataSource = dtEvenements;

            AfficherEvenement();


            string chargerContact = @"SELECT c.dateC, c.sommeVersee, c.appreciation, i.nom AS nom
                                      FROM Informateur i
                                      JOIN Contact c ON i.nomCode = c.nomCodeInformateur
                                      WHERE c.nomPlanete = @planete AND c.numeroMission = @numero;";

            SQLiteDataAdapter da2 = new SQLiteDataAdapter(chargerContact, Connexion.Connec);
            da2.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da2.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            DgvAfficherContact.DataSource = dt2;


            string chargerDepense = @"SELECT d.id, d.dateD, d.motif, d.montant, t.libelle
                                      FROM Depense d
                                      JOIN TypeDepense t 
                                      ON d.idTypeDepense = t.id
                                      WHERE d.nomPlanete = @planete AND d.numeroMission = @numero;";

            SQLiteDataAdapter da3 = new SQLiteDataAdapter(chargerDepense, Connexion.Connec);
            da3.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da3.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            DgvDepenses.DataSource = dt3;

            string dep = @"SELECT SUM(montant) AS total
                            FROM Depense
                            WHERE nomPlanete = @planete AND numeroMission = @numero;";

            SQLiteDataAdapter da4 = new SQLiteDataAdapter(dep, Connexion.Connec);
            da4.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da4.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            LblTotalDepense.Text = "Total des dépenses : " + dt4.Rows[0]["total"] + " €";


            string depContact = @"SELECT SUM(sommeVersee) AS total
                            FROM Contact
                            WHERE nomPlanete = @planete AND numeroMission = @numero;";

            SQLiteDataAdapter da5 = new SQLiteDataAdapter(depContact, Connexion.Connec);
            da5.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da5.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            LblSommeContact.Text = "Total des sommes versées aux informateurs : " + dt5.Rows[0]["total"] + " €";



            DataTable bilan = new DataTable("BilanCapture" + nomPlanete + "_" + numeroMission);

            bilan.Columns.Add("NomEspece", typeof(string));
            bilan.Columns.Add("ObjectifInitial", typeof(int));
            bilan.Columns.Add("NbCaptures", typeof(int));
            bilan.Columns.Add("TauxReussite", typeof(string));

            MesDatas.DsGlobal.Tables.Add(bilan);

            string captureTout = @"SELECT
                              es.nom,
                              o.objectif,
                              c.nombre
                          FROM ObjectifCapture o

                          LEFT JOIN Capturer c
                              ON o.nomPlanete = c.nomPlanete
                              AND o.numeroMission = c.numeroMission
                              AND o.idEspeceEnnemi = c.idEspeceEnnemi

                          JOIN Espece es
                              ON o.idEspeceEnnemi = es.id

                          WHERE o.nomPlanete = @planete
                              AND o.numeroMission = @numero;";

            SQLiteDataAdapter da6 = new SQLiteDataAdapter(captureTout, Connexion.Connec);
            da6.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da6.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt6 = new DataTable();
            da6.Fill(dt6);


            foreach (DataRow dr in dt6.Rows)
            {
                DataRow ligne = bilan.NewRow();

                ligne["NomEspece"] = dr["nom"];
                ligne["ObjectifInitial"] = dr["objectif"];
                ligne["NbCaptures"] = dr["nombre"];

                int objectif = Convert.ToInt32(dr["objectif"]);

                object resultat = dr["nombre"];
                int captures = 0;
                if (resultat != DBNull.Value && resultat != null)
                {
                    captures = Convert.ToInt32(dr["nombre"]);
                }

                taux = 0;

                if (objectif > 0)
                    taux = (double)captures * 100.0 / objectif;

                ligne["TauxReussite"] = taux;

                bilan.Rows.Add(ligne);

            }
            afficherBilan(bilan);
        }

        private void afficherBilan(DataTable bilan)
        {
            FlpCaptures.Controls.Clear();
            foreach(DataRow dr in bilan.Rows)
            {
                AfficherCaptureAlien capture = new AfficherCaptureAlien();

                capture.chargerDonnees(dr);

                FlpCaptures.Controls.Add(capture);
            }
        }

        private void AfficherEvenement()
        {
            if (bsEvenements.Count > 0)
            {
                DataRowView row = (DataRowView)bsEvenements.Current;

                LblEvenement.Text = row["commentaires"].ToString();
                LblDate.Text = row["dateJ"].ToString();
                LblNav.Text = " / " + bsEvenements.Count;
                TxtNumeroEvenement.Text =(bsEvenements.Position + 1).ToString();
            }
            else
            {
                LblEvenement.Text = "Aucun événement enregistré.";
                LblDate.Text = string.Empty;
                MessageBox.Show("Aucun événement trouvé pour cette planète et ce numéro de mission.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAllerPremier_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveFirst();

            AfficherEvenement();
        }

        private void BtnReculer1_Click(object sender, EventArgs e)
        {
            bsEvenements.MovePrevious();

            AfficherEvenement();
        }

        private void BtnAvancer1_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveNext();

            AfficherEvenement();
        }

        private void BtnAllerDernier_Click(object sender, EventArgs e)
        {
            bsEvenements.MoveLast();

            AfficherEvenement();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtNumeroEvenement.Text, out int numero))
            {
                if (numero >= 1 && numero <= bsEvenements.Count)
                {
                    bsEvenements.Position = numero - 1;

                    AfficherEvenement();
                }
            }
        }

        private void TxtNumeroEvenement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void BtnEditerPdf_Click(object sender, EventArgs e)
        {
            string sql1 = @"SELECT mi.dateDepart, mi.dateRetour, mi.feuilleDeRoute, mi.budget, me.nom, me.prenom
                            FROM Mission mi
                            JOIN Composer co ON co.nomPlanete = mi.nomPlanete AND co.numeroMission = mi.numero
                            JOIN Membre me ON me.matricule = co.matriculeMembre
                            WHERE mi.nomPlanete = @planete AND mi.numero = @numero;";

            SQLiteDataAdapter da1 = new SQLiteDataAdapter(sql1, Connexion.Connec);
            da1.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da1.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dtMission = new DataTable();
            da1.Fill(dtMission);

            string chefMission = @"SELECT  m.grade || ' ' || me.nom || ' ' || me.prenom AS Chef
                                  FROM Mission mi
                                  JOIN Membre me ON mi.matriculeChef = me.matricule
								  JOIN Militaire m ON me.matricule = m.matriculeMembre
                                  WHERE mi.nomPlanete = @planete AND mi.numero = @numero;";

            SQLiteDataAdapter da2 = new SQLiteDataAdapter(chefMission, Connexion.Connec);
            da2.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da2.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dtChef = new DataTable();
            da2.Fill(dtChef);

            string journalDeBord = @"SELECT dateJ, commentaires
                            FROM JournalDeBord
                            WHERE nomplanete = @planete AND numero = @numero;";

            SQLiteDataAdapter da3 = new SQLiteDataAdapter(journalDeBord, Connexion.Connec);
            da3.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da3.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dtJournal = new DataTable();
            da3.Fill(dtJournal);

            string depenses = @"SELECT d.dateD, d.motif, d.montant, t.libelle
                                FROM Depense d
                                JOIN TypeDepense t ON d.idTypeDepense = t.id
                                WHERE d.nomPlanete = @planete AND d.numeroMission = @numero;";

            SQLiteDataAdapter da4 = new SQLiteDataAdapter(depenses, Connexion.Connec);
            da4.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da4.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dtDepense = new DataTable();
            da4.Fill(dtDepense);


            string contacts = @"SELECT i.nom , c.dateC, c.sommeVersee, c.appreciation, e.nom as race
                                FROM Contact c 
                                JOIN Informateur i ON i.nomCode = c.nomCodeInformateur
								JOIN Espece e ON i.idEspeceEnnemi = e.id
                                WHERE c.nomPlanete = @planete AND c.numeroMission = @numero;";

            SQLiteDataAdapter da5 = new SQLiteDataAdapter(contacts, Connexion.Connec);
            da5.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da5.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dtContact = new DataTable();
            da5.Fill(dtContact);


            string captureTout = @"SELECT
                              es.nom,
                              o.objectif,
                              c.nombre
                          FROM ObjectifCapture o

                          LEFT JOIN Capturer c
                              ON o.nomPlanete = c.nomPlanete
                              AND o.numeroMission = c.numeroMission
                              AND o.idEspeceEnnemi = c.idEspeceEnnemi

                          JOIN Espece es
                              ON o.idEspeceEnnemi = es.id

                          WHERE o.nomPlanete = @planete
                              AND o.numeroMission = @numero;";

            SQLiteDataAdapter da6 = new SQLiteDataAdapter(captureTout, Connexion.Connec);
            da6.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da6.SelectCommand.Parameters.AddWithValue("@numero", numeroMission);

            DataTable dt6 = new DataTable();
            da6.Fill(dt6);


            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Fichier PDF (*.pdf)|*.pdf";
            save.FileName = "RapportMission.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string chemin = save.FileName;



                Document doc = new Document();

                PdfWriter.GetInstance(doc, new FileStream(chemin, FileMode.Create));

                doc.Open();

                doc.Add(new Paragraph("Rapport de mission"));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Planète : " + nomPlanete));
                doc.Add(new Paragraph("Mission : " + numeroMission));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Départ le : " + dtMission.Rows[0]["dateDepart"]));
                doc.Add(new Paragraph("Fin de la mission : " + dtMission.Rows[0]["dateRetour"]));
                doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Sous la responsbilité du " + dtChef.Rows[0]["Chef"]));
                doc.Add(new Paragraph("Budget initial : " + dtMission.Rows[0]["budget"] + " €"));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Feuille de route : " + dtMission.Rows[0]["feuilleDeRoute"]));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("--------------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("Liste des membres : "));
                doc.Add(new Paragraph(" "));
                foreach (DataRow row in dtMission.Rows)
                {
                    doc.Add(new Paragraph("--> " + row["nom"] + " " + row["prenom"]));
                }
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Journal de bord : "));
                foreach (DataRow row in dtJournal.Rows)
                {
                    doc.Add(new Paragraph("Le " + row["dateJ"] + " " + row["Commentaires"]));
                }
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Dépenses effectuées : "));
                List liste = new List(List.ORDERED);
                foreach (DataRow row in dtDepense.Rows)
                {
                    liste.Add(new ListItem("Le " + row["dateD"] + " (" + row["libelle"] + ") " + row["motif"] + " " + row["montant"] + " €."));
                }
                doc.Add(liste);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Contacts effectués avec les informateurs : "));
                foreach (DataRow row in dtContact.Rows)
                {
                    doc.Add(new Paragraph("Le " + row["dateC"] + " : rencontre avec " + row["nom"] + " (Race des " + row["race"] + ") " + row["sommeVersee"] + " € (" + row["appreciation"] + ")."));
                }
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Tableau récapitulatif des captures (en %) : "));
                doc.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(4);
                table.AddCell("nom de l'espèce"); 
                table.AddCell("objectif de capture");
                table.AddCell("nombre de capture");
                table.AddCell("taux de réussite de capture");
                foreach (DataRow row in dt6.Rows)
                {
                    table.AddCell(row["nom"].ToString());
                    table.AddCell(row["objectif"].ToString());
                    table.AddCell(row["nombre"].ToString());
                    table.AddCell(taux.ToString());
                }
                doc.Add(table);

                doc.Close();

                MessageBox.Show("PDF généré !");
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
