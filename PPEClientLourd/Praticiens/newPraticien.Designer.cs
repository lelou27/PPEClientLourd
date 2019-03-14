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
            this.lbl_depotLegal = new System.Windows.Forms.Label();
            this.lbl_nomCommercial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_depotLegal
            // 
            this.lbl_depotLegal.AutoSize = true;
            this.lbl_depotLegal.Location = new System.Drawing.Point(36, 38);
            this.lbl_depotLegal.Name = "lbl_depotLegal";
            this.lbl_depotLegal.Size = new System.Drawing.Size(67, 13);
            this.lbl_depotLegal.TabIndex = 0;
            this.lbl_depotLegal.Text = "Depot légal :";
            // 
            // lbl_nomCommercial
            // 
            this.lbl_nomCommercial.AutoSize = true;
            this.lbl_nomCommercial.Location = new System.Drawing.Point(36, 82);
            this.lbl_nomCommercial.Name = "lbl_nomCommercial";
            this.lbl_nomCommercial.Size = new System.Drawing.Size(91, 13);
            this.lbl_nomCommercial.TabIndex = 1;
            this.lbl_nomCommercial.Text = "Nom commercial :";
            // 
            // newPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nomCommercial);
            this.Controls.Add(this.lbl_depotLegal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newPraticien";
            this.Text = "Créer un praticien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_depotLegal;
        private System.Windows.Forms.Label lbl_nomCommercial;
    }
}