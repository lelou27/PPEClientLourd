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
            this.Title_RapVisite.Location = new System.Drawing.Point(382, 19);
            this.Title_RapVisite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title_RapVisite.Name = "Title_RapVisite";
            this.Title_RapVisite.Size = new System.Drawing.Size(154, 20);
            this.Title_RapVisite.TabIndex = 0;
            this.Title_RapVisite.Text = "Rapports de visite";
            // 
            // Practiciens
            // 
            this.Practiciens.AutoSize = true;
            this.Practiciens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practiciens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Practiciens.Location = new System.Drawing.Point(9, 116);
            this.Practiciens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Practiciens.Name = "Practiciens";
            this.Practiciens.Size = new System.Drawing.Size(64, 15);
            this.Practiciens.TabIndex = 2;
            this.Practiciens.Text = "Praticien";
            // 
            // DateRap
            // 
            this.DateRap.AutoSize = true;
            this.DateRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.DateRap.Location = new System.Drawing.Point(9, 159);
            this.DateRap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateRap.Name = "DateRap";
            this.DateRap.Size = new System.Drawing.Size(92, 15);
            this.DateRap.TabIndex = 3;
            this.DateRap.Text = "Date Rapport";
            // 
            // MotifVisite
            // 
            this.MotifVisite.AutoSize = true;
            this.MotifVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotifVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.MotifVisite.Location = new System.Drawing.Point(9, 201);
            this.MotifVisite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MotifVisite.Name = "MotifVisite";
            this.MotifVisite.Size = new System.Drawing.Size(78, 15);
            this.MotifVisite.TabIndex = 4;
            this.MotifVisite.Text = "Motif Visite";
            // 
            // BilanRap
            // 
            this.BilanRap.AutoSize = true;
            this.BilanRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilanRap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.BilanRap.Location = new System.Drawing.Point(16, 581);
            this.BilanRap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BilanRap.Name = "BilanRap";
            this.BilanRap.Size = new System.Drawing.Size(46, 15);
            this.BilanRap.TabIndex = 5;
            this.BilanRap.Text = "BILAN";
            // 
            // OffreEch
            // 
            this.OffreEch.AutoSize = true;
            this.OffreEch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffreEch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.OffreEch.Location = new System.Drawing.Point(491, 313);
            this.OffreEch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OffreEch.Name = "OffreEch";
            this.OffreEch.Size = new System.Drawing.Size(194, 15);
            this.OffreEch.TabIndex = 6;
            this.OffreEch.Text = "Offres échantillons présentés";
            // 
            // DateProVisite
            // 
            this.DateProVisite.AutoSize = true;
            this.DateProVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateProVisite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.DateProVisite.Location = new System.Drawing.Point(439, 157);
            this.DateProVisite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateProVisite.Name = "DateProVisite";
            this.DateProVisite.Size = new System.Drawing.Size(142, 15);
            this.DateProVisite.TabIndex = 7;
            this.DateProVisite.Text = "Date prochaine visite";
            this.DateProVisite.Visible = false;
            // 
            // textBox_BilanRap
            // 
            this.textBox_BilanRap.Location = new System.Drawing.Point(84, 580);
            this.textBox_BilanRap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BilanRap.Multiline = true;
            this.textBox_BilanRap.Name = "textBox_BilanRap";
            this.textBox_BilanRap.Size = new System.Drawing.Size(232, 154);
            this.textBox_BilanRap.TabIndex = 13;
            this.textBox_BilanRap.TextChanged += new System.EventHandler(this.textBox_BilanRap_TextChanged);
            // 
            // textBox_AutreMotif
            // 
            this.textBox_AutreMotif.Location = new System.Drawing.Point(494, 208);
            this.textBox_AutreMotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_AutreMotif.Multiline = true;
            this.textBox_AutreMotif.Name = "textBox_AutreMotif";
            this.textBox_AutreMotif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AutreMotif.Size = new System.Drawing.Size(419, 41);
            this.textBox_AutreMotif.TabIndex = 14;
            this.textBox_AutreMotif.Visible = false;
            this.textBox_AutreMotif.TextChanged += new System.EventHandler(this.textBox_AutreMotif_TextChanged);
            // 
            // AutreMotif
            // 
            this.AutreMotif.AutoSize = true;
            this.AutreMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutreMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.AutreMotif.Location = new System.Drawing.Point(454, 209);
            this.AutreMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AutreMotif.Name = "AutreMotif";
            this.AutreMotif.Size = new System.Drawing.Size(40, 15);
            this.AutreMotif.TabIndex = 15;
            this.AutreMotif.Text = "Autre";
            this.AutreMotif.Visible = false;
            // 
            // comboBox_Practiciens
            // 
            this.comboBox_Practiciens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Practiciens.FormattingEnabled = true;
            this.comboBox_Practiciens.Location = new System.Drawing.Point(84, 115);
            this.comboBox_Practiciens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Practiciens.Name = "comboBox_Practiciens";
            this.comboBox_Practiciens.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Practiciens.TabIndex = 16;
            this.comboBox_Practiciens.SelectedIndexChanged += new System.EventHandler(this.comboBox_Practiciens_SelectedIndexChanged);
            // 
            // Btn_detailsPracticiens
            // 
            this.Btn_detailsPracticiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_detailsPracticiens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.Btn_detailsPracticiens.Location = new System.Drawing.Point(237, 115);
            this.Btn_detailsPracticiens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_detailsPracticiens.Name = "Btn_detailsPracticiens";
            this.Btn_detailsPracticiens.Size = new System.Drawing.Size(56, 19);
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
            this.comboBox_Motif.Location = new System.Drawing.Point(98, 200);
            this.comboBox_Motif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Motif.Name = "comboBox_Motif";
            this.comboBox_Motif.Size = new System.Drawing.Size(134, 21);
            this.comboBox_Motif.TabIndex = 18;
            this.comboBox_Motif.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Motif_SelectedIndexChanged);
            // 
            // NewRDV
            // 
            this.NewRDV.AutoSize = true;
            this.NewRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.NewRDV.Location = new System.Drawing.Point(438, 114);
            this.NewRDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewRDV.Name = "NewRDV";
            this.NewRDV.Size = new System.Drawing.Size(210, 15);
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
            this.comboBox_NewRDV.Location = new System.Drawing.Point(648, 112);
            this.comboBox_NewRDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_NewRDV.Name = "comboBox_NewRDV";
            this.comboBox_NewRDV.Size = new System.Drawing.Size(92, 21);
            this.comboBox_NewRDV.TabIndex = 20;
            this.comboBox_NewRDV.SelectedIndexChanged += new System.EventHandler(this.ComboBox_NewRDV_SelectedIndexChanged);
            // 
            // button_Creer
            // 
            this.button_Creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.button_Creer.Location = new System.Drawing.Point(695, 664);
            this.button_Creer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Creer.Name = "button_Creer";
            this.button_Creer.Size = new System.Drawing.Size(80, 30);
            this.button_Creer.TabIndex = 23;
            this.button_Creer.Text = "Créer";
            this.button_Creer.UseVisualStyleBackColor = true;
            this.button_Creer.Click += new System.EventHandler(this.button_Nouveau_Click);
            // 
            // button_Fermer
            // 
            this.button_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.button_Fermer.Location = new System.Drawing.Point(806, 664);
            this.button_Fermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Fermer.Name = "button_Fermer";
            this.button_Fermer.Size = new System.Drawing.Size(80, 30);
            this.button_Fermer.TabIndex = 24;
            this.button_Fermer.Text = "Fermer";
            this.button_Fermer.UseVisualStyleBackColor = true;
            this.button_Fermer.Click += new System.EventHandler(this.button_Fermer_Click_1);
            // 
            // dateTimePicker_DateRap
            // 
            this.dateTimePicker_DateRap.Location = new System.Drawing.Point(116, 159);
            this.dateTimePicker_DateRap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_DateRap.Name = "dateTimePicker_DateRap";
            this.dateTimePicker_DateRap.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_DateRap.TabIndex = 25;
            this.dateTimePicker_DateRap.ValueChanged += new System.EventHandler(this.dateTimePicker_DateRap_ValueChanged);
            // 
            // dateTimePicker_DateProVisite
            // 
            this.dateTimePicker_DateProVisite.Location = new System.Drawing.Point(632, 160);
            this.dateTimePicker_DateProVisite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_DateProVisite.Name = "dateTimePicker_DateProVisite";
            this.dateTimePicker_DateProVisite.Size = new System.Drawing.Size(188, 20);
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
            this.dataGridView_echantillonPresente.Location = new System.Drawing.Point(627, 331);
            this.dataGridView_echantillonPresente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_echantillonPresente.Name = "dataGridView_echantillonPresente";
            this.dataGridView_echantillonPresente.RowTemplate.Height = 24;
            this.dataGridView_echantillonPresente.Size = new System.Drawing.Size(272, 216);
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
            this.label_errPratricien.Location = new System.Drawing.Point(15, 93);
            this.label_errPratricien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errPratricien.Name = "label_errPratricien";
            this.label_errPratricien.Size = new System.Drawing.Size(0, 15);
            this.label_errPratricien.TabIndex = 29;
            // 
            // label_DateRap
            // 
            this.label_DateRap.AutoSize = true;
            this.label_DateRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateRap.ForeColor = System.Drawing.Color.Red;
            this.label_DateRap.Location = new System.Drawing.Point(15, 144);
            this.label_DateRap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DateRap.Name = "label_DateRap";
            this.label_DateRap.Size = new System.Drawing.Size(0, 15);
            this.label_DateRap.TabIndex = 30;
            // 
            // label_datepro
            // 
            this.label_datepro.AutoSize = true;
            this.label_datepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datepro.ForeColor = System.Drawing.Color.Red;
            this.label_datepro.Location = new System.Drawing.Point(439, 142);
            this.label_datepro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_datepro.Name = "label_datepro";
            this.label_datepro.Size = new System.Drawing.Size(0, 15);
            this.label_datepro.TabIndex = 31;
            // 
            // label_motifvisite
            // 
            this.label_motifvisite.AutoSize = true;
            this.label_motifvisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_motifvisite.ForeColor = System.Drawing.Color.Red;
            this.label_motifvisite.Location = new System.Drawing.Point(15, 179);
            this.label_motifvisite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_motifvisite.Name = "label_motifvisite";
            this.label_motifvisite.Size = new System.Drawing.Size(0, 15);
            this.label_motifvisite.TabIndex = 32;
            // 
            // label_autremotif
            // 
            this.label_autremotif.AutoSize = true;
            this.label_autremotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_autremotif.ForeColor = System.Drawing.Color.Red;
            this.label_autremotif.Location = new System.Drawing.Point(491, 184);
            this.label_autremotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_autremotif.Name = "label_autremotif";
            this.label_autremotif.Size = new System.Drawing.Size(0, 15);
            this.label_autremotif.TabIndex = 33;
            // 
            // label_bilan
            // 
            this.label_bilan.AutoSize = true;
            this.label_bilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bilan.ForeColor = System.Drawing.Color.Red;
            this.label_bilan.Location = new System.Drawing.Point(22, 558);
            this.label_bilan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_bilan.Name = "label_bilan";
            this.label_bilan.Size = new System.Drawing.Size(0, 15);
            this.label_bilan.TabIndex = 34;
            // 
            // label_errEchanPresente
            // 
            this.label_errEchanPresente.AutoSize = true;
            this.label_errEchanPresente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errEchanPresente.ForeColor = System.Drawing.Color.Red;
            this.label_errEchanPresente.Location = new System.Drawing.Point(473, 353);
            this.label_errEchanPresente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errEchanPresente.MaximumSize = new System.Drawing.Size(131, 147);
            this.label_errEchanPresente.Name = "label_errEchanPresente";
            this.label_errEchanPresente.Size = new System.Drawing.Size(0, 15);
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
            this.comboBox_presenceconcurrence.Location = new System.Drawing.Point(215, 238);
            this.comboBox_presenceconcurrence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_presenceconcurrence.Name = "comboBox_presenceconcurrence";
            this.comboBox_presenceconcurrence.Size = new System.Drawing.Size(92, 21);
            this.comboBox_presenceconcurrence.TabIndex = 37;
            // 
            // label_presenceconcurrence
            // 
            this.label_presenceconcurrence.AutoSize = true;
            this.label_presenceconcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_presenceconcurrence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label_presenceconcurrence.Location = new System.Drawing.Point(9, 239);
            this.label_presenceconcurrence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_presenceconcurrence.Name = "label_presenceconcurrence";
            this.label_presenceconcurrence.Size = new System.Drawing.Size(159, 15);
            this.label_presenceconcurrence.TabIndex = 36;
            this.label_presenceconcurrence.Text = "Présence Concurence ?";
            // 
            // label_connaissancePraticien
            // 
            this.label_connaissancePraticien.AutoSize = true;
            this.label_connaissancePraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connaissancePraticien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label_connaissancePraticien.Location = new System.Drawing.Point(9, 282);
            this.label_connaissancePraticien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_connaissancePraticien.Name = "label_connaissancePraticien";
            this.label_connaissancePraticien.Size = new System.Drawing.Size(157, 15);
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
            this.comboBox_connaissancePraticien.Location = new System.Drawing.Point(215, 282);
            this.comboBox_connaissancePraticien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_connaissancePraticien.Name = "comboBox_connaissancePraticien";
            this.comboBox_connaissancePraticien.Size = new System.Drawing.Size(92, 21);
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
            this.comboBox_confianceLabo.Location = new System.Drawing.Point(698, 280);
            this.comboBox_confianceLabo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_confianceLabo.Name = "comboBox_confianceLabo";
            this.comboBox_confianceLabo.Size = new System.Drawing.Size(92, 21);
            this.comboBox_confianceLabo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(491, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Confiance Labo";
            // 
            // label_errechanOffert
            // 
            this.label_errechanOffert.AutoSize = true;
            this.label_errechanOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errechanOffert.ForeColor = System.Drawing.Color.Red;
            this.label_errechanOffert.Location = new System.Drawing.Point(28, 353);
            this.label_errechanOffert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errechanOffert.MaximumSize = new System.Drawing.Size(131, 147);
            this.label_errechanOffert.Name = "label_errechanOffert";
            this.label_errechanOffert.Size = new System.Drawing.Size(0, 15);
            this.label_errechanOffert.TabIndex = 44;
            // 
            // dataGridView_echantillonOffert
            // 
            this.dataGridView_echantillonOffert.AllowUserToDeleteRows = false;
            this.dataGridView_echantillonOffert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_echantillonOffert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_echantillonOffert.Location = new System.Drawing.Point(182, 331);
            this.dataGridView_echantillonOffert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_echantillonOffert.Name = "dataGridView_echantillonOffert";
            this.dataGridView_echantillonOffert.RowTemplate.Height = 24;
            this.dataGridView_echantillonOffert.Size = new System.Drawing.Size(272, 216);
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
            this.label_echanOffert.Location = new System.Drawing.Point(9, 313);
            this.label_echanOffert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_echanOffert.Name = "label_echanOffert";
            this.label_echanOffert.Size = new System.Drawing.Size(164, 15);
            this.label_echanOffert.TabIndex = 42;
            this.label_echanOffert.Text = "Offres échantillons offert";
            // 
            // rapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(163)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(999, 749);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

