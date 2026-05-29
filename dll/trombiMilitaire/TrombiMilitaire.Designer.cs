namespace trombiMilitaire
{
    partial class TrombiMilitaire
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
            this.lblNom = new System.Windows.Forms.Label();
            this.pcbDuNom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuNom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 99);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 16);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "label1";
            // 
            // pcbDuNom
            // 
            this.pcbDuNom.Location = new System.Drawing.Point(19, 26);
            this.pcbDuNom.Name = "pcbDuNom";
            this.pcbDuNom.Size = new System.Drawing.Size(63, 63);
            this.pcbDuNom.TabIndex = 2;
            this.pcbDuNom.TabStop = false;
            // 
            // TrombiMilitaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pcbDuNom);
            this.Name = "TrombiMilitaire";
            this.Size = new System.Drawing.Size(101, 141);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuNom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pcbDuNom;
    }
}
