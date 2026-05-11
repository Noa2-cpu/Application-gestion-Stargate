namespace SAE24
{
    partial class RepertoireRaces
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
            this.grpRepertoir = new System.Windows.Forms.GroupBox();
            this.grpFiltresRep = new System.Windows.Forms.GroupBox();
            this.btnRechercheFiltre = new System.Windows.Forms.Button();
            this.txtNomFiltre = new System.Windows.Forms.TextBox();
            this.cboCouleurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFiltresRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRepertoir
            // 
            this.grpRepertoir.Location = new System.Drawing.Point(27, 12);
            this.grpRepertoir.Name = "grpRepertoir";
            this.grpRepertoir.Size = new System.Drawing.Size(482, 247);
            this.grpRepertoir.TabIndex = 0;
            this.grpRepertoir.TabStop = false;
            // 
            // grpFiltresRep
            // 
            this.grpFiltresRep.Controls.Add(this.label2);
            this.grpFiltresRep.Controls.Add(this.label1);
            this.grpFiltresRep.Controls.Add(this.cboCouleurs);
            this.grpFiltresRep.Controls.Add(this.txtNomFiltre);
            this.grpFiltresRep.Controls.Add(this.btnRechercheFiltre);
            this.grpFiltresRep.Location = new System.Drawing.Point(27, 290);
            this.grpFiltresRep.Name = "grpFiltresRep";
            this.grpFiltresRep.Size = new System.Drawing.Size(482, 148);
            this.grpFiltresRep.TabIndex = 1;
            this.grpFiltresRep.TabStop = false;
            this.grpFiltresRep.Text = "Filtres";
            // 
            // btnRechercheFiltre
            // 
            this.btnRechercheFiltre.Image = global::SAE24.Properties.Resources.Logo_Loupe;
            this.btnRechercheFiltre.ImageKey = "(aucun)";
            this.btnRechercheFiltre.Location = new System.Drawing.Point(401, 53);
            this.btnRechercheFiltre.Name = "btnRechercheFiltre";
            this.btnRechercheFiltre.Size = new System.Drawing.Size(75, 43);
            this.btnRechercheFiltre.TabIndex = 0;
            this.btnRechercheFiltre.UseVisualStyleBackColor = true;
            // 
            // txtNomFiltre
            // 
            this.txtNomFiltre.Location = new System.Drawing.Point(96, 36);
            this.txtNomFiltre.Name = "txtNomFiltre";
            this.txtNomFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtNomFiltre.TabIndex = 1;
            // 
            // cboCouleurs
            // 
            this.cboCouleurs.FormattingEnabled = true;
            this.cboCouleurs.Location = new System.Drawing.Point(96, 83);
            this.cboCouleurs.Name = "cboCouleurs";
            this.cboCouleurs.Size = new System.Drawing.Size(121, 21);
            this.cboCouleurs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom (like) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Couleur:";
            // 
            // RepertoireRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFiltresRep);
            this.Controls.Add(this.grpRepertoir);
            this.Name = "RepertoireRaces";
            this.Text = "Races Répertoriées";
            this.Load += new System.EventHandler(this.RepertoireRaces_Load);
            this.grpFiltresRep.ResumeLayout(false);
            this.grpFiltresRep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRepertoir;
        private System.Windows.Forms.GroupBox grpFiltresRep;
        private System.Windows.Forms.Button btnRechercheFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCouleurs;
        private System.Windows.Forms.TextBox txtNomFiltre;
    }
}