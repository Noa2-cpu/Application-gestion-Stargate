namespace SAE24
{
    partial class DetailMissions
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
            this.LblTitre = new System.Windows.Forms.Label();
            this.PbAfficherPlanete = new System.Windows.Forms.PictureBox();
            this.LblDepart = new System.Windows.Forms.Label();
            this.LblRetour = new System.Windows.Forms.Label();
            this.LblBudget = new System.Windows.Forms.Label();
            this.LblDépenses = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RtbFeuilleRoute = new System.Windows.Forms.RichTextBox();
            this.GrpEscouade = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrpObjectifCapture = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbAfficherPlanete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GrpEscouade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(163, 57);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(85, 29);
            this.LblTitre.TabIndex = 0;
            this.LblTitre.Text = "label1";
            // 
            // PbAfficherPlanete
            // 
            this.PbAfficherPlanete.Location = new System.Drawing.Point(14, 5);
            this.PbAfficherPlanete.Name = "PbAfficherPlanete";
            this.PbAfficherPlanete.Size = new System.Drawing.Size(143, 127);
            this.PbAfficherPlanete.TabIndex = 1;
            this.PbAfficherPlanete.TabStop = false;
            // 
            // LblDepart
            // 
            this.LblDepart.AutoSize = true;
            this.LblDepart.Location = new System.Drawing.Point(9, 165);
            this.LblDepart.Name = "LblDepart";
            this.LblDepart.Size = new System.Drawing.Size(156, 25);
            this.LblDepart.TabIndex = 2;
            this.LblDepart.Text = "Date de départ : ";
            // 
            // LblRetour
            // 
            this.LblRetour.AutoSize = true;
            this.LblRetour.Location = new System.Drawing.Point(7, 207);
            this.LblRetour.Name = "LblRetour";
            this.LblRetour.Size = new System.Drawing.Size(216, 25);
            this.LblRetour.TabIndex = 3;
            this.LblRetour.Text = "Date de retour prévue : ";
            // 
            // LblBudget
            // 
            this.LblBudget.AutoSize = true;
            this.LblBudget.Location = new System.Drawing.Point(404, 165);
            this.LblBudget.Name = "LblBudget";
            this.LblBudget.Size = new System.Drawing.Size(90, 25);
            this.LblBudget.TabIndex = 4;
            this.LblBudget.Text = "Budget : ";
            // 
            // LblDépenses
            // 
            this.LblDépenses.AutoSize = true;
            this.LblDépenses.Location = new System.Drawing.Point(404, 207);
            this.LblDépenses.Name = "LblDépenses";
            this.LblDépenses.Size = new System.Drawing.Size(224, 25);
            this.LblDépenses.TabIndex = 5;
            this.LblDépenses.Text = "Solde après dépenses : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RtbFeuilleRoute);
            this.groupBox1.Location = new System.Drawing.Point(14, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feuille de route";
            // 
            // RtbFeuilleRoute
            // 
            this.RtbFeuilleRoute.Location = new System.Drawing.Point(23, 29);
            this.RtbFeuilleRoute.Name = "RtbFeuilleRoute";
            this.RtbFeuilleRoute.ShortcutsEnabled = false;
            this.RtbFeuilleRoute.Size = new System.Drawing.Size(636, 150);
            this.RtbFeuilleRoute.TabIndex = 0;
            this.RtbFeuilleRoute.Text = "";
            this.RtbFeuilleRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbFeuilleRoute_KeyPress);
            // 
            // GrpEscouade
            // 
            this.GrpEscouade.Controls.Add(this.panel1);
            this.GrpEscouade.Location = new System.Drawing.Point(14, 437);
            this.GrpEscouade.Name = "GrpEscouade";
            this.GrpEscouade.Size = new System.Drawing.Size(688, 183);
            this.GrpEscouade.TabIndex = 7;
            this.GrpEscouade.TabStop = false;
            this.GrpEscouade.Text = "Membres de l\'escouade";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 154);
            this.panel1.TabIndex = 0;
            // 
            // GrpObjectifCapture
            // 
            this.GrpObjectifCapture.Location = new System.Drawing.Point(11, 625);
            this.GrpObjectifCapture.Name = "GrpObjectifCapture";
            this.GrpObjectifCapture.Size = new System.Drawing.Size(557, 96);
            this.GrpObjectifCapture.TabIndex = 8;
            this.GrpObjectifCapture.TabStop = false;
            this.GrpObjectifCapture.Text = "Objectifs de capture";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(750, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(418, 183);
            this.dataGridView1.TabIndex = 9;
            // 
            // DetailMissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrpObjectifCapture);
            this.Controls.Add(this.GrpEscouade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblDépenses);
            this.Controls.Add(this.LblBudget);
            this.Controls.Add(this.LblRetour);
            this.Controls.Add(this.LblDepart);
            this.Controls.Add(this.PbAfficherPlanete);
            this.Controls.Add(this.LblTitre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DetailMissions";
            this.Text = "Detail de la mission";
            this.Load += new System.EventHandler(this.DetailMissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbAfficherPlanete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GrpEscouade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.PictureBox PbAfficherPlanete;
        private System.Windows.Forms.Label LblDepart;
        private System.Windows.Forms.Label LblRetour;
        private System.Windows.Forms.Label LblBudget;
        private System.Windows.Forms.Label LblDépenses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RtbFeuilleRoute;
        private System.Windows.Forms.GroupBox GrpEscouade;
        private System.Windows.Forms.GroupBox GrpObjectifCapture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}