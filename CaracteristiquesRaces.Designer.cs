namespace SAE24
{
    partial class CaracteristiquesRaces
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
            this.picRaceImage = new System.Windows.Forms.PictureBox();
            this.lblNomRace = new System.Windows.Forms.Label();
            this.lblCouleurRace = new System.Windows.Forms.Label();
            this.lblOrigineRace = new System.Windows.Forms.Label();
            this.lblInfoSpecifique = new System.Windows.Forms.Label();
            this.lblBienveilAgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRaceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picRaceImage
            // 
            this.picRaceImage.Location = new System.Drawing.Point(8, 7);
            this.picRaceImage.Name = "picRaceImage";
            this.picRaceImage.Size = new System.Drawing.Size(175, 175);
            this.picRaceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRaceImage.TabIndex = 0;
            this.picRaceImage.TabStop = false;
            // 
            // lblNomRace
            // 
            this.lblNomRace.AutoSize = true;
            this.lblNomRace.Location = new System.Drawing.Point(18, 201);
            this.lblNomRace.Name = "lblNomRace";
            this.lblNomRace.Size = new System.Drawing.Size(29, 13);
            this.lblNomRace.TabIndex = 1;
            this.lblNomRace.Text = "Nom";
            // 
            // lblCouleurRace
            // 
            this.lblCouleurRace.AutoSize = true;
            this.lblCouleurRace.Location = new System.Drawing.Point(18, 225);
            this.lblCouleurRace.Name = "lblCouleurRace";
            this.lblCouleurRace.Size = new System.Drawing.Size(43, 13);
            this.lblCouleurRace.TabIndex = 2;
            this.lblCouleurRace.Text = "Couleur";
            // 
            // lblOrigineRace
            // 
            this.lblOrigineRace.AutoSize = true;
            this.lblOrigineRace.Location = new System.Drawing.Point(18, 250);
            this.lblOrigineRace.Name = "lblOrigineRace";
            this.lblOrigineRace.Size = new System.Drawing.Size(40, 13);
            this.lblOrigineRace.TabIndex = 3;
            this.lblOrigineRace.Text = "Origine";
            // 
            // lblInfoSpecifique
            // 
            this.lblInfoSpecifique.AutoSize = true;
            this.lblInfoSpecifique.Location = new System.Drawing.Point(18, 295);
            this.lblInfoSpecifique.Name = "lblInfoSpecifique";
            this.lblInfoSpecifique.Size = new System.Drawing.Size(91, 13);
            this.lblInfoSpecifique.TabIndex = 4;
            this.lblInfoSpecifique.Text = "Instrument / Arme";
            // 
            // lblBienveilAgress
            // 
            this.lblBienveilAgress.AutoSize = true;
            this.lblBienveilAgress.Location = new System.Drawing.Point(18, 273);
            this.lblBienveilAgress.Name = "lblBienveilAgress";
            this.lblBienveilAgress.Size = new System.Drawing.Size(138, 13);
            this.lblBienveilAgress.TabIndex = 5;
            this.lblBienveilAgress.Text = "Bienveillance / Aggressivité";
            // 
            // CaracteristiquesRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.lblBienveilAgress);
            this.Controls.Add(this.lblInfoSpecifique);
            this.Controls.Add(this.lblOrigineRace);
            this.Controls.Add(this.lblCouleurRace);
            this.Controls.Add(this.lblNomRace);
            this.Controls.Add(this.picRaceImage);
            this.Name = "CaracteristiquesRaces";
            this.Size = new System.Drawing.Size(190, 331);
            this.Load += new System.EventHandler(this.CaracteristiquesRaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRaceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRaceImage;
        private System.Windows.Forms.Label lblNomRace;
        private System.Windows.Forms.Label lblCouleurRace;
        private System.Windows.Forms.Label lblOrigineRace;
        private System.Windows.Forms.Label lblInfoSpecifique;
        private System.Windows.Forms.Label lblBienveilAgress;
    }
}
