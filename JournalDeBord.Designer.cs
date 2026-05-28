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
            this.BtnEditerPdf = new System.Windows.Forms.Button();
            this.TxtNumeroEvenement = new System.Windows.Forms.TextBox();
            this.DgvDepenses = new System.Windows.Forms.DataGridView();
            this.GrpJournal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.GrpContactRendu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfficherContact)).BeginInit();
            this.GrpDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepenses)).BeginInit();
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
            this.GrpJournal.Size = new System.Drawing.Size(740, 284);
            this.GrpJournal.TabIndex = 0;
            this.GrpJournal.TabStop = false;
            this.GrpJournal.Text = "Evénement du journal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.LblEvenement);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 116);
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
            this.LblNav.Location = new System.Drawing.Point(365, 243);
            this.LblNav.Name = "LblNav";
            this.LblNav.Size = new System.Drawing.Size(17, 25);
            this.LblNav.TabIndex = 4;
            this.LblNav.Text = " ";
            // 
            // BtnReculer1
            // 
            this.BtnReculer1.Location = new System.Drawing.Point(282, 229);
            this.BtnReculer1.Name = "BtnReculer1";
            this.BtnReculer1.Size = new System.Drawing.Size(50, 38);
            this.BtnReculer1.TabIndex = 3;
            this.BtnReculer1.Text = "<";
            this.BtnReculer1.UseVisualStyleBackColor = true;
            this.BtnReculer1.Click += new System.EventHandler(this.BtnReculer1_Click);
            // 
            // BtnAvancer1
            // 
            this.BtnAvancer1.Location = new System.Drawing.Point(409, 229);
            this.BtnAvancer1.Name = "BtnAvancer1";
            this.BtnAvancer1.Size = new System.Drawing.Size(47, 38);
            this.BtnAvancer1.TabIndex = 2;
            this.BtnAvancer1.Text = ">";
            this.BtnAvancer1.UseVisualStyleBackColor = true;
            this.BtnAvancer1.Click += new System.EventHandler(this.BtnAvancer1_Click);
            // 
            // BtnAllerDernier
            // 
            this.BtnAllerDernier.Location = new System.Drawing.Point(492, 229);
            this.BtnAllerDernier.Name = "BtnAllerDernier";
            this.BtnAllerDernier.Size = new System.Drawing.Size(46, 38);
            this.BtnAllerDernier.TabIndex = 1;
            this.BtnAllerDernier.Text = ">>";
            this.BtnAllerDernier.UseVisualStyleBackColor = true;
            this.BtnAllerDernier.Click += new System.EventHandler(this.BtnAllerDernier_Click);
            // 
            // BtnAllerPremier
            // 
            this.BtnAllerPremier.Location = new System.Drawing.Point(203, 229);
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
            this.GrpContactRendu.Size = new System.Drawing.Size(740, 193);
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
            this.DgvAfficherContact.Size = new System.Drawing.Size(728, 154);
            this.DgvAfficherContact.TabIndex = 0;
            // 
            // GrpDepenses
            // 
            this.GrpDepenses.Controls.Add(this.DgvDepenses);
            this.GrpDepenses.Location = new System.Drawing.Point(802, 22);
            this.GrpDepenses.Name = "GrpDepenses";
            this.GrpDepenses.Size = new System.Drawing.Size(444, 354);
            this.GrpDepenses.TabIndex = 2;
            this.GrpDepenses.TabStop = false;
            this.GrpDepenses.Text = "Dépenses effectuées";
            // 
            // BtnEditerPdf
            // 
            this.BtnEditerPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnEditerPdf.Location = new System.Drawing.Point(876, 382);
            this.BtnEditerPdf.Name = "BtnEditerPdf";
            this.BtnEditerPdf.Size = new System.Drawing.Size(344, 230);
            this.BtnEditerPdf.TabIndex = 3;
            this.BtnEditerPdf.Text = "BOUTON NOLAN PDF";
            this.BtnEditerPdf.UseVisualStyleBackColor = true;
            // 
            // TxtNumeroEvenement
            // 
            this.TxtNumeroEvenement.Location = new System.Drawing.Point(338, 240);
            this.TxtNumeroEvenement.Name = "TxtNumeroEvenement";
            this.TxtNumeroEvenement.Size = new System.Drawing.Size(33, 30);
            this.TxtNumeroEvenement.TabIndex = 7;
            this.TxtNumeroEvenement.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtNumeroEvenement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroEvenement_KeyPress);
            // 
            // DgvDepenses
            // 
            this.DgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepenses.Location = new System.Drawing.Point(12, 31);
            this.DgvDepenses.Name = "DgvDepenses";
            this.DgvDepenses.RowHeadersWidth = 62;
            this.DgvDepenses.RowTemplate.Height = 28;
            this.DgvDepenses.Size = new System.Drawing.Size(431, 313);
            this.DgvDepenses.TabIndex = 0;
            // 
            // GrpContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 739);
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
            this.ResumeLayout(false);

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
    }
}