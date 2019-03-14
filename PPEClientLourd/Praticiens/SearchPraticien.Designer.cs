namespace PPEClientLourd
{
    partial class SearchPraticien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPraticien));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_praticien = new System.Windows.Forms.ComboBox();
            this.btn_showInformations = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez sélectionner un praticien";
            // 
            // cbx_praticien
            // 
            this.cbx_praticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_praticien.FormattingEnabled = true;
            this.cbx_praticien.Location = new System.Drawing.Point(89, 110);
            this.cbx_praticien.Name = "cbx_praticien";
            this.cbx_praticien.Size = new System.Drawing.Size(317, 21);
            this.cbx_praticien.TabIndex = 1;
            this.cbx_praticien.SelectedIndexChanged += new System.EventHandler(this.cbx_praticien_SelectedIndexChanged);
            // 
            // btn_showInformations
            // 
            this.btn_showInformations.Location = new System.Drawing.Point(187, 214);
            this.btn_showInformations.Name = "btn_showInformations";
            this.btn_showInformations.Size = new System.Drawing.Size(128, 23);
            this.btn_showInformations.TabIndex = 2;
            this.btn_showInformations.Text = "&Voir les informations";
            this.btn_showInformations.UseVisualStyleBackColor = true;
            this.btn_showInformations.Click += new System.EventHandler(this.btn_showInformations_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(140, 157);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 3;
            // 
            // SearchPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 282);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_showInformations);
            this.Controls.Add(this.cbx_praticien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPraticien";
            this.Text = "Rechercher un praticien";
            this.Load += new System.EventHandler(this.SearchPraticien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_praticien;
        private System.Windows.Forms.Button btn_showInformations;
        private System.Windows.Forms.Label lbl_error;
    }
}