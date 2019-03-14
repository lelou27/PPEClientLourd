namespace PPEClientLourd
{
    partial class ShowAllRaports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllRaports));
            this.dgv_rapports = new System.Windows.Forms.DataGridView();
            this.Collaborateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RapDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RapMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Praticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_noResults = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rapports
            // 
            this.dgv_rapports.AllowUserToAddRows = false;
            this.dgv_rapports.AllowUserToDeleteRows = false;
            this.dgv_rapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rapports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Collaborateur,
            this.NoRapport,
            this.RapDate,
            this.RapMotif,
            this.Praticien});
            this.dgv_rapports.Location = new System.Drawing.Point(12, 42);
            this.dgv_rapports.Name = "dgv_rapports";
            this.dgv_rapports.ReadOnly = true;
            this.dgv_rapports.Size = new System.Drawing.Size(604, 444);
            this.dgv_rapports.TabIndex = 0;
            this.dgv_rapports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rapports_CellContentClick);
            // 
            // Collaborateur
            // 
            this.Collaborateur.HeaderText = "Collaborateur";
            this.Collaborateur.Name = "Collaborateur";
            this.Collaborateur.ReadOnly = true;
            // 
            // NoRapport
            // 
            this.NoRapport.HeaderText = "Numéro de rapport";
            this.NoRapport.Name = "NoRapport";
            this.NoRapport.ReadOnly = true;
            // 
            // RapDate
            // 
            this.RapDate.HeaderText = "Date du rapport";
            this.RapDate.Name = "RapDate";
            this.RapDate.ReadOnly = true;
            // 
            // RapMotif
            // 
            this.RapMotif.HeaderText = "Motif de rapport";
            this.RapMotif.Name = "RapMotif";
            this.RapMotif.ReadOnly = true;
            // 
            // Praticien
            // 
            this.Praticien.HeaderText = "Praticien visité";
            this.Praticien.Name = "Praticien";
            this.Praticien.ReadOnly = true;
            // 
            // lbl_noResults
            // 
            this.lbl_noResults.AutoSize = true;
            this.lbl_noResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noResults.Location = new System.Drawing.Point(22, 12);
            this.lbl_noResults.Name = "lbl_noResults";
            this.lbl_noResults.Size = new System.Drawing.Size(0, 20);
            this.lbl_noResults.TabIndex = 1;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(541, 503);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "&Retour";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ShowAllRaports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 538);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_noResults);
            this.Controls.Add(this.dgv_rapports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllRaports";
            this.Text = "Voir tout les rapports";
            this.Load += new System.EventHandler(this.ShowAllRaports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rapports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collaborateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn RapDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RapMotif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Praticien;
        private System.Windows.Forms.Label lbl_noResults;
        private System.Windows.Forms.Button btn_return;
    }
}