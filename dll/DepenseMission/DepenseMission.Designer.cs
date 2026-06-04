namespace DepenseMission
{
    partial class DepenseMission
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
            this.grpDepense = new System.Windows.Forms.GroupBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.grpDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDepense
            // 
            this.grpDepense.Controls.Add(this.lblCommentaire);
            this.grpDepense.Location = new System.Drawing.Point(16, 113);
            this.grpDepense.Name = "grpDepense";
            this.grpDepense.Size = new System.Drawing.Size(346, 115);
            this.grpDepense.TabIndex = 0;
            this.grpDepense.TabStop = false;
            this.grpDepense.Text = "Dépense la plus importante";
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(16, 16);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(91, 91);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(173, 27);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(112, 18);
            this.lblNomMission.TabIndex = 1;
            this.lblNomMission.Text = "NomDeMission";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Location = new System.Drawing.Point(137, 75);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(40, 16);
            this.lblChef.TabIndex = 2;
            this.lblChef.Text = "Chef :";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(17, 35);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(44, 16);
            this.lblCommentaire.TabIndex = 0;
            this.lblCommentaire.Text = "label1";
            // 
            // DepenseMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.grpDepense);
            this.Name = "DepenseMission";
            this.Size = new System.Drawing.Size(386, 248);
            this.grpDepense.ResumeLayout(false);
            this.grpDepense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDepense;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblCommentaire;
    }
}
