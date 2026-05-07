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
            this.btnAjouterMission.Location = new System.Drawing.Point(109, 104);
            this.btnAjouterMission.Name = "btnAjouterMission";
            this.btnAjouterMission.Size = new System.Drawing.Size(621, 262);
            this.btnAjouterMission.TabIndex = 0;
            this.btnAjouterMission.Text = "Ajouter une nouvelle mission";
            this.btnAjouterMission.UseVisualStyleBackColor = true;
            this.btnAjouterMission.Click += new System.EventHandler(this.btnAjouterMission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouterMission);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterMission;
    }
}

