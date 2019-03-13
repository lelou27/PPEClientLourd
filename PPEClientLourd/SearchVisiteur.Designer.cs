namespace PPEClientLourd
{
    partial class SearchVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVisiteur));
            this.cmbx_visiteurs = new System.Windows.Forms.ComboBox();
            this.lbl_nomVisiteur = new System.Windows.Forms.Label();
            this.btn_showInformations = new System.Windows.Forms.Button();
            this.lbl_errorVisitor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbx_visiteurs
            // 
            this.cmbx_visiteurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_visiteurs.FormattingEnabled = true;
            this.cmbx_visiteurs.Location = new System.Drawing.Point(63, 56);
            this.cmbx_visiteurs.Name = "cmbx_visiteurs";
            this.cmbx_visiteurs.Size = new System.Drawing.Size(237, 21);
            this.cmbx_visiteurs.TabIndex = 0;
            // 
            // lbl_nomVisiteur
            // 
            this.lbl_nomVisiteur.AutoSize = true;
            this.lbl_nomVisiteur.Location = new System.Drawing.Point(153, 27);
            this.lbl_nomVisiteur.Name = "lbl_nomVisiteur";
            this.lbl_nomVisiteur.Size = new System.Drawing.Size(80, 13);
            this.lbl_nomVisiteur.TabIndex = 1;
            this.lbl_nomVisiteur.Text = "Nom du visiteur";
            // 
            // btn_showInformations
            // 
            this.btn_showInformations.Location = new System.Drawing.Point(137, 126);
            this.btn_showInformations.Name = "btn_showInformations";
            this.btn_showInformations.Size = new System.Drawing.Size(118, 23);
            this.btn_showInformations.TabIndex = 2;
            this.btn_showInformations.Text = "&Voir les informations";
            this.btn_showInformations.UseVisualStyleBackColor = true;
            this.btn_showInformations.Click += new System.EventHandler(this.btn_showInformations_Click);
            // 
            // lbl_errorVisitor
            // 
            this.lbl_errorVisitor.AutoSize = true;
            this.lbl_errorVisitor.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorVisitor.Location = new System.Drawing.Point(167, 89);
            this.lbl_errorVisitor.Name = "lbl_errorVisitor";
            this.lbl_errorVisitor.Size = new System.Drawing.Size(0, 13);
            this.lbl_errorVisitor.TabIndex = 3;
            // 
            // SearchVisiteur
            // 
            this.AcceptButton = this.btn_showInformations;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 190);
            this.Controls.Add(this.lbl_errorVisitor);
            this.Controls.Add(this.btn_showInformations);
            this.Controls.Add(this.lbl_nomVisiteur);
            this.Controls.Add(this.cmbx_visiteurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchVisiteur";
            this.Text = "Rechercher un visiteur";
            this.Load += new System.EventHandler(this.SearchVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_visiteurs;
        private System.Windows.Forms.Label lbl_nomVisiteur;
        private System.Windows.Forms.Button btn_showInformations;
        private System.Windows.Forms.Label lbl_errorVisitor;
    }
}