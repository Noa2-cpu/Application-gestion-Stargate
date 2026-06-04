namespace SAE24
{
    partial class RepertoirePlanetes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRepertoirePlanete = new System.Windows.Forms.GroupBox();
            this.pnlAffichagePlanete = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpRepertoirePlanete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRepertoirePlanete
            // 
            this.grpRepertoirePlanete.Controls.Add(this.pnlAffichagePlanete);
            this.grpRepertoirePlanete.Location = new System.Drawing.Point(26, 12);
            this.grpRepertoirePlanete.Name = "grpRepertoirePlanete";
            this.grpRepertoirePlanete.Size = new System.Drawing.Size(750, 404);
            this.grpRepertoirePlanete.TabIndex = 0;
            this.grpRepertoirePlanete.TabStop = false;
            // 
            // pnlAffichagePlanete
            // 
            this.pnlAffichagePlanete.AutoScroll = true;
            this.pnlAffichagePlanete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAffichagePlanete.Location = new System.Drawing.Point(3, 16);
            this.pnlAffichagePlanete.Name = "pnlAffichagePlanete";
            this.pnlAffichagePlanete.Size = new System.Drawing.Size(744, 385);
            this.pnlAffichagePlanete.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(701, 422);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // RepertoirePlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.grpRepertoirePlanete);
            this.Name = "RepertoirePlanetes";
            this.Text = "Répertoire des planetes";
            this.Load += new System.EventHandler(this.RepertoirePlanetes_Load);
            this.grpRepertoirePlanete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRepertoirePlanete;
        private System.Windows.Forms.Panel pnlAffichagePlanete;
        private System.Windows.Forms.Button btnRetour;
    }
}