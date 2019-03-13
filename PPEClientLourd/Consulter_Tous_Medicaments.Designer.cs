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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composition_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depot_legal_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(180, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Consulter_Tous_Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Consulter_Tous_Medicaments";
            this.Text = "Consulter_Tous_Medicaments";
            this.Load += new System.EventHandler(this.Consulter_Tous_Medicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composition_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depot_legal_med;
    }
}