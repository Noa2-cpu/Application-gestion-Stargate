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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.chkbAVenir = new System.Windows.Forms.CheckBox();
            this.chkbTerminer = new System.Windows.Forms.CheckBox();
            this.chkbEnCours = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbGris = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.txtbFiltre = new System.Windows.Forms.TextBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpMission = new System.Windows.Forms.GroupBox();
            this.grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGris)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grpMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Créer une mission";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 43);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Répertoire des Races";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(752, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Répertoire des planètes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flpMissions
            // 
            this.flpMissions.AutoScroll = true;
            this.flpMissions.BackColor = System.Drawing.Color.Transparent;
            this.flpMissions.Location = new System.Drawing.Point(20, 31);
            this.flpMissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(497, 475);
            this.flpMissions.TabIndex = 4;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(1057, 43);
            this.btnStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(228, 35);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1168, 726);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(218, 50);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // grpFiltre
            // 
            this.grpFiltre.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltre.Controls.Add(this.chkbAVenir);
            this.grpFiltre.Controls.Add(this.chkbTerminer);
            this.grpFiltre.Controls.Add(this.chkbEnCours);
            this.grpFiltre.Controls.Add(this.label4);
            this.grpFiltre.Controls.Add(this.label3);
            this.grpFiltre.Controls.Add(this.pictureBox2);
            this.grpFiltre.Controls.Add(this.pictureBox1);
            this.grpFiltre.Controls.Add(this.label1);
            this.grpFiltre.Controls.Add(this.pcbGris);
            this.grpFiltre.Controls.Add(this.label2);
            this.grpFiltre.Controls.Add(this.btnReinitialiser);
            this.grpFiltre.Controls.Add(this.btnAppliquer);
            this.grpFiltre.Controls.Add(this.txtbFiltre);
            this.grpFiltre.Location = new System.Drawing.Point(29, 173);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(533, 527);
            this.grpFiltre.TabIndex = 8;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtres des missions";
            // 
            // chkbAVenir
            // 
            this.chkbAVenir.AutoSize = true;
            this.chkbAVenir.Location = new System.Drawing.Point(270, 189);
            this.chkbAVenir.Name = "chkbAVenir";
            this.chkbAVenir.Size = new System.Drawing.Size(95, 29);
            this.chkbAVenir.TabIndex = 14;
            this.chkbAVenir.Text = "A venir";
            this.chkbAVenir.UseVisualStyleBackColor = true;
            // 
            // chkbTerminer
            // 
            this.chkbTerminer.AutoSize = true;
            this.chkbTerminer.Location = new System.Drawing.Point(68, 238);
            this.chkbTerminer.Name = "chkbTerminer";
            this.chkbTerminer.Size = new System.Drawing.Size(117, 29);
            this.chkbTerminer.TabIndex = 13;
            this.chkbTerminer.Text = "Terminée";
            this.chkbTerminer.UseVisualStyleBackColor = true;
            // 
            // chkbEnCours
            // 
            this.chkbEnCours.AutoSize = true;
            this.chkbEnCours.Location = new System.Drawing.Point(68, 189);
            this.chkbEnCours.Name = "chkbEnCours";
            this.chkbEnCours.Size = new System.Drawing.Size(111, 29);
            this.chkbEnCours.TabIndex = 12;
            this.chkbEnCours.Text = "En cours";
            this.chkbEnCours.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "A venir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "En cours";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SAE24.Properties.Resources.Vert;
            this.pictureBox2.Location = new System.Drawing.Point(68, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAE24.Properties.Resources.Bleu;
            this.pictureBox1.Location = new System.Drawing.Point(268, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Terminée";
            // 
            // pcbGris
            // 
            this.pcbGris.Image = global::SAE24.Properties.Resources.Gris;
            this.pcbGris.Location = new System.Drawing.Point(68, 383);
            this.pcbGris.Name = "pcbGris";
            this.pcbGris.Size = new System.Drawing.Size(23, 23);
            this.pcbGris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGris.TabIndex = 5;
            this.pcbGris.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom de la mission :";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(270, 441);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(206, 39);
            this.btnReinitialiser.TabIndex = 2;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(53, 441);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(206, 39);
            this.btnAppliquer.TabIndex = 1;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            this.btnAppliquer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAppliquer_KeyPress);
            // 
            // txtbFiltre
            // 
            this.txtbFiltre.Location = new System.Drawing.Point(243, 70);
            this.txtbFiltre.Name = "txtbFiltre";
            this.txtbFiltre.Size = new System.Drawing.Size(233, 30);
            this.txtbFiltre.TabIndex = 0;
            this.txtbFiltre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFiltre_KeyPress);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnStats);
            this.grpMenu.Controls.Add(this.button4);
            this.grpMenu.Controls.Add(this.button3);
            this.grpMenu.Controls.Add(this.button2);
            this.grpMenu.Location = new System.Drawing.Point(32, 29);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1368, 125);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // grpMission
            // 
            this.grpMission.Controls.Add(this.flpMissions);
            this.grpMission.Location = new System.Drawing.Point(869, 173);
            this.grpMission.Name = "grpMission";
            this.grpMission.Size = new System.Drawing.Size(531, 527);
            this.grpMission.TabIndex = 10;
            this.grpMission.TabStop = false;
            this.grpMission.Text = "Liste des Missions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SAE24.Properties.Resources.Fond2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 846);
            this.Controls.Add(this.grpMission);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.btnQuitter);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Liste des missions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGris)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMission.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.TextBox txtbFiltre;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMission;
        private System.Windows.Forms.PictureBox pcbGris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkbAVenir;
        private System.Windows.Forms.CheckBox chkbTerminer;
        private System.Windows.Forms.CheckBox chkbEnCours;
    }
}

