using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Connexion : Form
    {
        // Initialisation de la chaine de connexion à la base de données
        string chaineConnexion = ConnexionDb.chaineConnexion;

        // getter setter de la chaine de connexion
        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }
        // Constructeur
        public Connexion()
        {
            InitializeComponent();
            // Par défaut, on cache les label d'erreurs
            lbl_error_login.Hide();
            lbl_error_password.Hide();
        }


        // Au click sur le bouton valider
        private void Btn_send_Click(object sender, EventArgs e)
        {
            // Récupération des donées
            string username = txb_login.Text.ToString();
            string password = txb_password.Text.ToString();

            if (username.Length != 0)
            {
                lbl_error_login.Hide();
                if (password.Length != 0)
                {
                    lbl_error_password.Hide();

                    // Sélection de l'utilisateur en base pour savoir si il existe bien
                    Curs cs = new Curs(this.chaineConnexion);
                    
                    cs.ReqSelect("" +
                        "SELECT v.COL_MATRICULE, c.COL_NOM FROM visiteur v " +
                           " INNER JOIN collaborateur c ON v.COL_MATRICULE = c.COL_MATRICULE " +
                        " WHERE c.COL_NOM = '" + username + "' " +
                        " AND DATE_FORMAT(c.COL_DATEEMBAUCHE, '%Y-%b-%d') = '" + password + "'; "
                        );
                    string nom = "";
                    string matricule = "";

                    while (!cs.Fin())
                    {
                        matricule = cs.Champ("COL_MATRICULE").ToString();
                        nom = cs.Champ("COL_NOM").ToString();
                        
                        // Vérification de l'utilisateur
                        if(matricule.Length != 0 && nom.Length != 0)
                        {
                            Home homeForm = new Home(matricule, nom);
                            Hide();
                            homeForm.Show();
                        }
                        else
                        {
                            // Erreur lors de la connexion
                            lbl_error_connexion.Text = "Impossible de vous connecter, les informations ne sont pas corrects";
                        }
                        cs.Suivant();
                    }

                    lbl_error_connexion.Text = "Impossible de vous connecter, les informations ne sont pas corrects";

                    cs.Fermer();

                }
                else
                {
                    lbl_error_password.Text = "Veuillez renseigner un mot de passe";
                    lbl_error_password.Show();
                }
            }
            else
            {
                lbl_error_login.Text = "Veuillez renseigner un login";
                lbl_error_login.Show();
            }
        }

        private void Lbl_error_login_Click( object sender, EventArgs e )
        {

        }

        private void Connexion_Load( object sender, EventArgs e )
        {

        }

    }
}
