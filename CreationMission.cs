using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Linq;
using System.Data.SqlClient;

namespace SAE24
{
    public partial class CreationMission : Form
    {

        public CreationMission()
        {
            InitializeComponent();
        }

        // Table contenant les membres disponibles (source liée à la ComboBox)
        private DataTable dtMembres;

        //Table contenant les aliens disponibles (source liée à la ComboBox)
        private DataTable dtAliens;

        // Liste des matricules sélectionnés
        private List<string> selectedMatricules = new List<string>();

        //Liste des aliens sélectionnés
        private List<string> selectedAliens = new List<string>();

        private int currentNumeroMission;

        private void CreationMission_Load(object sender, EventArgs e)
        {
            //remplir la combobox avec les planètes
            string remplirCombo1 = "SELECT nom FROM Planete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCombo1, Connexion.Connec);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CboChoisirPlanete.Items.Add(dr.GetString(0));
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }


            //remplir la combobox du chef de mission
            string remplirMilitaires1 = @"SELECT m.nom || ' ' || m.prenom || ' - ' || mi.grade AS nomcomplet, m.matricule as matricule
                                             FROM Membre m
                                             JOIN Militaire mi ON m.matricule = mi.matriculeMembre
                                             WHERE m.matricule NOT IN (SELECT co.matriculeMembre
						                                               FROM Composer co
						                                               JOIN Mission mi ON co.numeroMission = mi.numero
						                                               WHERE @dateDepart <= mi.dateRetour
						                                               AND @dateRetour >= mi.dateDepart);";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirMilitaires1, Connexion.Connec);

                cmd.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                CboChefMission.DataSource = dt;
                CboChefMission.DisplayMember = "nomcomplet";
                CboChefMission.ValueMember = "matricule";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            //remplir la combobox pour choisir les membres de la mission en deux temps : d'abord avec les civils puis avec les militaires.
            string remplirCivils = @"SELECT m.nom || ' ' || m.prenom || ' - Civil : ' || c.Specialite AS nomcomplet, m.matricule AS matricule
                                         FROM Membre m
                                         JOIN Civil c ON m.matricule = c.matriculeMembre
                                         WHERE m.matricule NOT IN (SELECT co.matriculeMembre
						                                           FROM Composer co
						                                           JOIN Mission mi ON  co.numeroMission = mi.numero
						                                           WHERE @dateDepart <= mi.dateRetour
						                                           AND @dateRetour >= mi.dateDepart);";

            string remplirMilitaires = @"SELECT m.nom || ' ' || m.prenom || ' - Militaire : ' || mi.grade AS nomcomplet, m.matricule as matricule
                                             FROM Membre m
                                             JOIN Militaire mi ON m.matricule = mi.matriculeMembre
                                             WHERE m.matricule NOT IN (SELECT co.matriculeMembre
						                                               FROM Composer co
						                                               JOIN Mission mi ON co.numeroMission = mi.numero
						                                               WHERE @dateDepart <= mi.dateRetour
						                                               AND @dateRetour >= mi.dateDepart);";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCivils, Connexion.Connec);
                SQLiteCommand cmd2 = new SQLiteCommand(remplirMilitaires, Connexion.Connec);

                cmd.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@dateDepart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@dateRetour", DtpRetour.Value.ToString("yyyy-MM-dd"));

                dtMembres = new DataTable();

                dtMembres.Load(cmd.ExecuteReader());
                dtMembres.Load(cmd2.ExecuteReader());

                CboChoisirMembre.DataSource = dtMembres;
                CboChoisirMembre.DisplayMember = "nomcomplet";
                CboChoisirMembre.ValueMember = "matricule";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }



        }

        private void BtnPlanete_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAX(numero) FROM Mission WHERE nomPlanete = @planete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                cmd.Parameters.AddWithValue("@planete", CboChoisirPlanete.SelectedItem);

                int numeroMission = 0;

                object resultat = cmd.ExecuteScalar();

                if (resultat != DBNull.Value && resultat != null)
                {
                    numeroMission = Convert.ToInt32(resultat);
                }

                numeroMission++;

                if (CboChoisirPlanete.SelectedItem == null)
                {
                    errorProvider1.SetError(CboChoisirPlanete, "Veuillez choir une planète où aller");
                    CboChoisirPlanete.Focus();
                }
                else
                {
                    LblAfficherPlanete.Text = "Nom de la mission : " + CboChoisirPlanete.SelectedItem.ToString() + " - " + numeroMission.ToString();

                    //remplir la combobox des aliens
                    string remplirAliens = @"SELECT es.nom || ' - ' || es.couleur AS nomcomplet, e.idEspece AS ID
                                     FROM Ennemi e
                                     JOIN Espece es ON e.idEspece = es.id
                                     JOIN Habiter h ON es.id = h.idEspece
                                     WHERE h.nomPlanete = @planete;";

                    try
                    {
                        SQLiteCommand cmd2 = new SQLiteCommand(remplirAliens, Connexion.Connec);

                        cmd2.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);

                        dtAliens = new DataTable();

                        dtAliens.Load(cmd2.ExecuteReader());
                        if (dtAliens == null || dtAliens.Rows.Count == 0)
                        {
                            CboAliens.DataSource = null;
                            CboAliens.Items.Clear();
                            CboAliens.Enabled = false;
                            BtnAjouterAliens.Enabled = false;
                            TxtNombreCapture.Enabled = false;
                            LstAfficherAliens.Enabled = false;
                            BtnValiderObjectifs.Enabled = false;

                            MessageBox.Show("Il n'y a aucun alien pour cette planète.");
                        }
                        else
                        {
                            CboAliens.DataSource = dtAliens;
                            CboAliens.DisplayMember = "nomcomplet";
                            CboAliens.ValueMember = "ID";
                            CboAliens.Enabled = true;
                            BtnAjouterAliens.Enabled = true;
                        }
                    }
                    catch (SQLiteException err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    errorProvider1.Clear();
                    label1.Enabled = false;
                    CboChoisirPlanete.Enabled = false;
                    BtnPlanete.Enabled = false;
                    LblAfficherPlanete.Enabled = false;
                    BtnValider.Enabled = true;
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TxtNbPersonne_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                TxtObjDatabaz.Focus();
            }
        }

        private void TxtObjDatabaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                TxtBudget.Focus();
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            bool valide = true;

            errorProvider1.Clear();

            // Chef de mission
            if (CboChefMission.SelectedItem == null)
            {
                errorProvider1.SetError(CboChefMission, "Veuillez choisir un chef de mission.");

                valide = false;
            }

            // Dates
            if (DtpDepart.Value.Date >= DtpRetour.Value.Date)
            {
                errorProvider1.SetError(DtpRetour, "La date de retour doit être différente de celle du départ.");

                valide = false;
            }

            if (string.IsNullOrWhiteSpace(RtbFeuilleRoute.Text))
            {
                errorProvider1.SetError(RtbFeuilleRoute, "Veuillez saisir quelques informations pour la feuille de route..");

                valide = false;
            }

            // Nombre de personnes
            if (string.IsNullOrWhiteSpace(TxtNbPersonne.Text))
            {
                errorProvider1.SetError(TxtNbPersonne, "Veuillez saisir le nombre de personnes.");

                valide = false;
            }

            // Quantité de Databaz
            if (string.IsNullOrWhiteSpace(TxtObjDatabaz.Text))
            {
                errorProvider1.SetError(TxtObjDatabaz, "Veuillez saisir la quantité de Databaz.");

                valide = false;
            }

            // Budget
            if (string.IsNullOrWhiteSpace(TxtBudget.Text))
            {
                errorProvider1.SetError(TxtBudget, "Veuillez saisir le budget de la mission.");

                valide = false;
            }

            if (valide)
            {
                string sql = "SELECT MAX(numero) FROM Mission WHERE nomPlanete = @planete";

                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                    cmd.Parameters.AddWithValue("@planete", CboChoisirPlanete.SelectedItem);

                    int numeroMission = 0;

                    object resultat = cmd.ExecuteScalar();

                    if (resultat != DBNull.Value && resultat != null)
                    {
                        numeroMission = Convert.ToInt32(resultat);
                    }

                    numeroMission++;
                    currentNumeroMission = numeroMission;

                    string ajouterMission = @"
                    INSERT INTO Mission 
                    (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget)
                    VALUES
                    (@planete, @numero, @nb, @depart, @retour, @chef, @feuille, @databaz, @budget);
                    ";

                    SQLiteCommand cmd2 = new SQLiteCommand(ajouterMission, Connexion.Connec);

                    cmd2.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                    cmd2.Parameters.AddWithValue("@numero", numeroMission.ToString());
                    cmd2.Parameters.AddWithValue("@nb", TxtNbPersonne.Text);
                    cmd2.Parameters.AddWithValue("@depart", DtpDepart.Value.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("@retour", DtpRetour.Value.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("@chef", CboChefMission.SelectedValue.ToString());
                    cmd2.Parameters.AddWithValue("@feuille", RtbFeuilleRoute.Text);
                    cmd2.Parameters.AddWithValue("@databaz", TxtObjDatabaz.Text);
                    cmd2.Parameters.AddWithValue("@budget", TxtBudget.Text);

                    cmd2.ExecuteNonQuery();

                    // Ajouter le chef dans la liste affichée si pas déjà présent
                    var chefMatricule = CboChefMission.SelectedValue?.ToString();
                    var chefAffichage = CboChefMission.Text;

                    if (!string.IsNullOrEmpty(chefMatricule))
                    {
                        // Eviter doublon dans la liste de matricules
                        if (!selectedMatricules.Contains(chefMatricule))
                        {
                            selectedMatricules.Add(chefMatricule);
                        }

                        // Retirer le chef de la source des membres disponibles pour empêcher de le ré-ajouter
                        if (dtMembres != null)
                        {
                            // trouver la ligne avec ce matricule
                            DataRow[] found = dtMembres.Select("matricule = '" + chefMatricule.Replace("'","''") + "'");
                            foreach (var enlever in found)
                            {
                                dtMembres.Rows.Remove(enlever);
                            }
                        }
                    }

                    // Ajouter l'affichage si nécessaire
                    if (!LstAfficherMembre.Items.Contains(chefAffichage))
                    {
                        LstAfficherMembre.Items.Add(chefAffichage);
                    }

                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;

                    // Mettre à jour le nombre restant en tenant compte du chef déjà ajouté
                    int nbTotal;
                    if (int.TryParse(TxtNbPersonne.Text, out nbTotal))
                    {
                        int restant = nbTotal - LstAfficherMembre.Items.Count;
                        LblNbPersonnes.Text = restant.ToString();
                    }
                    else
                    {
                        LblNbPersonnes.Text = TxtNbPersonne.Text;
                    }
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void TxtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                BtnValider_Click(sender, e);
            }
        }

        private void RtbFeuilleRoute_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnAjouterMembre_Click(object sender, EventArgs e)
        {
            string membre = CboChoisirMembre.GetItemText(CboChoisirMembre.SelectedItem);

            errorProvider1.Clear();

            if (!LstAfficherMembre.Items.Contains(membre))
            {
                LstAfficherMembre.Items.Add(membre);

                // Récupérer le matricule depuis l'élément sélectionné
                string matricule = CboChoisirMembre.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(matricule))
                {
                    selectedMatricules.Add(matricule);
                }

                // Supprimer la ligne correspondante du DataTable lié pour mettre à jour la ComboBox
                if (dtMembres != null && CboChoisirMembre.SelectedItem is DataRowView drv)
                {
                    dtMembres.Rows.Remove(drv.Row);
                }

                int nbMaximum;

                if (int.TryParse(TxtNbPersonne.Text, out nbMaximum))
                {
                    int nbActuel = LstAfficherMembre.Items.Count;

                    int restant = nbMaximum - nbActuel;

                    LblNbPersonnes.Text = "" + restant;

                    if (restant <= 0)
                    {
                        CboChoisirMembre.Enabled = false;
                        BtnAjouterMembre.Enabled = false;
                        BtnValiderMembre.Enabled = true;
                    }
                    else
                    {
                        CboChoisirMembre.Enabled = true;
                        BtnAjouterMembre.Enabled = true;
                        BtnValiderMembre.Enabled = false;
                    }
                }
                else
                {
                    LblNbPersonnes.Text = "Veuillez saisir un nombre valide.";
                }
            }
            else
            {
                errorProvider1.SetError(LstAfficherMembre, "Le membre est déjà sélectionné.");
            }
        }

        private void BtnValiderMembre_Click(object sender, EventArgs e)
        {
            CboChoisirMembre.Enabled = false;
            BtnAjouterMembre.Enabled = false;
            LstAfficherMembre.Enabled = false;
            BtnValiderMembre.Enabled = false;
        }

        private void TxtNombreCapture_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                BtnAjouterAliens_Click(sender, e);
            }
        }

        private void BtnAjouterAliens_Click(object sender, EventArgs e)
        {
            string alien = CboAliens.GetItemText(CboAliens.SelectedItem);

            errorProvider1.Clear();

            // Vérifier que l'espèce n'a pas déjà été ajoutée dans la liste des objectifs
            string quantite = TxtNombreCapture.Text;
            string affichage = alien + " --> Objectif de captures : " + quantite;

            if (LstAfficherAliens.Items.Contains(affichage))
            {
                errorProvider1.SetError(LstAfficherAliens, "Cette espèce d'alien est déjà sélectionnée.");
                return;
            }

            // Ajouter l'affichage
            LstAfficherAliens.Items.Add(affichage);

            // Récupérer l'ID de l'alien et le stocker
            string idAlien = CboAliens.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(idAlien))
            {
                selectedAliens.Add(idAlien);
            }

            // Supprimer la ligne correspondante du DataTable lié pour mettre à jour la ComboBox
            if (dtAliens != null && CboAliens.SelectedItem is DataRowView drv)
            {
                dtAliens.Rows.Remove(drv.Row);

                // Si plus d'aliens disponibles, désactiver les contrôles liés
                if (dtAliens.Rows.Count == 0)
                {
                    CboAliens.DataSource = null;
                    CboAliens.Items.Clear();
                    CboAliens.Enabled = false;
                    BtnAjouterAliens.Enabled = false;
                    TxtNombreCapture.Enabled = false;
                }
            }
        }

        private void BtnValiderObjectifs_Click(object sender, EventArgs e)
        {
            CboAliens.Enabled = false;
            TxtNombreCapture.Enabled = false;
            BtnAjouterAliens.Enabled = false;
            LstAfficherAliens.Enabled = false;
        }

        private void BtnFinirMission_Click(object sender, EventArgs e)
        {
            string ajouterMembreSQL = @"INSERT INTO Composer 
                                (nomPlanete, numeroMission, matriculeMembre)
                                VALUES
                                (@planete, @numero, @matricule)";

            string ajouterAliensSQL = @"INSERT INTO ObjectifCapture 
                                (nomPlanete, numeroMission, idEspeceEnnemi, objectif)
                                VALUES
                                (@planete, @numero, @idEspece, @objectif)";

            SQLiteTransaction transaction = null;
            try
            {
                transaction = Connexion.Connec.BeginTransaction();

                // Insérer chaque matricule sélectionné précédemment
                foreach (var matricule in selectedMatricules)
                {
                    SQLiteCommand cmdAjouterMembre = null;
                    try
                    {
                        cmdAjouterMembre = new SQLiteCommand(ajouterMembreSQL, Connexion.Connec, transaction);
                        cmdAjouterMembre.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                        cmdAjouterMembre.Parameters.AddWithValue("@numero", currentNumeroMission.ToString());
                        cmdAjouterMembre.Parameters.AddWithValue("@matricule", matricule);
                        cmdAjouterMembre.ExecuteNonQuery();
                    }
                    finally
                    {
                        if (cmdAjouterMembre != null)
                        {
                            cmdAjouterMembre.Dispose();
                        }
                    }
                }

                // Insérer les objectifs d'aliens
                foreach (var idEspece in selectedAliens)
                {
                    // Récupérer la quantité de capture pour cette espèce depuis la liste d'affichage
                    string quantite = "0";
                    foreach (var item in LstAfficherAliens.Items)
                    {
                        // on compare sur l'affichage stocké ; adapter si nécessaire
                        if (item.ToString().Contains(idEspece) || item.ToString().StartsWith(CboAliens.Text))
                        {
                            var parts = item.ToString().Split(new string[] { " --> Objectif de captures : " }, StringSplitOptions.None);
                            if (parts.Length > 1) quantite = parts[1];
                            break;
                        }
                    }

                    SQLiteCommand cmdAjouterAlien = null;
                    try
                    {
                        cmdAjouterAlien = new SQLiteCommand(ajouterAliensSQL, Connexion.Connec, transaction);
                        cmdAjouterAlien.Parameters.AddWithValue("@planete", CboChoisirPlanete.Text);
                        cmdAjouterAlien.Parameters.AddWithValue("@numero", currentNumeroMission.ToString());
                        cmdAjouterAlien.Parameters.AddWithValue("@idEspece", idEspece);
                        cmdAjouterAlien.Parameters.AddWithValue("@objectif", quantite);
                        cmdAjouterAlien.ExecuteNonQuery();
                    }
                    finally
                    {
                        if (cmdAjouterAlien != null)
                        {
                            cmdAjouterAlien.Dispose();
                        }
                    }
                }

                transaction.Commit();
                    MessageBox.Show("Mission finalisée et données insérées avec succès.");

                    // Demander à Form1 de se rafraîchir si présent
                    var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        try
                        {
                            mainForm.RefreshMissions();
                        }
                        catch { }
                    }

                    // Fermer ce formulaire pour revenir à l'application principale
                    this.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try 
                    { 
                        transaction.Rollback(); 
                    } 
                    catch 
                    { }
                }
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (transaction != null) transaction.Dispose();
            }
        }
    }
}
