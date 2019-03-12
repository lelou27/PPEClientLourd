using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class AllVisiteurs : Form
    {
        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

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

        private void dgv_visiteurs_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            string matricule = dgv_visiteurs[0, e.RowIndex].Value.ToString();

            if (matricule.Length != 0)
            {
                OneVisiteur ov = new OneVisiteur(_colMatricule, matricule);
                ov.Show();

                Hide();

            }
        }

        private void btn_retour_Click( object sender, EventArgs e )
        {
            Close();

            Home h = new Home(_colMatricule, _colNom);
        }

        private void AllVisiteurs_Load( object sender, EventArgs e )
        {
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

                dateEmbauche = Convert.ToDateTime(dateEmbauche).ToString();
                dateEmbauche = dateEmbauche.Split(' ')[0];


                dgv_visiteurs.Rows.Add(matricule, nom, prenom, dateEmbauche);

                cs.Suivant();
            }

            if (dgv_visiteurs.Rows.Count == 0)
            {
                dgv_visiteurs.Rows.Add("Désolé, aucun visiteurs n'ont été trouvés");
            }

            cs.Fermer();
        }
    }
}
