namespace MissionStats
{
    partial class MissionStats
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbPlanete = new System.Windows.Forms.PictureBox();
            this.lblBudgetActu = new System.Windows.Forms.Label();
            this.lblBudgetIni = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlanete
            // 
            this.pcbPlanete.Location = new System.Drawing.Point(12, 51);
            this.pcbPlanete.Name = "pcbPlanete";
            this.pcbPlanete.Size = new System.Drawing.Size(127, 120);
            this.pcbPlanete.TabIndex = 11;
            this.pcbPlanete.TabStop = false;
            // 
            // lblBudgetActu
            // 
            this.lblBudgetActu.AutoSize = true;
            this.lblBudgetActu.Location = new System.Drawing.Point(3, 228);
            this.lblBudgetActu.Name = "lblBudgetActu";
            this.lblBudgetActu.Size = new System.Drawing.Size(95, 16);
            this.lblBudgetActu.TabIndex = 10;
            this.lblBudgetActu.Text = "Budget actuel :";
            // 
            // lblBudgetIni
            // 
            this.lblBudgetIni.AutoSize = true;
            this.lblBudgetIni.Location = new System.Drawing.Point(3, 192);
            this.lblBudgetIni.Name = "lblBudgetIni";
            this.lblBudgetIni.Size = new System.Drawing.Size(89, 16);
            this.lblBudgetIni.TabIndex = 8;
            this.lblBudgetIni.Text = "Budget initial :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNom.Location = new System.Drawing.Point(23, 12);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(117, 25);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "nomMission";
            // 
            // MissionStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbPlanete);
            this.Controls.Add(this.lblBudgetActu);
            this.Controls.Add(this.lblBudgetIni);
            this.Controls.Add(this.lbNom);
            this.Name = "MissionStats";
            this.Size = new System.Drawing.Size(153, 267);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPlanete;
        private System.Windows.Forms.Label lblBudgetActu;
        private System.Windows.Forms.Label lblBudgetIni;
        private System.Windows.Forms.Label lbNom;
    }
}
