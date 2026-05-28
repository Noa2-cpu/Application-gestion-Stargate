using appliPandora;
using RepertoirRaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SAE24
{
    public partial class RepertoireRaces : Form
    {
        private SQLiteDataAdapter da;
        private DataTable dt;
        private DataSet ds;
        public RepertoireRaces()
        {
            InitializeComponent();
        }

        private void RepertoireRaces_Load(object sender, EventArgs e)
        {
            string sql = @" SELECT
                                E.id,
                                E.nom,
                                E.couleur,

                                CASE
                                    WHEN A.idEspece IS NOT NULL THEN 'Alliée'
                                    WHEN EN.idEspece IS NOT NULL THEN 'Ennemie'
                                    ELSE 'Inconnue'
                                END AS TypeEspece,

                                A.degreBienveillance,
                                A.instrumentMusique,
                                A.datePremierContact,

                                EN.typeArme,
                                EN.degreAgressivite,

                                IFNULL(GROUP_CONCAT(H.nomPlanete, '/'), 'Origine inconnue') AS Origine
                            
                            FROM
                                Espece E
                            LEFT JOIN
                                Allie A ON E.id = A.idEspece
                            LEFT JOIN
                                Ennemi EN ON E.id = EN.idEspece
                            LEFT JOIN
                                Habiter H ON E.id = H.idEspece
                            GROUP BY
                                E.id, E.nom, E.couleur, TypeEspece, A.degreBienveillance, A.instrumentMusique, A.datePremierContact, EN.typeArme, EN.degreAgressivite";
            da = new SQLiteDataAdapter(sql, Connexion.Connec);
            dt = new DataTable();
            da.Fill(dt);

            afficherEspeces(dt);
            chargerCouleursDansCmb(dt);
        }
        private void rechercheFiltre(DataTable tableDeRecherche)
        {
            List<string> conditions = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtRecherche.Text))
            {
                conditions.Add($"nom LIKE '%{txtRecherche.Text}%'");
            }

            if (cmbCouleurs.SelectedIndex > 0)
            {
                conditions.Add($"couleur = '{cmbCouleurs.Text}'");
            }

            if (cbAlliees.Checked && !cbEnnemies.Checked)
            {
                conditions.Add("TypeEspece = 'Alliée'");
            }
            else if (cbEnnemies.Checked && !cbAlliees.Checked)
            {
                conditions.Add("TypeEspece = 'Ennemie'");
            }
            string filtreFinal = string.Join(" AND ", conditions);

            tableDeRecherche.DefaultView.RowFilter = filtreFinal;

            afficherEspeces(tableDeRecherche.DefaultView.ToTable());
        }
        private void afficherEspeces(DataTable tableEspeces)
        {

            int bordGauche = 20;
            int bordHaut = 20;

            pnlRepertoir.Controls.Clear();

            foreach (DataRow dr in tableEspeces.Rows)
            {
                CaracteristiquesRaces ucPageInfo = new CaracteristiquesRaces();
                ucPageInfo.chargerDonnees(dr);

                if (bordGauche + ucPageInfo.Width > pnlRepertoir.Width)
                {
                    bordGauche = 20;
                    bordHaut += ucPageInfo.Height + 20;
                }

                ucPageInfo.Top = bordHaut;
                ucPageInfo.Left = bordGauche;

                pnlRepertoir.Controls.Add(ucPageInfo);

                bordGauche += ucPageInfo.Width + 30;
            }
        }
        private void chargerCouleursDansCmb(DataTable tableEspeces)
        {
            cmbCouleurs.Items.Clear();

            cmbCouleurs.Items.Add("Toutes");

            DataView vue = new DataView(tableEspeces);
            DataTable couleursUniques = vue.ToTable(true, "couleur");

            foreach (DataRow ligne in couleursUniques.Rows)
            {
                if (ligne["couleur"] != DBNull.Value && !string.IsNullOrWhiteSpace(ligne["couleur"].ToString()))
                {
                    cmbCouleurs.Items.Add(ligne["couleur"].ToString());
                }
            }

            cmbCouleurs.SelectedIndex = 0;
        }

        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            rechercheFiltre(dt);
        }

        private void cmbCouleurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercheFiltre(dt);
        }

        private void cbAlliees_CheckedChanged(object sender, EventArgs e)
        {
            rechercheFiltre(dt);
        }

        private void cbEnnemies_CheckedChanged(object sender, EventArgs e)
        {
            rechercheFiltre(dt);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRecherche.Clear();
            cmbCouleurs.SelectedIndex = 0;
            cbAlliees.Checked = false;
            cbEnnemies.Checked = false;
        }
    }
}
