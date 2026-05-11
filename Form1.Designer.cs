namespace SAE24
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterMission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterMission
            // 
            this.btnAjouterMission.Location = new System.Drawing.Point(73, 68);
            this.btnAjouterMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterMission.Name = "btnAjouterMission";
            this.btnAjouterMission.Size = new System.Drawing.Size(414, 170);
            this.btnAjouterMission.TabIndex = 0;
            this.btnAjouterMission.Text = "Ajouter une nouvelle mission";
            this.btnAjouterMission.UseVisualStyleBackColor = true;
            this.btnAjouterMission.Click += new System.EventHandler(this.btnAjouterMission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAjouterMission);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterMission;
    }
}

