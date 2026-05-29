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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbcStats = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpParticipant = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMilitaire = new System.Windows.Forms.GroupBox();
            this.tbrnReinitialiser = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpMission = new System.Windows.Forms.GroupBox();
            this.dgvMission = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbcStats.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMilitaire.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMilitaire
            // 
            this.cboMilitaire.FormattingEnabled = true;
            this.cboMilitaire.Location = new System.Drawing.Point(45, 33);
            this.cboMilitaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMilitaire.Name = "cboMilitaire";
            this.cboMilitaire.Size = new System.Drawing.Size(439, 33);
            this.cboMilitaire.TabIndex = 1;
            this.cboMilitaire.SelectedIndexChanged += new System.EventHandler(this.cboMilitaire_SelectedIndexChanged);
            // 
            // fwlpPlanete
            // 
            this.fwlpPlanete.AutoScroll = true;
            this.fwlpPlanete.BackColor = System.Drawing.Color.Transparent;
            this.fwlpPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fwlpPlanete.ForeColor = System.Drawing.Color.Black;
            this.fwlpPlanete.Location = new System.Drawing.Point(34, 31);
            this.fwlpPlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fwlpPlanete.Name = "fwlpPlanete";
            this.fwlpPlanete.Size = new System.Drawing.Size(976, 456);
            this.fwlpPlanete.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 192);
            this.dataGridView1.TabIndex = 3;
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
            this.tbcStats.Size = new System.Drawing.Size(1050, 577);
            this.tbcStats.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpMilitaire);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liste Militaire";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpParticipant);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(20, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des participants";
            // 
            // flpParticipant
            // 
            this.flpParticipant.AutoScroll = true;
            this.flpParticipant.Location = new System.Drawing.Point(45, 57);
            this.flpParticipant.Name = "flpParticipant";
            this.flpParticipant.Size = new System.Drawing.Size(911, 269);
            this.flpParticipant.TabIndex = 5;
            // 
            // grpMilitaire
            // 
            this.grpMilitaire.Controls.Add(this.cboMilitaire);
            this.grpMilitaire.Controls.Add(this.tbrnReinitialiser);
            this.grpMilitaire.Controls.Add(this.btnValider);
            this.grpMilitaire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpMilitaire.Location = new System.Drawing.Point(20, 31);
            this.grpMilitaire.Name = "grpMilitaire";
            this.grpMilitaire.Size = new System.Drawing.Size(994, 90);
            this.grpMilitaire.TabIndex = 4;
            this.grpMilitaire.TabStop = false;
            this.grpMilitaire.Text = "Choisir un chef de mission";
            // 
            // tbrnReinitialiser
            // 
            this.tbrnReinitialiser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbrnReinitialiser.Location = new System.Drawing.Point(801, 33);
            this.tbrnReinitialiser.Name = "tbrnReinitialiser";
            this.tbrnReinitialiser.Size = new System.Drawing.Size(155, 33);
            this.tbrnReinitialiser.TabIndex = 3;
            this.tbrnReinitialiser.Text = "Réinitialiser";
            this.tbrnReinitialiser.UseVisualStyleBackColor = true;
            this.tbrnReinitialiser.Click += new System.EventHandler(this.tbrnReinitialiser_Click);
            // 
            // btnValider
            // 
            this.btnValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValider.Location = new System.Drawing.Point(592, 33);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(155, 33);
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
            this.tabPage2.Size = new System.Drawing.Size(1042, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Budget Initiaux/Actuels";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.fwlpPlanete);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nombre De Missions / Planète";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1042, 539);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Liste de dépense les plus élevé";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1042, 539);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Liste des informateurs les moins payés";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1005, 612);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(135, 38);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // grpMission
            // 
            this.grpMission.Controls.Add(this.dgvMission);
            this.grpMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpMission.Location = new System.Drawing.Point(55, 36);
            this.grpMission.Name = "grpMission";
            this.grpMission.Size = new System.Drawing.Size(922, 452);
            this.grpMission.TabIndex = 0;
            this.grpMission.TabStop = false;
            this.grpMission.Text = "Liste des missions ayant plus de 10 membres";
            // 
            // dgvMission
            // 
            this.dgvMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMission.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMission.Location = new System.Drawing.Point(62, 82);
            this.dgvMission.Name = "dgvMission";
            this.dgvMission.RowHeadersWidth = 51;
            this.dgvMission.RowTemplate.Height = 24;
            this.dgvMission.Size = new System.Drawing.Size(800, 277);
            this.dgvMission.TabIndex = 0;
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 662);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.tbcStats);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStatistiques";
            this.Text = "frmStatistiques";
            this.Load += new System.EventHandler(this.frmStatistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbcStats.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpMilitaire.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.grpMission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMilitaire;
        private System.Windows.Forms.FlowLayoutPanel fwlpPlanete;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridView dgvMission;
    }
}