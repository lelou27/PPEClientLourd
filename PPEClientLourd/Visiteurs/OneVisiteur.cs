using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class OneVisiteur : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;
        // Ce formulaire sert à plusieurs pages précédentes, donc, j'ai décidé de faire une variable previous et
        // de moifier le comportement en fonction de la page précédente
        private string _previous;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        private string _matricule;
        private string _matriculePersonne;
        private string _nom;

        // Constructeur avec un previous par défaut venant de la page tous les visiteurs
        public OneVisiteur( string matricule, string matriculePersonne, string previous = "AllVisiteur" )
        {
            InitializeComponent();
            _matricule = matricule;
            _matriculePersonne = matriculePersonne;
            _previous = previous;

            Curs cs = new Curs(chaineConnexion);
            // Récupération du collaborateur
            cs.ReqSelect("SELECT c.*, l.LAB_NOM FROM collaborateur c INNER JOIN labo l ON c.LAB_CODE = l.LAB_CODE" +
                " WHERE c.COL_MATRICULE = '" + matriculePersonne + "';");

            while (!cs.Fin())
            {
                string dateEmbauche;

                _nom = cs.Champ("COL_NOM").ToString();

                txb_nom.Text = cs.Champ("COL_NOM").ToString();
                txb_prenom.Text = cs.Champ("COL_PRENOM").ToString();
                txb_adresse.Text = cs.Champ("COL_ADRESSE").ToString();
                txb_cp.Text = cs.Champ("COL_CP").ToString();

                dateEmbauche = cs.Champ("COL_DATEEMBAUCHE").ToString();
                // Conversion de la date pour être plus lisible
                dateEmbauche = Convert.ToDateTime(dateEmbauche).ToString();
                dateEmbauche = dateEmbauche.Split(' ')[0];

                txb_dateEmbauche.Text = dateEmbauche;
                txb_labo.Text = cs.Champ("LAB_CODE").ToString();
                txb_ville.Text = cs.Champ("COL_VILLE").ToString();

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void OneVisiteur_Load( object sender, EventArgs e )
        {

        }

        private void label4_Click( object sender, EventArgs e )
        {

        }

        // Click sur le bouton retour
        private void btn_retour_Click( object sender, EventArgs e )
        {
            Close();
            // Ouverture du formulaire de la page précédente
            if (_previous == "AllVisiteur")
            {
                AllVisiteurs av = new AllVisiteurs(_nom, _matricule);
                av.Show();
            }
            else
            {
                SearchVisiteur sv = new SearchVisiteur(_matricule);
                sv.Show();
            }
        }
    }
}
