namespace SAE24
{
    partial class GrpContact
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
            this.GrpJournal = new System.Windows.Forms.GroupBox();
            this.TxtNumeroEvenement = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblEvenement = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblNav = new System.Windows.Forms.Label();
            this.BtnReculer1 = new System.Windows.Forms.Button();
            this.BtnAvancer1 = new System.Windows.Forms.Button();
            this.BtnAllerDernier = new System.Windows.Forms.Button();
            this.BtnAllerPremier = new System.Windows.Forms.Button();
            this.GrpContactRendu = new System.Windows.Forms.GroupBox();
            this.DgvAfficherContact = new System.Windows.Forms.DataGridView();
            this.GrpDepenses = new System.Windows.Forms.GroupBox();
            this.DgvDepenses = new System.Windows.Forms.DataGridView();
            this.BtnEditerPdf = new System.Windows.Forms.Button();
            this.LblSommeContact = new System.Windows.Forms.Label();
            this.LblTotalDepense = new System.Windows.Forms.Label();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlpCaptures = new System.Windows.Forms.FlowLayoutPanel();
            this.LblInfo = new System.Windows.Forms.Label();
            this.GrpJournal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.GrpContactRendu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfficherContact)).BeginInit();
            this.GrpDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.FlpCaptures.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpJournal
            // 
            this.GrpJournal.Controls.Add(this.TxtNumeroEvenement);
            this.GrpJournal.Controls.Add(this.flowLayoutPanel1);
            this.GrpJournal.Controls.Add(this.LblDate);
            this.GrpJournal.Controls.Add(this.LblNav);
            this.GrpJournal.Controls.Add(this.BtnReculer1);
            this.GrpJournal.Controls.Add(this.BtnAvancer1);
            this.GrpJournal.Controls.Add(this.BtnAllerDernier);
            this.GrpJournal.Controls.Add(this.BtnAllerPremier);
            this.GrpJournal.Location = new System.Drawing.Point(26, 22);
            this.GrpJournal.Name = "GrpJournal";
            this.GrpJournal.Size = new System.Drawing.Size(614, 284);
            this.GrpJournal.TabIndex = 0;
            this.GrpJournal.TabStop = false;
            this.GrpJournal.Text = "Evénement du journal";
            // 
            // TxtNumeroEvenement
            // 
            this.TxtNumeroEvenement.Location = new System.Drawing.Point(283, 240);
            this.TxtNumeroEvenement.Name = "TxtNumeroEvenement";
            this.TxtNumeroEvenement.Size = new System.Drawing.Size(33, 30);
            this.TxtNumeroEvenement.TabIndex = 7;
            this.TxtNumeroEvenement.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtNumeroEvenement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroEvenement_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.LblEvenement);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 116);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // LblEvenement
            // 
            this.LblEvenement.AutoSize = true;
            this.LblEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEvenement.Location = new System.Drawing.Point(3, 0);
            this.LblEvenement.Name = "LblEvenement";
            this.LblEvenement.Size = new System.Drawing.Size(64, 25);
            this.LblEvenement.TabIndex = 0;
            this.LblEvenement.Text = "label1";
            this.LblEvenement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(21, 76);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(64, 25);
            this.LblDate.TabIndex = 5;
            this.LblDate.Text = "label2";
            // 
            // LblNav
            // 
            this.LblNav.AutoSize = true;
            this.LblNav.Location = new System.Drawing.Point(310, 243);
            this.LblNav.Name = "LblNav";
            this.LblNav.Size = new System.Drawing.Size(17, 25);
            this.LblNav.TabIndex = 4;
            this.LblNav.Text = " ";
            // 
            // BtnReculer1
            // 
            this.BtnReculer1.Location = new System.Drawing.Point(227, 229);
            this.BtnReculer1.Name = "BtnReculer1";
            this.BtnReculer1.Size = new System.Drawing.Size(50, 38);
            this.BtnReculer1.TabIndex = 3;
            this.BtnReculer1.Text = "<";
            this.BtnReculer1.UseVisualStyleBackColor = true;
            this.BtnReculer1.Click += new System.EventHandler(this.BtnReculer1_Click);
            // 
            // BtnAvancer1
            // 
            this.BtnAvancer1.Location = new System.Drawing.Point(354, 229);
            this.BtnAvancer1.Name = "BtnAvancer1";
            this.BtnAvancer1.Size = new System.Drawing.Size(47, 38);
            this.BtnAvancer1.TabIndex = 2;
            this.BtnAvancer1.Text = ">";
            this.BtnAvancer1.UseVisualStyleBackColor = true;
            this.BtnAvancer1.Click += new System.EventHandler(this.BtnAvancer1_Click);
            // 
            // BtnAllerDernier
            // 
            this.BtnAllerDernier.Location = new System.Drawing.Point(437, 229);
            this.BtnAllerDernier.Name = "BtnAllerDernier";
            this.BtnAllerDernier.Size = new System.Drawing.Size(46, 38);
            this.BtnAllerDernier.TabIndex = 1;
            this.BtnAllerDernier.Text = ">>";
            this.BtnAllerDernier.UseVisualStyleBackColor = true;
            this.BtnAllerDernier.Click += new System.EventHandler(this.BtnAllerDernier_Click);
            // 
            // BtnAllerPremier
            // 
            this.BtnAllerPremier.Location = new System.Drawing.Point(148, 229);
            this.BtnAllerPremier.Name = "BtnAllerPremier";
            this.BtnAllerPremier.Size = new System.Drawing.Size(46, 38);
            this.BtnAllerPremier.TabIndex = 0;
            this.BtnAllerPremier.Text = "<<";
            this.BtnAllerPremier.UseVisualStyleBackColor = true;
            this.BtnAllerPremier.Click += new System.EventHandler(this.BtnAllerPremier_Click);
            // 
            // GrpContactRendu
            // 
            this.GrpContactRendu.Controls.Add(this.DgvAfficherContact);
            this.GrpContactRendu.Location = new System.Drawing.Point(26, 328);
            this.GrpContactRendu.Name = "GrpContactRendu";
            this.GrpContactRendu.Size = new System.Drawing.Size(614, 193);
            this.GrpContactRendu.TabIndex = 1;
            this.GrpContactRendu.TabStop = false;
            this.GrpContactRendu.Text = "Contact avec les informateurs";
            // 
            // DgvAfficherContact
            // 
            this.DgvAfficherContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAfficherContact.Location = new System.Drawing.Point(11, 38);
            this.DgvAfficherContact.Name = "DgvAfficherContact";
            this.DgvAfficherContact.RowHeadersWidth = 62;
            this.DgvAfficherContact.RowTemplate.Height = 28;
            this.DgvAfficherContact.Size = new System.Drawing.Size(585, 149);
            this.DgvAfficherContact.TabIndex = 0;
            // 
            // GrpDepenses
            // 
            this.GrpDepenses.Controls.Add(this.DgvDepenses);
            this.GrpDepenses.Location = new System.Drawing.Point(646, 22);
            this.GrpDepenses.Name = "GrpDepenses";
            this.GrpDepenses.Size = new System.Drawing.Size(444, 256);
            this.GrpDepenses.TabIndex = 2;
            this.GrpDepenses.TabStop = false;
            this.GrpDepenses.Text = "Dépenses effectuées";
            // 
            // DgvDepenses
            // 
            this.DgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepenses.Location = new System.Drawing.Point(12, 31);
            this.DgvDepenses.Name = "DgvDepenses";
            this.DgvDepenses.RowHeadersWidth = 62;
            this.DgvDepenses.RowTemplate.Height = 28;
            this.DgvDepenses.Size = new System.Drawing.Size(426, 219);
            this.DgvDepenses.TabIndex = 0;
            // 
            // BtnEditerPdf
            // 
            this.BtnEditerPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEditerPdf.Location = new System.Drawing.Point(471, 557);
            this.BtnEditerPdf.Name = "BtnEditerPdf";
            this.BtnEditerPdf.Size = new System.Drawing.Size(151, 46);
            this.BtnEditerPdf.TabIndex = 3;
            this.BtnEditerPdf.Text = "Editer un PDF";
            this.BtnEditerPdf.UseVisualStyleBackColor = true;
            this.BtnEditerPdf.Click += new System.EventHandler(this.BtnEditerPdf_Click);
            // 
            // LblSommeContact
            // 
            this.LblSommeContact.AutoSize = true;
            this.LblSommeContact.Location = new System.Drawing.Point(32, 524);
            this.LblSommeContact.Name = "LblSommeContact";
            this.LblSommeContact.Size = new System.Drawing.Size(64, 25);
            this.LblSommeContact.TabIndex = 4;
            this.LblSommeContact.Text = "label1";
            // 
            // LblTotalDepense
            // 
            this.LblTotalDepense.AutoSize = true;
            this.LblTotalDepense.Location = new System.Drawing.Point(646, 281);
            this.LblTotalDepense.Name = "LblTotalDepense";
            this.LblTotalDepense.Size = new System.Drawing.Size(64, 25);
            this.LblTotalDepense.TabIndex = 5;
            this.LblTotalDepense.Text = "label2";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(974, 568);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(104, 35);
            this.BtnQuitter.TabIndex = 6;
            this.BtnQuitter.Text = "Retour";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlpCaptures);
            this.groupBox1.Location = new System.Drawing.Point(651, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilan des captures";
            // 
            // FlpCaptures
            // 
            this.FlpCaptures.AutoScroll = true;
            this.FlpCaptures.Controls.Add(this.LblInfo);
            this.FlpCaptures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpCaptures.Location = new System.Drawing.Point(3, 26);
            this.FlpCaptures.Name = "FlpCaptures";
            this.FlpCaptures.Size = new System.Drawing.Size(433, 164);
            this.FlpCaptures.TabIndex = 0;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(3, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(17, 25);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = " ";
            // 
            // GrpContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.LblTotalDepense);
            this.Controls.Add(this.LblSommeContact);
            this.Controls.Add(this.BtnEditerPdf);
            this.Controls.Add(this.GrpDepenses);
            this.Controls.Add(this.GrpContactRendu);
            this.Controls.Add(this.GrpJournal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GrpContact";
            this.Text = "JournalDeBord";
            this.Load += new System.EventHandler(this.GrpContact_Load);
            this.GrpJournal.ResumeLayout(false);
            this.GrpJournal.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.GrpContactRendu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfficherContact)).EndInit();
            this.GrpDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.FlpCaptures.ResumeLayout(false);
            this.FlpCaptures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpJournal;
        private System.Windows.Forms.GroupBox GrpContactRendu;
        private System.Windows.Forms.GroupBox GrpDepenses;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblNav;
        private System.Windows.Forms.Button BtnReculer1;
        private System.Windows.Forms.Button BtnAvancer1;
        private System.Windows.Forms.Button BtnAllerDernier;
        private System.Windows.Forms.Button BtnAllerPremier;
        private System.Windows.Forms.Button BtnEditerPdf;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblEvenement;
        private System.Windows.Forms.DataGridView DgvAfficherContact;
        private System.Windows.Forms.TextBox TxtNumeroEvenement;
        private System.Windows.Forms.DataGridView DgvDepenses;
        private System.Windows.Forms.Label LblSommeContact;
        private System.Windows.Forms.Label LblTotalDepense;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel FlpCaptures;
        private System.Windows.Forms.Label LblInfo;
    }
}