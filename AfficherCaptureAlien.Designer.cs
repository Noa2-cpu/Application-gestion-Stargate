namespace SAE24
{
    partial class AfficherCaptureAlien
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
            this.LblNom = new System.Windows.Forms.Label();
            this.LblObjectif = new System.Windows.Forms.Label();
            this.LblPourcentage = new System.Windows.Forms.Label();
            this.PcbAlien = new System.Windows.Forms.PictureBox();
            this.LblNbr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(4, 122);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 2;
            this.LblNom.Text = "Nom";
            // 
            // LblObjectif
            // 
            this.LblObjectif.AutoSize = true;
            this.LblObjectif.Location = new System.Drawing.Point(4, 151);
            this.LblObjectif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblObjectif.Name = "LblObjectif";
            this.LblObjectif.Size = new System.Drawing.Size(63, 20);
            this.LblObjectif.TabIndex = 4;
            this.LblObjectif.Text = "Objectif";
            // 
            // LblPourcentage
            // 
            this.LblPourcentage.AutoSize = true;
            this.LblPourcentage.Location = new System.Drawing.Point(4, 191);
            this.LblPourcentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPourcentage.Name = "LblPourcentage";
            this.LblPourcentage.Size = new System.Drawing.Size(100, 20);
            this.LblPourcentage.TabIndex = 5;
            this.LblPourcentage.Text = "Pourcentage";
            this.LblPourcentage.Click += new System.EventHandler(this.LblPourcentage_Click);
            // 
            // PcbAlien
            // 
            this.PcbAlien.Location = new System.Drawing.Point(0, 4);
            this.PcbAlien.Name = "PcbAlien";
            this.PcbAlien.Size = new System.Drawing.Size(137, 115);
            this.PcbAlien.TabIndex = 3;
            this.PcbAlien.TabStop = false;
            // 
            // LblNbr
            // 
            this.LblNbr.AutoSize = true;
            this.LblNbr.Location = new System.Drawing.Point(4, 171);
            this.LblNbr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNbr.Name = "LblNbr";
            this.LblNbr.Size = new System.Drawing.Size(63, 20);
            this.LblNbr.TabIndex = 6;
            this.LblNbr.Text = "nombre";
            // 
            // AfficherCaptureAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblNbr);
            this.Controls.Add(this.LblPourcentage);
            this.Controls.Add(this.LblObjectif);
            this.Controls.Add(this.PcbAlien);
            this.Controls.Add(this.LblNom);
            this.Name = "AfficherCaptureAlien";
            this.Size = new System.Drawing.Size(224, 217);
            this.Load += new System.EventHandler(this.AfficherCaptureAlien_Load);
            this.Click += new System.EventHandler(this.AfficherCaptureAlien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PcbAlien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.PictureBox PcbAlien;
        private System.Windows.Forms.Label LblObjectif;
        private System.Windows.Forms.Label LblPourcentage;
        private System.Windows.Forms.Label LblNbr;
    }
}
