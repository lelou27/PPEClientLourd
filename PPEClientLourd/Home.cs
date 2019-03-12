using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Home : Form
    {
        private string _colMatricule;
        private string _colNom;
        private string _role = "visiteur";
        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

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

            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT COL_MATRICULE FROM responsable WHERE COL_MATRICULE = '" + colMat + "';");

            string matricule;

            while (!cs.Fin())
            {
                matricule = cs.Champ("COL_MATRICULE").ToString();

                if (matricule.Length != 0)
                {
                    _role = "responsable";
                }

                cs.Suivant();
            }

            cs.Fermer();

            if (_role == "visiteur")
            {
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
            rapportVisite rv = new rapportVisite(_colNom, _colMatricule);
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
    }
}
