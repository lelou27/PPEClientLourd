using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class SearchVisiteur : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;
        private Dictionary<string, string> visiteurs = new Dictionary<string, string>();
        private string _matricule;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public SearchVisiteur( string matricule )
        {
            InitializeComponent();

            _matricule = matricule;
        }

        private void SearchVisiteur_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);

            string request = "SELECT c.COL_MATRICULE, c.COL_NOM, c.COL_PRENOM " +
                "             FROM collaborateur c INNER JOIN visiteur v ON c.COL_MATRICULE = v.COL_MATRICULE";

            cs.ReqSelect(request);

            string nomComplet;

            while (!cs.Fin())
            {
                nomComplet = cs.Champ("COL_PRENOM").ToString() + " " + cs.Champ("COL_NOM").ToString();
                cmbx_visiteurs.Items.Add(nomComplet);

                visiteurs.Add(cs.Champ("COL_MATRICULE").ToString(), nomComplet);

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void btn_showInformations_Click( object sender, EventArgs e )
        {
            string visiteur = cmbx_visiteurs.Text;
            string matricule;

            if (visiteur.Length != 0)
            {
                matricule = visiteurs.FirstOrDefault(x => x.Value == visiteur).Key;
                OneVisiteur ov = new OneVisiteur(_matricule, matricule, "SearchVisiteur");

                Close();

                ov.Show();
            }
            else
            {
                lbl_errorVisitor.Text = "Le visiteur renseigné ne correspond pas";
            }
        }
    }
}
