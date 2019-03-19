using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class AllVisiteurs : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        private string _colNom, _colMatricule;
        public AllVisiteurs( string colNom, string colMat )
        {
            InitializeComponent();

            _colNom = colNom;
            _colMatricule = colMat;
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        // Lors d'un clique sur une cellule
        private void dgv_visiteurs_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            // Récupération du matricule du visiteur séléctionné
            string matricule = dgv_visiteurs[0, e.RowIndex].Value.ToString();

            if (matricule.Length != 0)
            {
                // On ouvre la page sur la visualisation d'un visiteur
                OneVisiteur ov = new OneVisiteur(_colMatricule, matricule);
                ov.Show();


                Close();

            }
        }

        // Lors d'un appui sur le bouton retour
        private void btn_retour_Click( object sender, EventArgs e )
        {
            Close();
            // Retour vers l'accueil
            Home h = new Home(_colMatricule, _colNom);
        }

        // Au chargement du formulaire
        private void AllVisiteurs_Load( object sender, EventArgs e )
        {
            // Sélection de tout les visiteurs
            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT c.COL_MATRICULE, c.COL_NOM, c.COL_PRENOM, c.COL_DATEEMBAUCHE FROM collaborateur c " +
                            " INNER JOIN visiteur v ON c.COL_MATRICULE = v.COL_MATRICULE; ");

            string matricule, nom, prenom, dateEmbauche;

            while (!cs.Fin())
            {
                matricule = cs.Champ("COL_MATRICULE").ToString();
                nom = cs.Champ("COL_NOM").ToString();
                prenom = cs.Champ("COL_PRENOM").ToString();
                dateEmbauche = cs.Champ("COL_DATEEMBAUCHE").ToString();
                // Conversion de la date d'embauche dans un format plus lisible
                dateEmbauche = Convert.ToDateTime(dateEmbauche).ToString();
                dateEmbauche = dateEmbauche.Split(' ')[0];

                // Ajout à la dataGridView
                dgv_visiteurs.Rows.Add(matricule, nom, prenom, dateEmbauche);

                cs.Suivant();
            }

            // Si aucun visiteurs
            if(dgv_visiteurs.Rows.Count == 0)
            {
                dgv_visiteurs.Rows.Add("Désolé, aucun visiteur n'a été trouvé");
            }

            cs.Fermer();
        }
    }
}
