namespace Trombinoscope
{
    partial class trombinoscope
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
            this.pcbDuNom = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuNom)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbDuNom
            // 
            this.pcbDuNom.Location = new System.Drawing.Point(42, 34);
            this.pcbDuNom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pcbDuNom.Name = "pcbDuNom";
            this.pcbDuNom.Size = new System.Drawing.Size(110, 114);
            this.pcbDuNom.TabIndex = 0;
            this.pcbDuNom.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(56, 167);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 29);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            // 
            // trombinoscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pcbDuNom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "trombinoscope";
            this.Size = new System.Drawing.Size(187, 239);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuNom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbDuNom;
        private System.Windows.Forms.Label lblNom;
    }
}
