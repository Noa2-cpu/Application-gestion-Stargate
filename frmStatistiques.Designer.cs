namespace SAE24
{
    partial class frmStatistiques
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
            this.cboMilitaire = new System.Windows.Forms.ComboBox();
            this.fwlpPlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.tbcStats = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpParticipant = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMilitaire = new System.Windows.Forms.GroupBox();
            this.tbrnReinitialiser = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpMission = new System.Windows.Forms.GroupBox();
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flpInformateur = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flpDepenses = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.tbcStats.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMilitaire.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpMission.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMilitaire
            // 
            this.cboMilitaire.FormattingEnabled = true;
            this.cboMilitaire.Location = new System.Drawing.Point(45, 55);
            this.cboMilitaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMilitaire.Name = "cboMilitaire";
            this.cboMilitaire.Size = new System.Drawing.Size(598, 33);
            this.cboMilitaire.TabIndex = 1;
            this.cboMilitaire.SelectedIndexChanged += new System.EventHandler(this.cboMilitaire_SelectedIndexChanged);
            this.cboMilitaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMilitaire_KeyPress);
            // 
            // fwlpPlanete
            // 
            this.fwlpPlanete.AutoScroll = true;
            this.fwlpPlanete.BackColor = System.Drawing.Color.Transparent;
            this.fwlpPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fwlpPlanete.ForeColor = System.Drawing.Color.Black;
            this.fwlpPlanete.Location = new System.Drawing.Point(28, 31);
            this.fwlpPlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fwlpPlanete.Name = "fwlpPlanete";
            this.fwlpPlanete.Size = new System.Drawing.Size(1221, 485);
            this.fwlpPlanete.TabIndex = 2;
            this.fwlpPlanete.Paint += new System.Windows.Forms.PaintEventHandler(this.fwlpPlanete_Paint);
            // 
            // tbcStats
            // 
            this.tbcStats.Controls.Add(this.tabPage1);
            this.tbcStats.Controls.Add(this.tabPage2);
            this.tbcStats.Controls.Add(this.tabPage3);
            this.tbcStats.Controls.Add(this.tabPage4);
            this.tbcStats.Controls.Add(this.tabPage5);
            this.tbcStats.Location = new System.Drawing.Point(39, 23);
            this.tbcStats.Name = "tbcStats";
            this.tbcStats.SelectedIndex = 0;
            this.tbcStats.Size = new System.Drawing.Size(1345, 621);
            this.tbcStats.TabIndex = 4;
            this.tbcStats.SelectedIndexChanged += new System.EventHandler(this.tbcStats_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpMilitaire);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1337, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste Militaire";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpParticipant);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(20, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1289, 404);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des participants";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flpParticipant
            // 
            this.flpParticipant.AutoScroll = true;
            this.flpParticipant.Location = new System.Drawing.Point(45, 57);
            this.flpParticipant.Name = "flpParticipant";
            this.flpParticipant.Size = new System.Drawing.Size(1206, 313);
            this.flpParticipant.TabIndex = 5;
            this.flpParticipant.Paint += new System.Windows.Forms.PaintEventHandler(this.flpParticipant_Paint);
            // 
            // grpMilitaire
            // 
            this.grpMilitaire.Controls.Add(this.cboMilitaire);
            this.grpMilitaire.Controls.Add(this.tbrnReinitialiser);
            this.grpMilitaire.Controls.Add(this.btnValider);
            this.grpMilitaire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpMilitaire.Location = new System.Drawing.Point(20, 31);
            this.grpMilitaire.Name = "grpMilitaire";
            this.grpMilitaire.Size = new System.Drawing.Size(1289, 121);
            this.grpMilitaire.TabIndex = 4;
            this.grpMilitaire.TabStop = false;
            this.grpMilitaire.Text = "Choisir un chef de mission";
            this.grpMilitaire.Enter += new System.EventHandler(this.grpMilitaire_Enter);
            // 
            // tbrnReinitialiser
            // 
            this.tbrnReinitialiser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbrnReinitialiser.Location = new System.Drawing.Point(1008, 38);
            this.tbrnReinitialiser.Name = "tbrnReinitialiser";
            this.tbrnReinitialiser.Size = new System.Drawing.Size(210, 40);
            this.tbrnReinitialiser.TabIndex = 3;
            this.tbrnReinitialiser.Text = "Réinitialiser";
            this.tbrnReinitialiser.UseVisualStyleBackColor = true;
            this.tbrnReinitialiser.Click += new System.EventHandler(this.tbrnReinitialiser_Click);
            // 
            // btnValider
            // 
            this.btnValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValider.Location = new System.Drawing.Point(746, 38);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(210, 40);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.grpMission);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1337, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Budget Initiaux/Actuels";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // grpMission
            // 
            this.grpMission.Controls.Add(this.flpMissions);
            this.grpMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpMission.Location = new System.Drawing.Point(55, 36);
            this.grpMission.Name = "grpMission";
            this.grpMission.Size = new System.Drawing.Size(1217, 496);
            this.grpMission.TabIndex = 0;
            this.grpMission.TabStop = false;
            this.grpMission.Text = "Liste des missions ayant plus de 10 membres";
            this.grpMission.Enter += new System.EventHandler(this.grpMission_Enter);
            // 
            // flpMissions
            // 
            this.flpMissions.Location = new System.Drawing.Point(51, 61);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(1108, 395);
            this.flpMissions.TabIndex = 0;
            this.flpMissions.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMissions_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1337, 583);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nombre De Missions / Planète";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fwlpPlanete);
            this.groupBox2.Location = new System.Drawing.Point(21, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1280, 539);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliquez sur une planète pour afficher le nombre de missions";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1337, 583);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Liste de dépense les plus élevé";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1337, 583);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Liste des informateurs les moins payés";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // flpInformateur
            // 
            this.flpInformateur.Location = new System.Drawing.Point(35, 45);
            this.flpInformateur.Name = "flpInformateur";
            this.flpInformateur.Size = new System.Drawing.Size(1168, 434);
            this.flpInformateur.TabIndex = 0;
            this.flpInformateur.Paint += new System.Windows.Forms.PaintEventHandler(this.flpInformateur_Paint);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1106, 671);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(190, 45);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flpDepenses);
            this.groupBox3.Location = new System.Drawing.Point(47, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1257, 496);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des missions";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // flpDepenses
            // 
            this.flpDepenses.AutoScroll = true;
            this.flpDepenses.Location = new System.Drawing.Point(52, 45);
            this.flpDepenses.Name = "flpDepenses";
            this.flpDepenses.Size = new System.Drawing.Size(1134, 414);
            this.flpDepenses.TabIndex = 0;
            this.flpDepenses.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDepenses_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flpInformateur);
            this.groupBox4.Location = new System.Drawing.Point(53, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1236, 506);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informateur";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::SAE24.Properties.Resources.Logo;
            this.pcbLogo.Location = new System.Drawing.Point(82, 659);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(88, 88);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 6;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Click += new System.EventHandler(this.pcbLogo_Click);
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 750);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.tbcStats);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStatistiques";
            this.Text = "frmStatistiques";
            this.Load += new System.EventHandler(this.frmStatistiques_Load);
            this.tbcStats.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpMilitaire.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpMission.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMilitaire;
        private System.Windows.Forms.FlowLayoutPanel fwlpPlanete;
        private System.Windows.Forms.TabControl tbcStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button tbrnReinitialiser;
        private System.Windows.Forms.GroupBox grpMilitaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpParticipant;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox grpMission;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpInformateur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flpDepenses;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}