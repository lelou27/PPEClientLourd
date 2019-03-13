namespace PPEClientLourd
{
    partial class Consulter_Tous_Medicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulter_Tous_Medicaments));
            this.dgv_allMedicaments = new System.Windows.Forms.DataGridView();
            this.Nom_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composition_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depot_legal_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.NomMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_depotLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allMedicaments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_allMedicaments
            // 
            this.dgv_allMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomMedicament,
            this.famille,
            this.composition,
            this.med_depotLegal});
            this.dgv_allMedicaments.Location = new System.Drawing.Point(11, 11);
            this.dgv_allMedicaments.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_allMedicaments.Name = "dgv_allMedicaments";
            this.dgv_allMedicaments.Size = new System.Drawing.Size(828, 363);
            this.dgv_allMedicaments.TabIndex = 0;
            this.dgv_allMedicaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom_med
            // 
            this.Nom_med.HeaderText = "Nom";
            this.Nom_med.Name = "Nom_med";
            // 
            // Code_med
            // 
            this.Code_med.HeaderText = "Code";
            this.Code_med.Name = "Code_med";
            // 
            // Composition_med
            // 
            this.Composition_med.HeaderText = "Composition";
            this.Composition_med.Name = "Composition_med";
            // 
            // Depot_legal_med
            // 
            this.Depot_legal_med.HeaderText = "Dépôt légal";
            this.Depot_legal_med.Name = "Depot_legal_med";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(763, 379);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "&Fermer";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // NomMedicament
            // 
            this.NomMedicament.HeaderText = "Nom du médicament";
            this.NomMedicament.MinimumWidth = 150;
            this.NomMedicament.Name = "NomMedicament";
            this.NomMedicament.ReadOnly = true;
            this.NomMedicament.Width = 150;
            // 
            // famille
            // 
            this.famille.HeaderText = "Famille";
            this.famille.MinimumWidth = 200;
            this.famille.Name = "famille";
            this.famille.ReadOnly = true;
            this.famille.Width = 200;
            // 
            // composition
            // 
            this.composition.HeaderText = "Composition";
            this.composition.MinimumWidth = 300;
            this.composition.Name = "composition";
            this.composition.ReadOnly = true;
            this.composition.Width = 300;
            // 
            // med_depotLegal
            // 
            this.med_depotLegal.HeaderText = "Dépot Légal";
            this.med_depotLegal.MinimumWidth = 100;
            this.med_depotLegal.Name = "med_depotLegal";
            this.med_depotLegal.ReadOnly = true;
            // 
            // Consulter_Tous_Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 414);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_allMedicaments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulter_Tous_Medicaments";
            this.Text = "Tout les médicaments";
            this.Load += new System.EventHandler(this.Consulter_Tous_Medicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allMedicaments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_allMedicaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composition_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depot_legal_med;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_depotLegal;
    }
}