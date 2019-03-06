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
    public partial class OneVisiteur : Form
    {
        string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        private string _matricule;
        private string _matriculePersonne;
        private string _nom;

        public OneVisiteur(string matricule, string matriculePersonne)
        {
            InitializeComponent();
            this._matricule = matricule;
            this._matriculePersonne = matriculePersonne;

            Curs cs = new Curs(this.chaineConnexion);

            cs.ReqSelect("SELECT c.*, l.LAB_NOM FROM collaborateur c INNER JOIN labo l ON c.LAB_CODE = l.LAB_CODE" +
                " WHERE c.COL_MATRICULE = '" + matricule + "';");

            while (!cs.Fin())
            {
                string dateEmbauche;

                this._nom = cs.Champ("COL_NOM").ToString();

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

        private void OneVisiteur_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();

            AllVisiteurs av = new AllVisiteurs(this._nom, this._matricule);
            av.Show();
        }
    }
}
