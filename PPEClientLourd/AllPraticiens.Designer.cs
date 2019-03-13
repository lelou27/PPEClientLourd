namespace PPEClientLourd
{
    partial class AllPraticiens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPraticiens));
            this.dgv_praticiens = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefnotoriete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_praticiens
            // 
            this.dgv_praticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_praticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.Cp,
            this.Ville,
            this.Coefnotoriete,
            this.Libelle});
            this.dgv_praticiens.Location = new System.Drawing.Point(0, 0);
            this.dgv_praticiens.Name = "dgv_praticiens";
            this.dgv_praticiens.Size = new System.Drawing.Size(860, 396);
            this.dgv_praticiens.TabIndex = 0;
            this.dgv_praticiens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numéro";
            this.Numero.Name = "Numero";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Cp
            // 
            this.Cp.HeaderText = "Code postal";
            this.Cp.Name = "Cp";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // Coefnotoriete
            // 
            this.Coefnotoriete.HeaderText = "Coefficient de notoriété";
            this.Coefnotoriete.Name = "Coefnotoriete";
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libellé";
            this.Libelle.Name = "Libelle";
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(769, 402);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(91, 36);
            this.Retour.TabIndex = 1;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // AllPraticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.dgv_praticiens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllPraticiens";
            this.Text = "Praticiens";
            this.Load += new System.EventHandler(this.AllPraticiens_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_praticiens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_praticiens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefnotoriete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.Button Retour;
    }
}