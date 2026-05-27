using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SAE24
{
    public partial class DetailMissions : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
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

        private void AppliquerPolice(Control parent, Font font)
        {
            foreach (Control c in parent.Controls)
            {
                c.Font = font;

                if (c.Controls.Count > 0)
                {
                    AppliquerPolice(c, font);
                }
            }
        }

        private void DetailMissions_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile("Orbitron-Regular.ttf");

            Font maPolice = new Font(pfc.Families[0], 10f);

            AppliquerPolice(this, maPolice);
        
            PcbJournal.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbJournal.SizeMode = PictureBoxSizeMode.Zoom;
            PcbJournal.Image = Image.FromFile(@"..\..\img\Journal.png");


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

                    militaireCivil.AutoSize = true;
                    
                    flowLayoutPanel1.Controls.Add(militaireCivil);
                }
                else
                {
                    string nomC = dr["nom"].ToString();
                    string prenomC = dr["prenom"].ToString();
                    string imgAstroC = @"..\..\img\Civil.png";

                    MilitaireCivil militaireCivil = new MilitaireCivil(nomC, prenomC, imgAstroC);
                    // Initialiser l'affichage du UserControl (remplit labels et image)
                    militaireCivil.chargerInterface();

                    militaireCivil.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(militaireCivil);
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


            PcbContact.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbContact.SizeMode = PictureBoxSizeMode.Zoom;
            PcbContact.Image = Image.FromFile(@"..\..\img\contact.png");

            PcbDepense.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbDepense.SizeMode = PictureBoxSizeMode.Zoom;
            PcbDepense.Image = Image.FromFile(@"..\..\img\depense.png");

            PcbEvenement.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbEvenement.SizeMode = PictureBoxSizeMode.Zoom;
            PcbEvenement.Image = Image.FromFile(@"..\..\img\evenement.jpg");


            string chargerInformateur = @"SELECT DISTINCT i.nom AS nom, i.nomCode as nomCode
                                          FROM Informateur i 
                                          JOIN Contact c ON i.nomCode = c.nomCodeInformateur
                                          WHERE nomPlanete = @planete AND numeroMission = @numero;";

            SQLiteDataAdapter da4 = new SQLiteDataAdapter(chargerInformateur, Connexion.Connec);
            da4.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da4.SelectCommand.Parameters.AddWithValue("@numero", numero);

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            foreach (DataRow dr in dt4.Rows)
            {
                CboInformateur.DataSource = dt4;
                CboInformateur.DisplayMember = "nom";
                CboInformateur.ValueMember = "nomCode";
            }

            string chargerTypesDepenses = @"SELECT libelle, id FROM TypeDepense;";

            SQLiteDataAdapter da5 = new SQLiteDataAdapter(chargerTypesDepenses, Connexion.Connec);
            da5.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
            da5.SelectCommand.Parameters.AddWithValue("@numero", numero);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            foreach (DataRow dr in dt5.Rows)
            {
                CboMotif.DataSource = dt5;
                CboMotif.DisplayMember = "libelle";
                CboMotif.ValueMember = "id";
            }
        }

        private void RtbFeuilleRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PcbJournal_Click(object sender, EventArgs e)
        {
            Form nomForm = new Form();
            nomForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PcbContact_Click(object sender, EventArgs e)
        {
            Afficher("contact");
        }

        private void PcbDepense_Click(object sender, EventArgs e)
        {
            Afficher("depense");
        }

        private void PcbEvenement_Click(object sender, EventArgs e)
        {
            Afficher("evenement");
        }
        private void Afficher(string choix)
        {
            GrpEvenement.Visible = false;
            GrpDepense.Visible = false;
            GrpContact.Visible = false;

            if (choix == "contact")
                GrpContact.Visible = true;

            if (choix == "depense")
                GrpDepense.Visible = true;

            if (choix == "evenement")
                GrpEvenement.Visible = true;
        }

        private void TxtSomme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                RtbAppreciation.Focus();
            }
        }

        private void BtnValiderContact_Click(object sender, EventArgs e)
        {
            bool valide = true;

            if(TxtSomme.Text == "")
            {
                errorProvider1.SetError(TxtSomme, "Veuillez entrer la somme d'argent que vous avez donné à l'alien.");
                valide = false;
            }

            if(RtbAppreciation.Text == "")
            {
                errorProvider1.SetError(RtbAppreciation, "Veuillez dire pourquoi vous l'avez fait.");
                valide = false;
            }

            if(DtpContact.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(DtpContact, "La date du contact ne peut pas être dans le futur.");
                valide = false;
            }

            string sql = "SELECT * FROM Contact WHERE nomPlanete = @planete AND numeroMission = @numMission;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);
            try
            {
                da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@numMission", numero);
                da.Fill(MesDatas.DsGlobal, "Contact");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            //On pose les contraintes pour le dataset, si les contraintes sont respectées alors on peut ajouter la dépense
            try 
            { 
                DataColumn pkContact1 = MesDatas.DsGlobal.Tables["Contact"].Columns["nomPlanete"];
                DataColumn pkContact2 = MesDatas.DsGlobal.Tables["Contact"].Columns["numeroMission"];
                DataColumn pkContact3 = MesDatas.DsGlobal.Tables["Contact"].Columns["dateC"];
                MesDatas.DsGlobal.Tables["Contact"].PrimaryKey = new DataColumn[] { pkContact1, pkContact2, pkContact3 };
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            //On ajoute la ligne dans le dataset
            if (valide)
            {
                DataRow ligne;
                ligne = MesDatas.DsGlobal.Tables["Contact"].NewRow();
                ligne[0] = LblTitre.Text.Split(' ')[1];
                ligne[1] = Convert.ToInt64(LblTitre.Text.Split(' ')[2]);
                ligne[2] = DtpContact.Value.ToString("yyyy-MM-dd");
                ligne[3] = TxtSomme.Text.ToString();
                ligne[4] = RtbAppreciation.Text.ToString();
                ligne[5] = CboInformateur.SelectedValue.ToString();

                try
                {
                    MesDatas.DsGlobal.Tables["Contact"].Rows.Add(ligne);

                    MessageBox.Show("Contact ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtSomme.Clear();
                    RtbAppreciation.Clear();
                    DtpContact.Value = DateTime.Now;

                    SQLiteCommandBuilder cb = new SQLiteCommandBuilder(da);
                    da.Update(MesDatas.DsGlobal, "Contact");
                }
                catch (SQLiteException err) 
                { 
                    MessageBox.Show(err.Message);
                }
                catch (ConstraintException err)
                {
                    MessageBox.Show("Attention, vous ne pouvez contacter un alien qu'une seule fois par jour.\n(" + err + ").", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAnnulerContact_Click(object sender, EventArgs e)
        {
            TxtSomme.Clear();
            RtbAppreciation.Clear();
            DtpContact.Value = DateTime.Now;
        }

        private void TxtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                RtbAppreciation.Focus();
            }
        }

        private void BtnValiderDepense_Click(object sender, EventArgs e)
        {
            bool valide = true;

            if(TxtMontant.Text == "")
            {
                errorProvider1.SetError(TxtMontant, "Veuillez entrer un montant pour la dépense.");
                valide = false;
            }

            if (RtbExplication.Text == "")
            {
                errorProvider1.SetError(RtbExplication, "Veuillez entrer une description pour votre dépense.");
                valide = false;
            }

            if (DtpDepense.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(DtpDepense, "La date de la dépense ne peut pas être dans le futur.");
                valide = false;
            }

            string sql = "SELECT * FROM Depense WHERE nomPlanete = @planete AND numeroMission = @numMission;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);
            try
            {
                da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@numMission", numero);
                da.Fill(MesDatas.DsGlobal, "Depense");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            try
            {
                DataColumn pkDepense1 = MesDatas.DsGlobal.Tables["Depense"].Columns["nomPlanete"];
                DataColumn pkDepense2 = MesDatas.DsGlobal.Tables["Depense"].Columns["numeroMission"];
                DataColumn pkDepense3 = MesDatas.DsGlobal.Tables["Depense"].Columns["id"];
                MesDatas.DsGlobal.Tables["Depense"].PrimaryKey = new DataColumn[] { pkDepense1, pkDepense2, pkDepense3 };
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            //On cherche le numéro d'id de la dépense pour pouvoir l'ajouter dans la base de données
            DataTable dt = new DataTable();
            da.Fill(dt);
            int compteur = 1;
            foreach(DataRow dr in dt.Rows)
            {
                compteur++;
            }

            if (valide)
            {
                DataRow ligne;
                ligne = MesDatas.DsGlobal.Tables["Depense"].NewRow();
                ligne[0] = LblTitre.Text.Split(' ')[1];
                ligne[1] = Convert.ToInt64(LblTitre.Text.Split(' ')[2]);
                ligne[2] = compteur;
                ligne[3] = DtpDepense.Value.ToString("yyyy-MM-dd");
                ligne[4] = TxtMontant.Text.ToString();
                ligne[5] = RtbExplication.Text.ToString();
                ligne[6] = CboMotif.SelectedValue.ToString();

                try
                {
                    MesDatas.DsGlobal.Tables["Depense"].Rows.Add(ligne);

                    MessageBox.Show("Dépense ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtMontant.Clear();
                    RtbExplication.Clear();
                    DtpDepense.Value = DateTime.Now;

                    SQLiteCommandBuilder cb = new SQLiteCommandBuilder(da);
                    da.Update(MesDatas.DsGlobal, "Depense");
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void BtnValiderEvenement_Click(object sender, EventArgs e)
        {
            bool valide = true;

            if (RtbCommentaire.Text == "")
            {
                errorProvider1.SetError(RtbCommentaire, "Veuillez entrer l'évènement que vous souhaitez ajouter.");
                valide = false;
            }

            if (DtpEvenement.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(DtpEvenement, "La date de l'évènement ne peut pas être dans le futur.");
                valide = false;
            }

            string sql = "SELECT * FROM JournalDeBord WHERE nomPlanete = @planete AND numero = @numMission;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);
            try
            {
                da.SelectCommand.Parameters.AddWithValue("@planete", nomPlanete);
                da.SelectCommand.Parameters.AddWithValue("@numMission", numero);
                da.Fill(MesDatas.DsGlobal, "JournalDeBord");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            try
            {
                DataColumn pkDepense1 = MesDatas.DsGlobal.Tables["JournalDeBord"].Columns["nomPlanete"];
                DataColumn pkDepense2 = MesDatas.DsGlobal.Tables["JournalDeBord"].Columns["numero"];
                DataColumn pkDepense3 = MesDatas.DsGlobal.Tables["JournalDeBord"].Columns["dateJ"];
                MesDatas.DsGlobal.Tables["JournalDeBord"].PrimaryKey = new DataColumn[] { pkDepense1, pkDepense2, pkDepense3 };
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            //On cherche le numéro d'id de la dépense pour pouvoir l'ajouter dans la base de données
            DataTable dt = new DataTable();
            da.Fill(dt);
            int compteur = 1;
            foreach (DataRow dr in dt.Rows)
            {
                compteur++;
            }

            if (valide)
            {
                DataRow ligne;
                ligne = MesDatas.DsGlobal.Tables["JournalDeBord"].NewRow();
                ligne[0] = LblTitre.Text.Split(' ')[1];
                ligne[1] = Convert.ToInt64(LblTitre.Text.Split(' ')[2]);              
                ligne[2] = DtpDepense.Value.ToString("yyyy-MM-dd");
                ligne[3] = RtbExplication.Text.ToString();

                try
                {
                    MesDatas.DsGlobal.Tables["JournalDeBord"].Rows.Add(ligne);

                    MessageBox.Show("évenement ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RtbCommentaire.Clear();
                    DtpEvenement.Value = DateTime.Now;

                    SQLiteCommandBuilder cb = new SQLiteCommandBuilder(da);
                    da.Update(MesDatas.DsGlobal, "JournalDeBord");
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
