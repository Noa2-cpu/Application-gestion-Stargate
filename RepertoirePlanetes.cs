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
    public partial class RepertoirePlanetes : Form
    {
        private SQLiteDataAdapter da;
        private DataTable dt;
        public RepertoirePlanetes()
        {
            InitializeComponent();
        }

        private void RepertoirePlanetes_Load(object sender, EventArgs e)
        {
            UIStyle.LoadFont("Orbitron-Regular.ttf");
            UIStyle.Apply(this);

            string sql = @" SELECT 
                                P.nom AS NomPlanete,
                                P.temperature,
                                P.gravite,
                                P.dataBazON,
    
                                (SELECT COUNT(numero) FROM Mission WHERE nomPlanete = P.nom) AS NombreMissions,
    
                                IFNULL((
                                    SELECT GROUP_CONCAT(
                                        E.nom || ' (' || 
                                        CASE 
                                            WHEN A.idEspece IS NOT NULL THEN 'Alliée'
                                            WHEN EN.idEspece IS NOT NULL THEN 'Ennemie'
                                            ELSE 'Inconnue'
                                        END || ' : ' || H.pourcentage || '%)',
                                        ' | '
                                    )
                                    FROM Habiter H
                                    INNER JOIN Espece E ON H.idEspece = E.id
                                    LEFT JOIN Allie A ON E.id = A.idEspece
                                    LEFT JOIN Ennemi EN ON E.id = EN.idEspece
                                    WHERE H.nomPlanete = P.nom
                                ), 'Aucune forme de vie recensée') AS RapportDeForce

                            FROM 
                                Planete P";

            da = new SQLiteDataAdapter(sql, Connexion.Connec);
            dt = new DataTable();
            da.Fill(dt);

            afficherPlanetes(dt);
        }
        private void afficherPlanetes(DataTable tableEspeces)
        {

            int bordGauche = 20;
            int bordHaut = 20;

            pnlAffichagePlanete.Controls.Clear();

            foreach (DataRow dr in tableEspeces.Rows)
            {
                CaracteristiquesPlanete ucPageInfo = new CaracteristiquesPlanete();
                ucPageInfo.chargerDonnees(dr);

                if (bordGauche + ucPageInfo.Width > pnlAffichagePlanete.Width)
                {
                    bordGauche = 20;
                    bordHaut += ucPageInfo.Height + 20;
                }

                ucPageInfo.Top = bordHaut;
                ucPageInfo.Left = bordGauche;

                pnlAffichagePlanete.Controls.Add(ucPageInfo);

                bordGauche += ucPageInfo.Width + 30;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
