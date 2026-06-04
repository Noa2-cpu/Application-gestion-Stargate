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
            this.pnlRepertoir = new System.Windows.Forms.Panel();
            this.grpFiltresRep = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbEnnemies = new System.Windows.Forms.CheckBox();
            this.cbAlliees = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCouleurs = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpRepertoir.SuspendLayout();
            this.grpFiltresRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRepertoir
            // 
            this.grpRepertoir.Controls.Add(this.pnlRepertoir);
            this.grpRepertoir.Location = new System.Drawing.Point(12, 166);
            this.grpRepertoir.Name = "grpRepertoir";
            this.grpRepertoir.Size = new System.Drawing.Size(919, 428);
            this.grpRepertoir.TabIndex = 0;
            this.grpRepertoir.TabStop = false;
            // 
            // pnlRepertoir
            // 
            this.pnlRepertoir.AutoScroll = true;
            this.pnlRepertoir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepertoir.Location = new System.Drawing.Point(3, 16);
            this.pnlRepertoir.Name = "pnlRepertoir";
            this.pnlRepertoir.Size = new System.Drawing.Size(913, 409);
            this.pnlRepertoir.TabIndex = 0;
            // 
            // grpFiltresRep
            // 
            this.grpFiltresRep.Controls.Add(this.btnReset);
            this.grpFiltresRep.Controls.Add(this.cbEnnemies);
            this.grpFiltresRep.Controls.Add(this.cbAlliees);
            this.grpFiltresRep.Controls.Add(this.label2);
            this.grpFiltresRep.Controls.Add(this.label1);
            this.grpFiltresRep.Controls.Add(this.cmbCouleurs);
            this.grpFiltresRep.Controls.Add(this.txtRecherche);
            this.grpFiltresRep.Location = new System.Drawing.Point(12, 12);
            this.grpFiltresRep.Name = "grpFiltresRep";
            this.grpFiltresRep.Size = new System.Drawing.Size(922, 148);
            this.grpFiltresRep.TabIndex = 1;
            this.grpFiltresRep.TabStop = false;
            this.grpFiltresRep.Text = "Filtres";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(457, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbEnnemies
            // 
            this.cbEnnemies.AutoSize = true;
            this.cbEnnemies.Location = new System.Drawing.Point(294, 87);
            this.cbEnnemies.Name = "cbEnnemies";
            this.cbEnnemies.Size = new System.Drawing.Size(72, 17);
            this.cbEnnemies.TabIndex = 6;
            this.cbEnnemies.Text = "Ennemies";
            this.cbEnnemies.UseVisualStyleBackColor = true;
            this.cbEnnemies.CheckedChanged += new System.EventHandler(this.cbEnnemies_CheckedChanged);
            // 
            // cbAlliees
            // 
            this.cbAlliees.AutoSize = true;
            this.cbAlliees.Location = new System.Drawing.Point(294, 39);
            this.cbAlliees.Name = "cbAlliees";
            this.cbAlliees.Size = new System.Drawing.Size(56, 17);
            this.cbAlliees.TabIndex = 5;
            this.cbAlliees.Text = "Alliées";
            this.cbAlliees.UseVisualStyleBackColor = true;
            this.cbAlliees.CheckedChanged += new System.EventHandler(this.cbAlliees_CheckedChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom (like) :";
            // 
            // cmbCouleurs
            // 
            this.cmbCouleurs.FormattingEnabled = true;
            this.cmbCouleurs.Location = new System.Drawing.Point(96, 83);
            this.cmbCouleurs.Name = "cmbCouleurs";
            this.cmbCouleurs.Size = new System.Drawing.Size(121, 21);
            this.cmbCouleurs.TabIndex = 2;
            this.cmbCouleurs.SelectedIndexChanged += new System.EventHandler(this.cmbCouleurs_SelectedIndexChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(96, 36);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(853, 604);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // RepertoireRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(943, 639);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.grpFiltresRep);
            this.Controls.Add(this.grpRepertoir);
            this.Name = "RepertoireRaces";
            this.Text = "Races Répertoriées";
            this.Load += new System.EventHandler(this.RepertoireRaces_Load);
            this.grpRepertoir.ResumeLayout(false);
            this.grpFiltresRep.ResumeLayout(false);
            this.grpFiltresRep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRepertoir;
        private System.Windows.Forms.GroupBox grpFiltresRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCouleurs;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel pnlRepertoir;
        private System.Windows.Forms.CheckBox cbEnnemies;
        private System.Windows.Forms.CheckBox cbAlliees;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRetour;
    }
}