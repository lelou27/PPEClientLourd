using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class OneVisiteur : Form
    {
        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql
        private string _previous;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        private string _matricule;
        private string _matriculePersonne;
        private string _nom;

        public OneVisiteur( string matricule, string matriculePersonne, string previous = "AllVisiteur" )
        {
            InitializeComponent();
            _matricule = matricule;
            _matriculePersonne = matriculePersonne;
            _previous = previous;

            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT c.*, l.LAB_NOM FROM collaborateur c INNER JOIN labo l ON c.LAB_CODE = l.LAB_CODE" +
                " WHERE c.COL_MATRICULE = '" + matricule + "';");

            while (!cs.Fin())
            {
                string dateEmbauche;

                _nom = cs.Champ("COL_NOM").ToString();

                txb_nom.Text = cs.Champ("COL_NOM").ToString();
                txb_prenom.Text = cs.Champ("COL_PRENOM").ToString();
                txb_adresse.Text = cs.Champ("COL_ADRESSE").ToString();
                txb_cp.Text = cs.Champ("COL_CP").ToString();

                dateEmbauche = cs.Champ("COL_DATEEMBAUCHE").ToString();
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

        private void btn_retour_Click( object sender, EventArgs e )
        {
            Close();

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
