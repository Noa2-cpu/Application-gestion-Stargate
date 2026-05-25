namespace SAE24
{
    partial class MilitaireCivil
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
            this.PcbPhoto = new System.Windows.Forms.PictureBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbPhoto
            // 
            this.PcbPhoto.Location = new System.Drawing.Point(3, 0);
            this.PcbPhoto.Name = "PcbPhoto";
            this.PcbPhoto.Size = new System.Drawing.Size(117, 92);
            this.PcbPhoto.TabIndex = 0;
            this.PcbPhoto.TabStop = false;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNom.Location = new System.Drawing.Point(28, 95);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(64, 25);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "label1";
            this.LblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPrenom.Location = new System.Drawing.Point(28, 120);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(64, 25);
            this.LblPrenom.TabIndex = 2;
            this.LblPrenom.Text = "label1";
            this.LblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MilitaireCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPrenom);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.PcbPhoto);
            this.Name = "MilitaireCivil";
            this.Size = new System.Drawing.Size(124, 147);
            this.Load += new System.EventHandler(this.MilitaireCivil_Load);
            this.Click += new System.EventHandler(this.MilitaireCivil_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbPhoto;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblPrenom;
    }
}
