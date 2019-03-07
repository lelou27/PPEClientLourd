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
    public partial class SearchVisiteur : Form
    {
        string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql
        Dictionary<string, string> visiteurs = new Dictionary<string, string>();
        private string _matricule;

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public SearchVisiteur(string matricule)
        {
            InitializeComponent();

            this._matricule = matricule;
        }

        private void SearchVisiteur_Load(object sender, EventArgs e)
        {
            Curs cs = new Curs(this.chaineConnexion);

            string request = "SELECT c.COL_MATRICULE, c.COL_NOM, c.COL_PRENOM " +
                "             FROM collaborateur c INNER JOIN visiteur v ON c.COL_MATRICULE = v.COL_MATRICULE";

            cs.ReqSelect(request);

            string nomComplet;

            while(!cs.Fin())
            {
                nomComplet = cs.Champ("COL_PRENOM").ToString() + " " + cs.Champ("COL_NOM").ToString();
                cmbx_visiteurs.Items.Add(nomComplet);

                visiteurs.Add(cs.Champ("COL_MATRICULE").ToString(), nomComplet);

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void btn_showInformations_Click(object sender, EventArgs e)
        {
            var visiteur = cmbx_visiteurs.Text;
            string matricule;

            if(visiteur.Length != 0)
            {
                matricule = visiteurs.FirstOrDefault(x => x.Value == visiteur).Key;
                OneVisiteur ov = new OneVisiteur(matricule, this._matricule, "SearchVisiteur");

                this.Close();

                ov.Show();
            } 
            else
            {
                lbl_errorVisitor.Text = "Le visiteur renseigné ne correspond pas";
            }
        }
    }
}