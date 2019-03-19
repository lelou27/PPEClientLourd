using System;
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
        string chaineConnexion = ConnexionDb.chaineConnexion;
        // Dictionnaire permettant de lier les noMatricule et les noms + prénoms
        Dictionary<string, string> visiteurs = new Dictionary<string, string>();
        private string _matricule;

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        // Constructeur
        public SearchVisiteur(string matricule)
        {
            InitializeComponent();

            this._matricule = matricule;
        }

        // Au chargement du formulaire
        private void SearchVisiteur_Load(object sender, EventArgs e)
        {
            // On va chercher tous les visiteurs
            Curs cs = new Curs(this.chaineConnexion);

            string request = "SELECT c.COL_MATRICULE, c.COL_NOM, c.COL_PRENOM " +
                "             FROM collaborateur c INNER JOIN visiteur v ON c.COL_MATRICULE = v.COL_MATRICULE";

            cs.ReqSelect(request);

            string nomComplet;

            while(!cs.Fin())
            {
                // Concaténation du nom + prénom
                nomComplet = cs.Champ("COL_PRENOM").ToString() + " " + cs.Champ("COL_NOM").ToString();
                // Ajout de l'item à la comboBox
                cmbx_visiteurs.Items.Add(nomComplet);

                // Ajout au dictionnaire
                visiteurs.Add(cs.Champ("COL_MATRICULE").ToString(), nomComplet);

                cs.Suivant();
            }

            cs.Fermer();
        }

        // Lors d'un clic sur le bouton voir les informatiions
        private void btn_showInformations_Click(object sender, EventArgs e)
        {
            // Récupération du visiteur sélétionné
            var visiteur = cmbx_visiteurs.Text;
            string matricule;

            if(visiteur.Length != 0)
            {
                // Récupération du matricule dans le dictionnaire
                matricule = visiteurs.FirstOrDefault(x => x.Value == visiteur).Key;
                // Ouverture du formulaire pour consulter un visiteur 
                OneVisiteur ov = new OneVisiteur(this._matricule, matricule, "SearchVisiteur");

                this.Close();

                ov.Show();
            } 
            else
            {
                // Erreur
                lbl_errorVisitor.Text = "Le visiteur renseigné ne correspond pas";
            }
        }
    }
}
