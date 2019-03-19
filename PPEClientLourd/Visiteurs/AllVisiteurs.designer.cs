namespace PPEClientLourd
{
    partial class AllVisiteurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllVisiteurs));
            this.dgv_visiteurs = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmbauche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_visiteurs
            // 
            this.dgv_visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visiteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prenom,
            this.DateEmbauche});
            this.dgv_visiteurs.Location = new System.Drawing.Point(12, 12);
            this.dgv_visiteurs.Name = "dgv_visiteurs";
            this.dgv_visiteurs.ReadOnly = true;
            this.dgv_visiteurs.Size = new System.Drawing.Size(510, 342);
            this.dgv_visiteurs.TabIndex = 0;
            this.dgv_visiteurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_visiteurs_CellContentClick);
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // DateEmbauche
            // 
            this.DateEmbauche.HeaderText = "Date d\'embauche";
            this.DateEmbauche.Name = "DateEmbauche";
            this.DateEmbauche.ReadOnly = true;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(447, 372);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "&Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // AllVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 407);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_visiteurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllVisiteurs";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.AllVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visiteurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_visiteurs;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmbauche;
    }
}