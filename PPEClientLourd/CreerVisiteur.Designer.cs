namespace PPEClientLourd
{
    partial class CreerVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_matricule = new System.Windows.Forms.TextBox();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.txb_prenom = new System.Windows.Forms.TextBox();
            this.txb_adresse = new System.Windows.Forms.TextBox();
            this.txb_cp = new System.Windows.Forms.TextBox();
            this.txb_ville = new System.Windows.Forms.TextBox();
            this.dttp_embauche = new System.Windows.Forms.DateTimePicker();
            this.cmbx_labo = new System.Windows.Forms.ComboBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.lbl_error_matricule = new System.Windows.Forms.Label();
            this.lbl_error_labo = new System.Windows.Forms.Label();
            this.lbl_error_ville = new System.Windows.Forms.Label();
            this.lbl_error_cp = new System.Windows.Forms.Label();
            this.lbl_error_adresse = new System.Windows.Forms.Label();
            this.lbl_error_prenom = new System.Windows.Forms.Label();
            this.lbl_error_nom = new System.Windows.Forms.Label();
            this.lbl_error_general = new System.Windows.Forms.Label();
            this.cb_responsable = new System.Windows.Forms.CheckBox();
            this.cbx_secteur = new System.Windows.Forms.ComboBox();
            this.lbl_secteur = new System.Windows.Forms.Label();
            this.cb_delegue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Postal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date d\'embauche :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Labo :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Prénom :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nom : ";
            // 
            // txb_matricule
            // 
            this.txb_matricule.Location = new System.Drawing.Point(116, 50);
            this.txb_matricule.Name = "txb_matricule";
            this.txb_matricule.Size = new System.Drawing.Size(214, 20);
            this.txb_matricule.TabIndex = 11;
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(116, 108);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(214, 20);
            this.txb_nom.TabIndex = 12;
            // 
            // txb_prenom
            // 
            this.txb_prenom.Location = new System.Drawing.Point(116, 171);
            this.txb_prenom.Name = "txb_prenom";
            this.txb_prenom.Size = new System.Drawing.Size(214, 20);
            this.txb_prenom.TabIndex = 13;
            // 
            // txb_adresse
            // 
            this.txb_adresse.Location = new System.Drawing.Point(116, 221);
            this.txb_adresse.Name = "txb_adresse";
            this.txb_adresse.Size = new System.Drawing.Size(214, 20);
            this.txb_adresse.TabIndex = 14;
            // 
            // txb_cp
            // 
            this.txb_cp.Location = new System.Drawing.Point(116, 282);
            this.txb_cp.Name = "txb_cp";
            this.txb_cp.Size = new System.Drawing.Size(97, 20);
            this.txb_cp.TabIndex = 15;
            // 
            // txb_ville
            // 
            this.txb_ville.Location = new System.Drawing.Point(395, 50);
            this.txb_ville.Name = "txb_ville";
            this.txb_ville.Size = new System.Drawing.Size(234, 20);
            this.txb_ville.TabIndex = 16;
            // 
            // dttp_embauche
            // 
            this.dttp_embauche.Location = new System.Drawing.Point(395, 111);
            this.dttp_embauche.Name = "dttp_embauche";
            this.dttp_embauche.Size = new System.Drawing.Size(200, 20);
            this.dttp_embauche.TabIndex = 17;
            // 
            // cmbx_labo
            // 
            this.cmbx_labo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_labo.FormattingEnabled = true;
            this.cmbx_labo.Location = new System.Drawing.Point(400, 152);
            this.cmbx_labo.Name = "cmbx_labo";
            this.cmbx_labo.Size = new System.Drawing.Size(195, 21);
            this.cmbx_labo.TabIndex = 18;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(539, 315);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 19;
            this.btn_valider.Text = "&Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_retour.Location = new System.Drawing.Point(448, 315);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 20;
            this.btn_retour.Text = "&Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // lbl_error_matricule
            // 
            this.lbl_error_matricule.AutoSize = true;
            this.lbl_error_matricule.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_matricule.Location = new System.Drawing.Point(130, 28);
            this.lbl_error_matricule.Name = "lbl_error_matricule";
            this.lbl_error_matricule.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_matricule.TabIndex = 21;
            // 
            // lbl_error_labo
            // 
            this.lbl_error_labo.AutoSize = true;
            this.lbl_error_labo.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_labo.Location = new System.Drawing.Point(407, 178);
            this.lbl_error_labo.Name = "lbl_error_labo";
            this.lbl_error_labo.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_labo.TabIndex = 22;
            // 
            // lbl_error_ville
            // 
            this.lbl_error_ville.AutoSize = true;
            this.lbl_error_ville.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_ville.Location = new System.Drawing.Point(408, 28);
            this.lbl_error_ville.Name = "lbl_error_ville";
            this.lbl_error_ville.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_ville.TabIndex = 23;
            // 
            // lbl_error_cp
            // 
            this.lbl_error_cp.AutoSize = true;
            this.lbl_error_cp.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_cp.Location = new System.Drawing.Point(130, 266);
            this.lbl_error_cp.Name = "lbl_error_cp";
            this.lbl_error_cp.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_cp.TabIndex = 24;
            // 
            // lbl_error_adresse
            // 
            this.lbl_error_adresse.AutoSize = true;
            this.lbl_error_adresse.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_adresse.Location = new System.Drawing.Point(130, 205);
            this.lbl_error_adresse.Name = "lbl_error_adresse";
            this.lbl_error_adresse.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_adresse.TabIndex = 25;
            // 
            // lbl_error_prenom
            // 
            this.lbl_error_prenom.AutoSize = true;
            this.lbl_error_prenom.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_prenom.Location = new System.Drawing.Point(130, 155);
            this.lbl_error_prenom.Name = "lbl_error_prenom";
            this.lbl_error_prenom.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_prenom.TabIndex = 26;
            // 
            // lbl_error_nom
            // 
            this.lbl_error_nom.AutoSize = true;
            this.lbl_error_nom.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_nom.Location = new System.Drawing.Point(130, 92);
            this.lbl_error_nom.Name = "lbl_error_nom";
            this.lbl_error_nom.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_nom.TabIndex = 27;
            // 
            // lbl_error_general
            // 
            this.lbl_error_general.AutoSize = true;
            this.lbl_error_general.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_general.Location = new System.Drawing.Point(113, 320);
            this.lbl_error_general.Name = "lbl_error_general";
            this.lbl_error_general.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_general.TabIndex = 28;
            // 
            // cb_responsable
            // 
            this.cb_responsable.AutoSize = true;
            this.cb_responsable.Location = new System.Drawing.Point(400, 224);
            this.cb_responsable.Name = "cb_responsable";
            this.cb_responsable.Size = new System.Drawing.Size(148, 17);
            this.cb_responsable.TabIndex = 29;
            this.cb_responsable.Text = "Collaborateur responsable";
            this.cb_responsable.UseVisualStyleBackColor = true;
            this.cb_responsable.CheckedChanged += new System.EventHandler(this.cb_responsable_CheckedChanged);
            // 
            // cbx_secteur
            // 
            this.cbx_secteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_secteur.FormattingEnabled = true;
            this.cbx_secteur.Location = new System.Drawing.Point(411, 263);
            this.cbx_secteur.Name = "cbx_secteur";
            this.cbx_secteur.Size = new System.Drawing.Size(195, 21);
            this.cbx_secteur.TabIndex = 30;
            // 
            // lbl_secteur
            // 
            this.lbl_secteur.AutoSize = true;
            this.lbl_secteur.Location = new System.Drawing.Point(357, 266);
            this.lbl_secteur.Name = "lbl_secteur";
            this.lbl_secteur.Size = new System.Drawing.Size(50, 13);
            this.lbl_secteur.TabIndex = 31;
            this.lbl_secteur.Text = "Secteur :";
            // 
            // cb_delegue
            // 
            this.cb_delegue.AutoSize = true;
            this.cb_delegue.Location = new System.Drawing.Point(400, 201);
            this.cb_delegue.Name = "cb_delegue";
            this.cb_delegue.Size = new System.Drawing.Size(129, 17);
            this.cb_delegue.TabIndex = 32;
            this.cb_delegue.Text = "Collaborateur délégué";
            this.cb_delegue.UseVisualStyleBackColor = true;
            this.cb_delegue.CheckedChanged += new System.EventHandler(this.cb_delegue_CheckedChanged);
            // 
            // CreerVisiteur
            // 
            this.AcceptButton = this.btn_valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_retour;
            this.ClientSize = new System.Drawing.Size(659, 375);
            this.Controls.Add(this.cb_delegue);
            this.Controls.Add(this.lbl_secteur);
            this.Controls.Add(this.cbx_secteur);
            this.Controls.Add(this.cb_responsable);
            this.Controls.Add(this.lbl_error_general);
            this.Controls.Add(this.lbl_error_nom);
            this.Controls.Add(this.lbl_error_prenom);
            this.Controls.Add(this.lbl_error_adresse);
            this.Controls.Add(this.lbl_error_cp);
            this.Controls.Add(this.lbl_error_ville);
            this.Controls.Add(this.lbl_error_labo);
            this.Controls.Add(this.lbl_error_matricule);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.cmbx_labo);
            this.Controls.Add(this.dttp_embauche);
            this.Controls.Add(this.txb_ville);
            this.Controls.Add(this.txb_cp);
            this.Controls.Add(this.txb_adresse);
            this.Controls.Add(this.txb_prenom);
            this.Controls.Add(this.txb_nom);
            this.Controls.Add(this.txb_matricule);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreerVisiteur";
            this.Text = "Ajouter un visiteur";
            this.Load += new System.EventHandler(this.CreerVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_matricule;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.TextBox txb_prenom;
        private System.Windows.Forms.TextBox txb_adresse;
        private System.Windows.Forms.TextBox txb_cp;
        private System.Windows.Forms.TextBox txb_ville;
        private System.Windows.Forms.DateTimePicker dttp_embauche;
        private System.Windows.Forms.ComboBox cmbx_labo;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label lbl_error_matricule;
        private System.Windows.Forms.Label lbl_error_labo;
        private System.Windows.Forms.Label lbl_error_ville;
        private System.Windows.Forms.Label lbl_error_cp;
        private System.Windows.Forms.Label lbl_error_adresse;
        private System.Windows.Forms.Label lbl_error_prenom;
        private System.Windows.Forms.Label lbl_error_nom;
        private System.Windows.Forms.Label lbl_error_general;
        private System.Windows.Forms.CheckBox cb_responsable;
        private System.Windows.Forms.ComboBox cbx_secteur;
        private System.Windows.Forms.Label lbl_secteur;
        private System.Windows.Forms.CheckBox cb_delegue;
    }
}