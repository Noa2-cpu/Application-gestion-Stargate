namespace InformateurStats
{
    partial class InformateurStats
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.lblRecu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(38, 38);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(380, 304);
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(456, 94);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(117, 39);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code :";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(456, 182);
            this.lblOrigine.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(286, 39);
            this.lblOrigine.TabIndex = 2;
            this.lblOrigine.Text = "Espèce d\'origine :";
            // 
            // lblRecu
            // 
            this.lblRecu.AutoSize = true;
            this.lblRecu.Location = new System.Drawing.Point(456, 266);
            this.lblRecu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblRecu.Name = "lblRecu";
            this.lblRecu.Size = new System.Drawing.Size(115, 39);
            this.lblRecu.TabIndex = 3;
            this.lblRecu.Text = "Reçu :";
            // 
            // InformateurStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecu);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.pcbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "InformateurStats";
            this.Size = new System.Drawing.Size(1045, 398);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.Label lblRecu;
    }
}
