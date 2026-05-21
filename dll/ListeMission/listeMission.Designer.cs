namespace ListeMission
{
    partial class listeMission
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblRetour = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.pcbPlanete = new System.Windows.Forms.PictureBox();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNom.Location = new System.Drawing.Point(72, 13);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 25);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "nomPlanete";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(81, 63);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(139, 16);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "Départ : XX/MM/YYYY";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Location = new System.Drawing.Point(81, 94);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(40, 16);
            this.lblChef.TabIndex = 2;
            this.lblChef.Text = "Chef :";
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Location = new System.Drawing.Point(250, 63);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(138, 16);
            this.lblRetour.TabIndex = 3;
            this.lblRetour.Text = "Retour : XX/MM/YYYY";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(250, 94);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(56, 16);
            this.lblBudget.TabIndex = 4;
            this.lblBudget.Text = "Budget :";
            // 
            // pcbPlanete
            // 
            this.pcbPlanete.Location = new System.Drawing.Point(7, 51);
            this.pcbPlanete.Name = "pcbPlanete";
            this.pcbPlanete.Size = new System.Drawing.Size(68, 72);
            this.pcbPlanete.TabIndex = 5;
            this.pcbPlanete.TabStop = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(403, 51);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(45, 43);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // listeMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.pcbPlanete);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblRetour);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lbNom);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "listeMission";
            this.Size = new System.Drawing.Size(460, 140);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.PictureBox pcbPlanete;
        private System.Windows.Forms.Button btnDetail;
    }
}
