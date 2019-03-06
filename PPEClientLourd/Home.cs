﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Home : Form
    {
        private string _colMatricule;
        private string _colNom;
        private string _role = "visiteur";

        string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public Home(string colMat, string colNom)
        {
            InitializeComponent();
            this._colMatricule = colMat;
            this._colNom = colNom;

            Curs cs = new Curs(this.chaineConnexion);

            cs.ReqSelect("SELECT COL_MATRICULE FROM responsable WHERE COL_MATRICULE = '" + colMat + "';");

            string matricule;

            while(!cs.Fin())
            {
                matricule = cs.Champ("COL_MATRICULE").ToString();

                if (matricule.Length != 0)
                    this._role = "responsable";

                cs.Suivant();
            }

            cs.Fermer();

            if (this._role == "visiteur")
            {
                ajouterUnVisiteurToolStripMenuItem.Visible = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void créerUnCompteRenduToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rapportVisite rv = new rapportVisite(this._colNom, this._colMatricule);

            this.Hide();
            rv.Show();
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            Connexion c = new Connexion();
            c.Show();
        }

        private void toutLesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            AllVisiteurs av = new AllVisiteurs(this._colNom, this._colMatricule);
            av.Show();
        }

        private void modifierLesInformationsDunVisiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            AllVisiteurs av = new AllVisiteurs(this._colNom, this._colMatricule);
            av.Show();
        }


    }
}
