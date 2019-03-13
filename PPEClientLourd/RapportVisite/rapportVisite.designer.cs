namespace PPEClientLourd
{
    partial class rapportVisite
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapportVisite));
            this.Title_RapVisite = new System.Windows.Forms.Label();
            this.Practiciens = new System.Windows.Forms.Label();
            this.DateRap = new System.Windows.Forms.Label();
            this.MotifVisite = new System.Windows.Forms.Label();
            this.BilanRap = new System.Windows.Forms.Label();
            this.OffreEch = new System.Windows.Forms.Label();
            this.DateProVisite = new System.Windows.Forms.Label();
            this.textBox_BilanRap = new System.Windows.Forms.TextBox();
            this.textBox_AutreMotif = new System.Windows.Forms.TextBox();
            this.AutreMotif = new System.Windows.Forms.Label();
            this.comboBox_Practiciens = new System.Windows.Forms.ComboBox();
            this.Btn_detailsPracticiens = new System.Windows.Forms.Button();
            this.comboBox_Motif = new System.Windows.Forms.ComboBox();
            this.NewRDV = new System.Windows.Forms.Label();
            this.comboBox_NewRDV = new System.Windows.Forms.ComboBox();
            this.button_Creer = new System.Windows.Forms.Button();
            this.button_Fermer = new System.Windows.Forms.Button();
            this.dateTimePicker_DateRap = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DateProVisite = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_echantillonPresente = new System.Windows.Forms.DataGridView();
            this.Medicaments = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_errPratricien = new System.Windows.Forms.Label();
            this.label_DateRap = new System.Windows.Forms.Label();
            this.label_datepro = new System.Windows.Forms.Label();
            this.label_motifvisite = new System.Windows.Forms.Label();
            this.label_autremotif = new System.Windows.Forms.Label();
            this.label_bilan = new System.Windows.Forms.Label();
            this.label_errEchanPresente = new System.Windows.Forms.Label();
            this.comboBox_presenceconcurrence = new System.Windows.Forms.ComboBox();
            this.label_presenceconcurrence = new System.Windows.Forms.Label();
            this.label_connaissancePraticien = new System.Windows.Forms.Label();
            this.comboBox_connaissancePraticien = new System.Windows.Forms.ComboBox();
            this.comboBox_confianceLabo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_errechanOffert = new System.Windows.Forms.Label();
            this.dataGridView_echantillonOffert = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_echanOffert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonPresente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonOffert)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_RapVisite
            // 
            this.Title_RapVisite.AutoSize = true;
            this.Title_RapVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_RapVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Title_RapVisite.Location = new System.Drawing.Point(509, 23);
            this.Title_RapVisite.Name = "Title_RapVisite";
            this.Title_RapVisite.Size = new System.Drawing.Size(184, 25);
            this.Title_RapVisite.TabIndex = 0;
            this.Title_RapVisite.Text = "Rapports de visite";
            // 
            // Practiciens
            // 
            this.Practiciens.AutoSize = true;
            this.Practiciens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practiciens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Practiciens.Location = new System.Drawing.Point(12, 143);
            this.Practiciens.Name = "Practiciens";
            this.Practiciens.Size = new System.Drawing.Size(74, 18);
            this.Practiciens.TabIndex = 2;
            this.Practiciens.Text = "Praticien";
            // 
            // DateRap
            // 
            this.DateRap.AutoSize = true;
            this.DateRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.DateRap.Location = new System.Drawing.Point(12, 196);
            this.DateRap.Name = "DateRap";
            this.DateRap.Size = new System.Drawing.Size(108, 18);
            this.DateRap.TabIndex = 3;
            this.DateRap.Text = "Date Rapport";
            // 
            // MotifVisite
            // 
            this.MotifVisite.AutoSize = true;
            this.MotifVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotifVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.MotifVisite.Location = new System.Drawing.Point(12, 247);
            this.MotifVisite.Name = "MotifVisite";
            this.MotifVisite.Size = new System.Drawing.Size(92, 18);
            this.MotifVisite.TabIndex = 4;
            this.MotifVisite.Text = "Motif Visite";
            // 
            // BilanRap
            // 
            this.BilanRap.AutoSize = true;
            this.BilanRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilanRap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.BilanRap.Location = new System.Drawing.Point(21, 715);
            this.BilanRap.Name = "BilanRap";
            this.BilanRap.Size = new System.Drawing.Size(54, 18);
            this.BilanRap.TabIndex = 5;
            this.BilanRap.Text = "BILAN";
            // 
            // OffreEch
            // 
            this.OffreEch.AutoSize = true;
            this.OffreEch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffreEch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.OffreEch.Location = new System.Drawing.Point(655, 385);
            this.OffreEch.Name = "OffreEch";
            this.OffreEch.Size = new System.Drawing.Size(229, 18);
            this.OffreEch.TabIndex = 6;
            this.OffreEch.Text = "Offres échantillons présentés";
            // 
            // DateProVisite
            // 
            this.DateProVisite.AutoSize = true;
            this.DateProVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateProVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.DateProVisite.Location = new System.Drawing.Point(585, 193);
            this.DateProVisite.Name = "DateProVisite";
            this.DateProVisite.Size = new System.Drawing.Size(166, 18);
            this.DateProVisite.TabIndex = 7;
            this.DateProVisite.Text = "Date prochaine visite";
            this.DateProVisite.Visible = false;
            // 
            // textBox_BilanRap
            // 
            this.textBox_BilanRap.Location = new System.Drawing.Point(112, 714);
            this.textBox_BilanRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BilanRap.Multiline = true;
            this.textBox_BilanRap.Name = "textBox_BilanRap";
            this.textBox_BilanRap.Size = new System.Drawing.Size(308, 189);
            this.textBox_BilanRap.TabIndex = 13;
            this.textBox_BilanRap.TextChanged += new System.EventHandler(this.textBox_BilanRap_TextChanged);
            // 
            // textBox_AutreMotif
            // 
            this.textBox_AutreMotif.Location = new System.Drawing.Point(659, 256);
            this.textBox_AutreMotif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AutreMotif.Multiline = true;
            this.textBox_AutreMotif.Name = "textBox_AutreMotif";
            this.textBox_AutreMotif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AutreMotif.Size = new System.Drawing.Size(557, 50);
            this.textBox_AutreMotif.TabIndex = 14;
            this.textBox_AutreMotif.Visible = false;
            this.textBox_AutreMotif.TextChanged += new System.EventHandler(this.textBox_AutreMotif_TextChanged);
            // 
            // AutreMotif
            // 
            this.AutreMotif.AutoSize = true;
            this.AutreMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AutreMotif.Location = new System.Drawing.Point(605, 257);
            this.AutreMotif.Name = "AutreMotif";
            this.AutreMotif.Size = new System.Drawing.Size(47, 18);
            this.AutreMotif.TabIndex = 15;
            this.AutreMotif.Text = "Autre";
            this.AutreMotif.Visible = false;
            // 
            // comboBox_Practiciens
            // 
            this.comboBox_Practiciens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Practiciens.FormattingEnabled = true;
            this.comboBox_Practiciens.Location = new System.Drawing.Point(112, 142);
            this.comboBox_Practiciens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Practiciens.Name = "comboBox_Practiciens";
            this.comboBox_Practiciens.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Practiciens.TabIndex = 16;
            this.comboBox_Practiciens.SelectedIndexChanged += new System.EventHandler(this.comboBox_Practiciens_SelectedIndexChanged);
            // 
            // Btn_detailsPracticiens
            // 
            this.Btn_detailsPracticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_detailsPracticiens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Btn_detailsPracticiens.Location = new System.Drawing.Point(316, 142);
            this.Btn_detailsPracticiens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_detailsPracticiens.Name = "Btn_detailsPracticiens";
            this.Btn_detailsPracticiens.Size = new System.Drawing.Size(75, 23);
            this.Btn_detailsPracticiens.TabIndex = 17;
            this.Btn_detailsPracticiens.Text = "Détails";
            this.Btn_detailsPracticiens.UseVisualStyleBackColor = true;
            this.Btn_detailsPracticiens.Visible = false;
            this.Btn_detailsPracticiens.Click += new System.EventHandler(this.Btn_detailsPracticiens_Click);
            // 
            // comboBox_Motif
            // 
            this.comboBox_Motif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Motif.FormattingEnabled = true;
            this.comboBox_Motif.Items.AddRange(new object[] {
            "Actualisation annuelle",
            "Baisse activité",
            "Périodicité",
            "Rapport Annuel",
            "Autre"});
            this.comboBox_Motif.Location = new System.Drawing.Point(131, 246);
            this.comboBox_Motif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Motif.Name = "comboBox_Motif";
            this.comboBox_Motif.Size = new System.Drawing.Size(177, 24);
            this.comboBox_Motif.TabIndex = 18;
            this.comboBox_Motif.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Motif_SelectedIndexChanged);
            // 
            // NewRDV
            // 
            this.NewRDV.AutoSize = true;
            this.NewRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.NewRDV.Location = new System.Drawing.Point(584, 140);
            this.NewRDV.Name = "NewRDV";
            this.NewRDV.Size = new System.Drawing.Size(247, 18);
            this.NewRDV.TabIndex = 19;
            this.NewRDV.Text = "Prendre nouveau rendez-vous ?";
            // 
            // comboBox_NewRDV
            // 
            this.comboBox_NewRDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NewRDV.FormattingEnabled = true;
            this.comboBox_NewRDV.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.comboBox_NewRDV.Location = new System.Drawing.Point(864, 138);
            this.comboBox_NewRDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_NewRDV.Name = "comboBox_NewRDV";
            this.comboBox_NewRDV.Size = new System.Drawing.Size(121, 24);
            this.comboBox_NewRDV.TabIndex = 20;
            this.comboBox_NewRDV.SelectedIndexChanged += new System.EventHandler(this.ComboBox_NewRDV_SelectedIndexChanged);
            // 
            // button_Creer
            // 
            this.button_Creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.button_Creer.Location = new System.Drawing.Point(927, 817);
            this.button_Creer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Creer.Name = "button_Creer";
            this.button_Creer.Size = new System.Drawing.Size(107, 37);
            this.button_Creer.TabIndex = 23;
            this.button_Creer.Text = "Créer";
            this.button_Creer.UseVisualStyleBackColor = true;
            this.button_Creer.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Fermer
            // 
            this.button_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.button_Fermer.Location = new System.Drawing.Point(1075, 817);
            this.button_Fermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Fermer.Name = "button_Fermer";
            this.button_Fermer.Size = new System.Drawing.Size(107, 37);
            this.button_Fermer.TabIndex = 24;
            this.button_Fermer.Text = "Fermer";
            this.button_Fermer.UseVisualStyleBackColor = true;
            this.button_Fermer.Click += new System.EventHandler(this.button_Fermer_Click_1);
            // 
            // dateTimePicker_DateRap
            // 
            this.dateTimePicker_DateRap.Location = new System.Drawing.Point(155, 196);
            this.dateTimePicker_DateRap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_DateRap.Name = "dateTimePicker_DateRap";
            this.dateTimePicker_DateRap.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker_DateRap.TabIndex = 25;
            this.dateTimePicker_DateRap.ValueChanged += new System.EventHandler(this.dateTimePicker_DateRap_ValueChanged);
            // 
            // dateTimePicker_DateProVisite
            // 
            this.dateTimePicker_DateProVisite.Location = new System.Drawing.Point(843, 197);
            this.dateTimePicker_DateProVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_DateProVisite.Name = "dateTimePicker_DateProVisite";
            this.dateTimePicker_DateProVisite.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker_DateProVisite.TabIndex = 26;
            this.dateTimePicker_DateProVisite.Visible = false;
            this.dateTimePicker_DateProVisite.ValueChanged += new System.EventHandler(this.dateTimePicker_DateProVisite_ValueChanged);
            // 
            // dataGridView_echantillonPresente
            // 
            this.dataGridView_echantillonPresente.AllowUserToDeleteRows = false;
            this.dataGridView_echantillonPresente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_echantillonPresente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicaments,
            this.Nombre});
            this.dataGridView_echantillonPresente.Location = new System.Drawing.Point(836, 407);
            this.dataGridView_echantillonPresente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_echantillonPresente.Name = "dataGridView_echantillonPresente";
            this.dataGridView_echantillonPresente.RowTemplate.Height = 24;
            this.dataGridView_echantillonPresente.Size = new System.Drawing.Size(363, 266);
            this.dataGridView_echantillonPresente.TabIndex = 27;
            // 
            // Medicaments
            // 
            this.Medicaments.Frozen = true;
            this.Medicaments.HeaderText = "Médicament";
            this.Medicaments.Name = "Medicaments";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label_errPratricien
            // 
            this.label_errPratricien.AutoSize = true;
            this.label_errPratricien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errPratricien.ForeColor = System.Drawing.Color.Red;
            this.label_errPratricien.Location = new System.Drawing.Point(20, 114);
            this.label_errPratricien.Name = "label_errPratricien";
            this.label_errPratricien.Size = new System.Drawing.Size(0, 18);
            this.label_errPratricien.TabIndex = 29;
            // 
            // label_DateRap
            // 
            this.label_DateRap.AutoSize = true;
            this.label_DateRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateRap.ForeColor = System.Drawing.Color.Red;
            this.label_DateRap.Location = new System.Drawing.Point(20, 177);
            this.label_DateRap.Name = "label_DateRap";
            this.label_DateRap.Size = new System.Drawing.Size(0, 18);
            this.label_DateRap.TabIndex = 30;
            // 
            // label_datepro
            // 
            this.label_datepro.AutoSize = true;
            this.label_datepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datepro.ForeColor = System.Drawing.Color.Red;
            this.label_datepro.Location = new System.Drawing.Point(585, 175);
            this.label_datepro.Name = "label_datepro";
            this.label_datepro.Size = new System.Drawing.Size(0, 18);
            this.label_datepro.TabIndex = 31;
            // 
            // label_motifvisite
            // 
            this.label_motifvisite.AutoSize = true;
            this.label_motifvisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motifvisite.ForeColor = System.Drawing.Color.Red;
            this.label_motifvisite.Location = new System.Drawing.Point(20, 220);
            this.label_motifvisite.Name = "label_motifvisite";
            this.label_motifvisite.Size = new System.Drawing.Size(0, 18);
            this.label_motifvisite.TabIndex = 32;
            // 
            // label_autremotif
            // 
            this.label_autremotif.AutoSize = true;
            this.label_autremotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_autremotif.ForeColor = System.Drawing.Color.Red;
            this.label_autremotif.Location = new System.Drawing.Point(655, 226);
            this.label_autremotif.Name = "label_autremotif";
            this.label_autremotif.Size = new System.Drawing.Size(0, 18);
            this.label_autremotif.TabIndex = 33;
            // 
            // label_bilan
            // 
            this.label_bilan.AutoSize = true;
            this.label_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bilan.ForeColor = System.Drawing.Color.Red;
            this.label_bilan.Location = new System.Drawing.Point(29, 687);
            this.label_bilan.Name = "label_bilan";
            this.label_bilan.Size = new System.Drawing.Size(0, 18);
            this.label_bilan.TabIndex = 34;
            // 
            // label_errEchanPresente
            // 
            this.label_errEchanPresente.AutoSize = true;
            this.label_errEchanPresente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errEchanPresente.ForeColor = System.Drawing.Color.Red;
            this.label_errEchanPresente.Location = new System.Drawing.Point(631, 434);
            this.label_errEchanPresente.MaximumSize = new System.Drawing.Size(175, 181);
            this.label_errEchanPresente.Name = "label_errEchanPresente";
            this.label_errEchanPresente.Size = new System.Drawing.Size(0, 18);
            this.label_errEchanPresente.TabIndex = 35;
            // 
            // comboBox_presenceconcurrence
            // 
            this.comboBox_presenceconcurrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_presenceconcurrence.FormattingEnabled = true;
            this.comboBox_presenceconcurrence.Items.AddRange(new object[] {
            "Non",
            "Oui",
            "Je ne sais pas"});
            this.comboBox_presenceconcurrence.Location = new System.Drawing.Point(287, 293);
            this.comboBox_presenceconcurrence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_presenceconcurrence.Name = "comboBox_presenceconcurrence";
            this.comboBox_presenceconcurrence.Size = new System.Drawing.Size(121, 24);
            this.comboBox_presenceconcurrence.TabIndex = 37;
            // 
            // label_presenceconcurrence
            // 
            this.label_presenceconcurrence.AutoSize = true;
            this.label_presenceconcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_presenceconcurrence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label_presenceconcurrence.Location = new System.Drawing.Point(12, 294);
            this.label_presenceconcurrence.Name = "label_presenceconcurrence";
            this.label_presenceconcurrence.Size = new System.Drawing.Size(189, 18);
            this.label_presenceconcurrence.TabIndex = 36;
            this.label_presenceconcurrence.Text = "Présence Concurence ?";
            // 
            // label_connaissancePraticien
            // 
            this.label_connaissancePraticien.AutoSize = true;
            this.label_connaissancePraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connaissancePraticien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label_connaissancePraticien.Location = new System.Drawing.Point(12, 347);
            this.label_connaissancePraticien.Name = "label_connaissancePraticien";
            this.label_connaissancePraticien.Size = new System.Drawing.Size(184, 18);
            this.label_connaissancePraticien.TabIndex = 38;
            this.label_connaissancePraticien.Text = "Connaissance praticien";
            // 
            // comboBox_connaissancePraticien
            // 
            this.comboBox_connaissancePraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_connaissancePraticien.FormattingEnabled = true;
            this.comboBox_connaissancePraticien.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Je ne sais pas"});
            this.comboBox_connaissancePraticien.Location = new System.Drawing.Point(287, 347);
            this.comboBox_connaissancePraticien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_connaissancePraticien.Name = "comboBox_connaissancePraticien";
            this.comboBox_connaissancePraticien.Size = new System.Drawing.Size(121, 24);
            this.comboBox_connaissancePraticien.TabIndex = 39;
            // 
            // comboBox_confianceLabo
            // 
            this.comboBox_confianceLabo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_confianceLabo.FormattingEnabled = true;
            this.comboBox_confianceLabo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Je ne sais pas"});
            this.comboBox_confianceLabo.Location = new System.Drawing.Point(931, 345);
            this.comboBox_confianceLabo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_confianceLabo.Name = "comboBox_confianceLabo";
            this.comboBox_confianceLabo.Size = new System.Drawing.Size(121, 24);
            this.comboBox_confianceLabo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(655, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Confiance Labo";
            // 
            // label_errechanOffert
            // 
            this.label_errechanOffert.AutoSize = true;
            this.label_errechanOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errechanOffert.ForeColor = System.Drawing.Color.Red;
            this.label_errechanOffert.Location = new System.Drawing.Point(37, 434);
            this.label_errechanOffert.MaximumSize = new System.Drawing.Size(175, 181);
            this.label_errechanOffert.Name = "label_errechanOffert";
            this.label_errechanOffert.Size = new System.Drawing.Size(0, 18);
            this.label_errechanOffert.TabIndex = 44;
            // 
            // dataGridView_echantillonOffert
            // 
            this.dataGridView_echantillonOffert.AllowUserToDeleteRows = false;
            this.dataGridView_echantillonOffert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_echantillonOffert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_echantillonOffert.Location = new System.Drawing.Point(243, 407);
            this.dataGridView_echantillonOffert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_echantillonOffert.Name = "dataGridView_echantillonOffert";
            this.dataGridView_echantillonOffert.RowTemplate.Height = 24;
            this.dataGridView_echantillonOffert.Size = new System.Drawing.Size(363, 266);
            this.dataGridView_echantillonOffert.TabIndex = 43;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.Frozen = true;
            this.dataGridViewComboBoxColumn1.HeaderText = "Médicament";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label_echanOffert
            // 
            this.label_echanOffert.AutoSize = true;
            this.label_echanOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_echanOffert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label_echanOffert.Location = new System.Drawing.Point(12, 385);
            this.label_echanOffert.Name = "label_echanOffert";
            this.label_echanOffert.Size = new System.Drawing.Size(195, 18);
            this.label_echanOffert.TabIndex = 42;
            this.label_echanOffert.Text = "Offres échantillons offert";
            // 
            // rapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1332, 922);
            this.Controls.Add(this.label_errechanOffert);
            this.Controls.Add(this.dataGridView_echantillonOffert);
            this.Controls.Add(this.label_echanOffert);
            this.Controls.Add(this.comboBox_confianceLabo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_connaissancePraticien);
            this.Controls.Add(this.label_connaissancePraticien);
            this.Controls.Add(this.comboBox_presenceconcurrence);
            this.Controls.Add(this.label_presenceconcurrence);
            this.Controls.Add(this.label_errEchanPresente);
            this.Controls.Add(this.label_bilan);
            this.Controls.Add(this.label_autremotif);
            this.Controls.Add(this.label_motifvisite);
            this.Controls.Add(this.label_datepro);
            this.Controls.Add(this.label_DateRap);
            this.Controls.Add(this.label_errPratricien);
            this.Controls.Add(this.dataGridView_echantillonPresente);
            this.Controls.Add(this.dateTimePicker_DateProVisite);
            this.Controls.Add(this.dateTimePicker_DateRap);
            this.Controls.Add(this.button_Fermer);
            this.Controls.Add(this.button_Creer);
            this.Controls.Add(this.comboBox_NewRDV);
            this.Controls.Add(this.NewRDV);
            this.Controls.Add(this.comboBox_Motif);
            this.Controls.Add(this.Btn_detailsPracticiens);
            this.Controls.Add(this.comboBox_Practiciens);
            this.Controls.Add(this.AutreMotif);
            this.Controls.Add(this.textBox_AutreMotif);
            this.Controls.Add(this.textBox_BilanRap);
            this.Controls.Add(this.DateProVisite);
            this.Controls.Add(this.OffreEch);
            this.Controls.Add(this.BilanRap);
            this.Controls.Add(this.MotifVisite);
            this.Controls.Add(this.DateRap);
            this.Controls.Add(this.Practiciens);
            this.Controls.Add(this.Title_RapVisite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rapportVisite";
            this.Text = "RapVisite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonPresente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonOffert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_RapVisite;
        private System.Windows.Forms.Label Practiciens;
        private System.Windows.Forms.Label DateRap;
        private System.Windows.Forms.Label MotifVisite;
        private System.Windows.Forms.Label BilanRap;
        private System.Windows.Forms.Label OffreEch;
        private System.Windows.Forms.Label DateProVisite;
        private System.Windows.Forms.TextBox textBox_BilanRap;
        private System.Windows.Forms.TextBox textBox_AutreMotif;
        private System.Windows.Forms.Label AutreMotif;
        private System.Windows.Forms.ComboBox comboBox_Practiciens;
        private System.Windows.Forms.Button Btn_detailsPracticiens;
        private System.Windows.Forms.ComboBox comboBox_Motif;
        private System.Windows.Forms.Label NewRDV;
        private System.Windows.Forms.ComboBox comboBox_NewRDV;
        private System.Windows.Forms.Button button_Creer;
        private System.Windows.Forms.Button button_Fermer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateRap;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateProVisite;
        private System.Windows.Forms.DataGridView dataGridView_echantillonPresente;
        private System.Windows.Forms.Label label_errPratricien;
        private System.Windows.Forms.Label label_DateRap;
        private System.Windows.Forms.Label label_datepro;
        private System.Windows.Forms.Label label_motifvisite;
        private System.Windows.Forms.Label label_autremotif;
        private System.Windows.Forms.Label label_bilan;
        private System.Windows.Forms.DataGridViewComboBoxColumn Medicaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label label_errEchanPresente;
        private System.Windows.Forms.ComboBox comboBox_presenceconcurrence;
        private System.Windows.Forms.Label label_presenceconcurrence;
        private System.Windows.Forms.Label label_connaissancePraticien;
        private System.Windows.Forms.ComboBox comboBox_connaissancePraticien;
        private System.Windows.Forms.ComboBox comboBox_confianceLabo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_errechanOffert;
        private System.Windows.Forms.DataGridView dataGridView_echantillonOffert;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label_echanOffert;
    }
}

