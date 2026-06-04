namespace SAE24
{
    partial class CaracteristiquesPlanete
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
            this.picPlanete = new System.Windows.Forms.PictureBox();
            this.lblNomPlanete = new System.Windows.Forms.Label();
            this.picTemperature = new System.Windows.Forms.PictureBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblGravite = new System.Windows.Forms.Label();
            this.lblPresenceDataBaz = new System.Windows.Forms.Label();
            this.plnPlanete = new System.Windows.Forms.Panel();
            this.lblRapportDeForce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemperature)).BeginInit();
            this.plnPlanete.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPlanete
            // 
            this.picPlanete.Location = new System.Drawing.Point(13, 10);
            this.picPlanete.Name = "picPlanete";
            this.picPlanete.Size = new System.Drawing.Size(175, 175);
            this.picPlanete.TabIndex = 0;
            this.picPlanete.TabStop = false;
            this.picPlanete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPlanete_MouseClick);
            // 
            // lblNomPlanete
            // 
            this.lblNomPlanete.AutoSize = true;
            this.lblNomPlanete.Location = new System.Drawing.Point(39, 197);
            this.lblNomPlanete.Name = "lblNomPlanete";
            this.lblNomPlanete.Size = new System.Drawing.Size(68, 13);
            this.lblNomPlanete.TabIndex = 1;
            this.lblNomPlanete.Text = "Nom Planete";
            // 
            // picTemperature
            // 
            this.picTemperature.Location = new System.Drawing.Point(13, 213);
            this.picTemperature.Name = "picTemperature";
            this.picTemperature.Size = new System.Drawing.Size(30, 30);
            this.picTemperature.TabIndex = 2;
            this.picTemperature.TabStop = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(49, 230);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblGravite
            // 
            this.lblGravite.AutoSize = true;
            this.lblGravite.Location = new System.Drawing.Point(20, 255);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(41, 13);
            this.lblGravite.TabIndex = 4;
            this.lblGravite.Text = "Gravité";
            // 
            // lblPresenceDataBaz
            // 
            this.lblPresenceDataBaz.AutoSize = true;
            this.lblPresenceDataBaz.Location = new System.Drawing.Point(20, 279);
            this.lblPresenceDataBaz.Name = "lblPresenceDataBaz";
            this.lblPresenceDataBaz.Size = new System.Drawing.Size(110, 13);
            this.lblPresenceDataBaz.TabIndex = 5;
            this.lblPresenceDataBaz.Text = "Presence de Databaz";
            // 
            // plnPlanete
            // 
            this.plnPlanete.BackColor = System.Drawing.Color.Transparent;
            this.plnPlanete.Controls.Add(this.lblRapportDeForce);
            this.plnPlanete.Controls.Add(this.picPlanete);
            this.plnPlanete.Controls.Add(this.lblPresenceDataBaz);
            this.plnPlanete.Controls.Add(this.lblNomPlanete);
            this.plnPlanete.Controls.Add(this.lblGravite);
            this.plnPlanete.Controls.Add(this.lblTemperature);
            this.plnPlanete.Controls.Add(this.picTemperature);
            this.plnPlanete.Location = new System.Drawing.Point(0, 0);
            this.plnPlanete.Name = "plnPlanete";
            this.plnPlanete.Size = new System.Drawing.Size(207, 337);
            this.plnPlanete.TabIndex = 6;
            this.plnPlanete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plnPlanete_MouseClick);
            // 
            // lblRapportDeForce
            // 
            this.lblRapportDeForce.AutoSize = true;
            this.lblRapportDeForce.Location = new System.Drawing.Point(20, 306);
            this.lblRapportDeForce.Name = "lblRapportDeForce";
            this.lblRapportDeForce.Size = new System.Drawing.Size(87, 13);
            this.lblRapportDeForce.TabIndex = 6;
            this.lblRapportDeForce.Text = "Rapport de force";
            // 
            // CaracteristiquesPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plnPlanete);
            this.Name = "CaracteristiquesPlanete";
            this.Size = new System.Drawing.Size(207, 337);
            ((System.ComponentModel.ISupportInitialize)(this.picPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemperature)).EndInit();
            this.plnPlanete.ResumeLayout(false);
            this.plnPlanete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlanete;
        private System.Windows.Forms.Label lblNomPlanete;
        private System.Windows.Forms.PictureBox picTemperature;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.Label lblPresenceDataBaz;
        private System.Windows.Forms.Panel plnPlanete;
        private System.Windows.Forms.Label lblRapportDeForce;
    }
}
