﻿using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Home : Form
    {
        private string _colMatricule;
        private string _colNom;
        private string _role = "visiteur";
        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public Home( string colMat, string colNom )
        {
            InitializeComponent();
            _colMatricule = colMat;
            _colNom = colNom;

            // Requete de récupération de rôle
            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT COL_MATRICULE FROM responsable WHERE COL_MATRICULE = '" + colMat + "';");

            string matricule;

            while (!cs.Fin())
            {
                matricule = cs.Champ("COL_MATRICULE").ToString();

                if (matricule.Length != 0)
                {
                    // Si un utilisateur correspond, il est forcémment responsable
                    _role = "responsable";
                }

                cs.Suivant();
            }

            cs.Fermer();

            if (_role == "visiteur")
            {
                // Si le role = visiteur, on cache certains items des menus car le visiteur n'a pas besoin de ceux-ci
                ajouterUnVisiteurToolStripMenuItem.Visible = false;
                toutLesVisiteursToolStripMenuItem.Visible = false;
                chercherUnVisiteurToolStripMenuItem.Visible = false;
            }
        }

        private void Home_Load( object sender, EventArgs e )
        {

        }

        private void créerUnCompteRenduToolStripMenuItem_Click_1( object sender, EventArgs e )
        {
            RapportVisite rv = new RapportVisite(_colNom, _colMatricule);
            rv.Show();
        }

        private void seDéconnecterToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Close();
            Connexion c = new Connexion();
            c.Show();
        }

        private void toutLesVisiteursToolStripMenuItem_Click( object sender, EventArgs e )
        {
            AllVisiteurs av = new AllVisiteurs(_colNom, _colMatricule);
            av.Show();
        }

        private void modifierLesInformationsDunVisiteurToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void voirToutLesPraticiensToolStripMenuItem_Click( object sender, EventArgs e )
        {
            AllPraticiens ap = new AllPraticiens();
            ap.Show();
        }

        private void ajouterUnMédicamentToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Ajouter_Medicament am = new Ajouter_Medicament();
            am.Show();
        }

        private void consulterLesMédicamentsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Consulter_Medicament cm = new Consulter_Medicament();
            cm.Show();
        }
        private void chercherUnVisiteurToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SearchVisiteur sv = new SearchVisiteur(_colMatricule);
            sv.Show();
        }

        private void consulterToutsLesMédicamentsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Consulter_Tous_Medicaments ctm = new Consulter_Tous_Medicaments();
            ctm.Show();
        }

        private void ajouterUnVisiteurToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CreerVisiteur cv = new CreerVisiteur();
            cv.Show();
        }

        private void modifierLesInformationsDunVisiteurToolStripMenuItem_Click_2( object sender, EventArgs e )
        {
            ModificationMyInformations mmy = new ModificationMyInformations(_colMatricule, _colNom, _role);
            mmy.Show();
        }

        private void ajouterUnVisiteurToolStripMenuItem_Click_1( object sender, EventArgs e )
        {
            CreerVisiteur cv = new CreerVisiteur();
            cv.Show();
        }

        private void voirToutLesPraticiensToolStripMenuItem_Click_1( object sender, EventArgs e )
        {
            AllPraticiens ap = new AllPraticiens();
            ap.Show();
        }

        private void voirToutLesCompteRendusToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ShowAllRaports sar = new ShowAllRaports(_colMatricule, _colNom, _role);
            sar.Show();
        }

        private void ajouterUnPraticienToolStripMenuItem_Click( object sender, EventArgs e )
        {
            newPraticien np = new newPraticien();
            np.Show();
        }

        private void rechercherUnPraticienToolStripMenuItem_Click( object sender, EventArgs e )
        {
            SearchPraticien sp = new SearchPraticien();
            sp.Show();
        }
    }
}
