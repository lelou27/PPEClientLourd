﻿namespace PPEClientLourd
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.lbl_connexion = new System.Windows.Forms.Label();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_error_login = new System.Windows.Forms.Label();
            this.lbl_error_password = new System.Windows.Forms.Label();
            this.lbl_error_connexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_connexion
            // 
            this.lbl_connexion.AutoSize = true;
            this.lbl_connexion.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connexion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_connexion.Location = new System.Drawing.Point(101, 67);
            this.lbl_connexion.Name = "lbl_connexion";
            this.lbl_connexion.Size = new System.Drawing.Size(469, 34);
            this.lbl_connexion.TabIndex = 0;
            this.lbl_connexion.Text = "Connexion à l\'application du laboratoire";
            // 
            // txb_login
            // 
            this.txb_login.Location = new System.Drawing.Point(243, 180);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(196, 20);
            this.txb_login.TabIndex = 1;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(243, 261);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(196, 20);
            this.txb_password.TabIndex = 2;
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_login.Location = new System.Drawing.Point(283, 127);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(126, 20);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Nom d\'utilisateur";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_password.Location = new System.Drawing.Point(283, 213);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(105, 20);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Mot de passe";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_send.Location = new System.Drawing.Point(303, 314);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(72, 33);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "&Valider";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // lbl_error_login
            // 
            this.lbl_error_login.AutoSize = true;
            this.lbl_error_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_login.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_login.Location = new System.Drawing.Point(240, 161);
            this.lbl_error_login.Name = "lbl_error_login";
            this.lbl_error_login.Size = new System.Drawing.Size(0, 16);
            this.lbl_error_login.TabIndex = 6;
            // 
            // lbl_error_password
            // 
            this.lbl_error_password.AutoSize = true;
            this.lbl_error_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_password.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_password.Location = new System.Drawing.Point(240, 242);
            this.lbl_error_password.Name = "lbl_error_password";
            this.lbl_error_password.Size = new System.Drawing.Size(0, 16);
            this.lbl_error_password.TabIndex = 7;
            // 
            // lbl_error_connexion
            // 
            this.lbl_error_connexion.AutoSize = true;
            this.lbl_error_connexion.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_connexion.Location = new System.Drawing.Point(191, 358);
            this.lbl_error_connexion.Name = "lbl_error_connexion";
            this.lbl_error_connexion.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_connexion.TabIndex = 8;
            // 
            // Connexion
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.lbl_error_connexion);
            this.Controls.Add(this.lbl_error_password);
            this.Controls.Add(this.lbl_error_login);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.lbl_connexion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.Text = "Application Laboratoire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_connexion;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_error_login;
        private System.Windows.Forms.Label lbl_error_password;
        private System.Windows.Forms.Label lbl_error_connexion;
    }
}

