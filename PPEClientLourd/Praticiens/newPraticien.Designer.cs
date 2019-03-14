namespace PPEClientLourd.Praticiens
{
    partial class newPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPraticien));
            this.lbl_praNom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_adresse = new System.Windows.Forms.Label();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.lbl_coefNotoriete = new System.Windows.Forms.Label();
            this.lbl_praType = new System.Windows.Forms.Label();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.txb_prenom = new System.Windows.Forms.TextBox();
            this.txb_adresse = new System.Windows.Forms.TextBox();
            this.txb_ville = new System.Windows.Forms.TextBox();
            this.cbx_typePraticien = new System.Windows.Forms.ComboBox();
            this.txb_coefNotoriete = new System.Windows.Forms.MaskedTextBox();
            this.txb_cp = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_praNom
            // 
            this.lbl_praNom.AutoSize = true;
            this.lbl_praNom.Location = new System.Drawing.Point(36, 38);
            this.lbl_praNom.Name = "lbl_praNom";
            this.lbl_praNom.Size = new System.Drawing.Size(35, 13);
            this.lbl_praNom.TabIndex = 0;
            this.lbl_praNom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(36, 82);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 1;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_adresse
            // 
            this.lbl_adresse.AutoSize = true;
            this.lbl_adresse.Location = new System.Drawing.Point(36, 125);
            this.lbl_adresse.Name = "lbl_adresse";
            this.lbl_adresse.Size = new System.Drawing.Size(51, 13);
            this.lbl_adresse.TabIndex = 2;
            this.lbl_adresse.Text = "Adresse :";
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(36, 171);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(69, 13);
            this.lbl_cp.TabIndex = 3;
            this.lbl_cp.Text = "Code postal :";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(36, 216);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(32, 13);
            this.lbl_ville.TabIndex = 4;
            this.lbl_ville.Text = "Ville :";
            // 
            // lbl_coefNotoriete
            // 
            this.lbl_coefNotoriete.AutoSize = true;
            this.lbl_coefNotoriete.Location = new System.Drawing.Point(36, 265);
            this.lbl_coefNotoriete.Name = "lbl_coefNotoriete";
            this.lbl_coefNotoriete.Size = new System.Drawing.Size(122, 13);
            this.lbl_coefNotoriete.TabIndex = 5;
            this.lbl_coefNotoriete.Text = "Coefficient de notoriété :";
            // 
            // lbl_praType
            // 
            this.lbl_praType.AutoSize = true;
            this.lbl_praType.Location = new System.Drawing.Point(36, 325);
            this.lbl_praType.Name = "lbl_praType";
            this.lbl_praType.Size = new System.Drawing.Size(95, 13);
            this.lbl_praType.TabIndex = 6;
            this.lbl_praType.Text = "Type de praticien :";
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(167, 38);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(229, 20);
            this.txb_nom.TabIndex = 7;
            // 
            // txb_prenom
            // 
            this.txb_prenom.Location = new System.Drawing.Point(167, 79);
            this.txb_prenom.Name = "txb_prenom";
            this.txb_prenom.Size = new System.Drawing.Size(229, 20);
            this.txb_prenom.TabIndex = 8;
            // 
            // txb_adresse
            // 
            this.txb_adresse.Location = new System.Drawing.Point(167, 125);
            this.txb_adresse.Name = "txb_adresse";
            this.txb_adresse.Size = new System.Drawing.Size(229, 20);
            this.txb_adresse.TabIndex = 9;
            // 
            // txb_ville
            // 
            this.txb_ville.Location = new System.Drawing.Point(167, 209);
            this.txb_ville.Name = "txb_ville";
            this.txb_ville.Size = new System.Drawing.Size(229, 20);
            this.txb_ville.TabIndex = 11;
            // 
            // cbx_typePraticien
            // 
            this.cbx_typePraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_typePraticien.FormattingEnabled = true;
            this.cbx_typePraticien.Location = new System.Drawing.Point(167, 322);
            this.cbx_typePraticien.Name = "cbx_typePraticien";
            this.cbx_typePraticien.Size = new System.Drawing.Size(229, 21);
            this.cbx_typePraticien.TabIndex = 13;
            // 
            // txb_coefNotoriete
            // 
            this.txb_coefNotoriete.Location = new System.Drawing.Point(167, 262);
            this.txb_coefNotoriete.Mask = "00.00";
            this.txb_coefNotoriete.Name = "txb_coefNotoriete";
            this.txb_coefNotoriete.Size = new System.Drawing.Size(72, 20);
            this.txb_coefNotoriete.TabIndex = 14;
            // 
            // txb_cp
            // 
            this.txb_cp.Location = new System.Drawing.Point(167, 168);
            this.txb_cp.Mask = "00000";
            this.txb_cp.Name = "txb_cp";
            this.txb_cp.Size = new System.Drawing.Size(72, 20);
            this.txb_cp.TabIndex = 15;
            // 
            // newPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.txb_cp);
            this.Controls.Add(this.txb_coefNotoriete);
            this.Controls.Add(this.cbx_typePraticien);
            this.Controls.Add(this.txb_ville);
            this.Controls.Add(this.txb_adresse);
            this.Controls.Add(this.txb_prenom);
            this.Controls.Add(this.txb_nom);
            this.Controls.Add(this.lbl_praType);
            this.Controls.Add(this.lbl_coefNotoriete);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.lbl_adresse);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_praNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newPraticien";
            this.Text = "Créer un praticien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_praNom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_adresse;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label lbl_coefNotoriete;
        private System.Windows.Forms.Label lbl_praType;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.TextBox txb_prenom;
        private System.Windows.Forms.TextBox txb_adresse;
        private System.Windows.Forms.TextBox txb_ville;
        private System.Windows.Forms.ComboBox cbx_typePraticien;
        private System.Windows.Forms.MaskedTextBox txb_coefNotoriete;
        private System.Windows.Forms.MaskedTextBox txb_cp;
    }
}