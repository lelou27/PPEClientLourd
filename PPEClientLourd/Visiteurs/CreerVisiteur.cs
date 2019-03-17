-using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class CreerVisiteur : Form
    {
        private Dictionary<string, string> laboratoire = new Dictionary<string, string>();
        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public CreerVisiteur()
        {
            InitializeComponent();
            lbl_secteur.Visible = false;
            cbx_secteur.Visible = false;
        }

        private void CreerVisiteur_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);

            string req = "SELECT LAB_CODE, LAB_NOM FROM labo";

            cs.ReqSelect(req);

            string laboCode, laboNom;

            while (!cs.Fin())
            {
                laboCode = cs.Champ("LAB_CODE").ToString();
                laboNom = cs.Champ("LAB_NOM").ToString();

                laboratoire.Add(laboCode, laboNom);
                cmbx_labo.Items.Add(laboNom);

                cs.Suivant();
            }

            cs.Fermer();

            cs = new Curs(chaineConnexion);
            req = "SELECT SEC_LIBELLE FROM secteur";
            cs.ReqSelect(req);

            while (!cs.Fin())
            {
                cbx_secteur.Items.Add(cs.Champ("SEC_LIBELLE").ToString());
                cs.Suivant();
            }
            cs.Fermer();
        }

        private void btn_valider_Click( object sender, EventArgs e )
        {
            string matricule, nom, prenom, adresse, cp, ville, dateEmbauche, labo, secteur;
            int delegue;

            if (cb_delegue.Checked)
            {
                delegue = 1;
            }
            else
            {
                delegue = 0;
            }

            secteur = getSecteurDB();

            // Check and trim all inputs
            matricule = txb_matricule.Text.Trim();
            nom = txb_nom.Text.Trim();
            prenom = txb_prenom.Text.Trim();
            adresse = txb_adresse.Text.Trim();
            cp = txb_cp.Text.Trim();
            ville = txb_ville.Text.Trim();
            dateEmbauche = dttp_embauche.Text.Trim();
            labo = cmbx_labo.Text.Trim();

            // dispatch all errors if have errors
            dispatchError(matricule, nom, prenom, adresse, cp, ville, labo);

            if (matricule.Length != 0 && nom.Length != 0 && prenom.Length != 0 && adresse.Length != 0
                && cp.Length != 0 && ville.Length != 0 && ville.Length != 0 && dateEmbauche.Length != 0
                && labo.Length != 0)
            {
                // error for matricule if exist in DB
                bool error = false;

                //Verif matricule
                Curs cs = new Curs(chaineConnexion);
                cs.ReqSelect("SELECT COL_MATRICULE FROM collaborateur WHERE COL_MATRICULE = '" + matricule + "';");

                while (!cs.Fin())
                {
                    if (cs.Champ("COL_MATRICULE").ToString().Length != 0)
                    {
                        error = true;
                    }

                    cs.Suivant();
                }
                cs.Fermer();

                if (!int.TryParse(cp, out int codePostal))
                {
                    lbl_error_cp.Text = "Veuillez renseigner une valeur numérique";
                    error = true;
                }

                if (!error)
                {
                    // GET LABO FOR INSERTION
                    cs = new Curs(chaineConnexion);
                    string req = "SELECT LAB_CODE FROM labo WHERE LAB_NOM = '" + labo + "';";
                    cs.ReqSelect(req);

                    while (!cs.Fin())
                    {
                        labo = cs.Champ("LAB_CODE").ToString();
                        cs.Suivant();
                    }
                    cs.Fermer();

                    cs = new Curs(chaineConnexion);
                    insertIntoCollaborateur(dateEmbauche, matricule, nom, prenom, adresse, cp, ville, labo, secteur, delegue, cs);

                }
                else
                {
                    lbl_error_general.Text = "Un utilisateur existe avec ce matricule";
                }
            }
        }

        private string getSecteurDB()
        {
            string secteur;
            if (cb_responsable.Checked)
            {
                secteur = cbx_secteur.SelectedItem.ToString();

                // GET SECTOR FOR RESPONSABLE INSERTION
                Curs cs = new Curs(chaineConnexion);
                cs.ReqSelect("SELECT SEC_CODE FROM secteur WHERE SEC_LIBELLE = '" + secteur + "';");

                while (!cs.Fin())
                {
                    secteur = cs.Champ("SEC_CODE").ToString();
                    cs.Suivant();
                }

                cs.Fermer();
            }
            else
            {
                secteur = null;
            }

            return secteur;
        }

        private void insertIntoCollaborateur( string dateEmbauche, string matricule, string nom, string prenom, string adresse,
            string cp, string ville, string labo, string secteur, int delegue, Curs cs )
        {
            string dateEmbaucheParsed = Convert.ToDateTime(dateEmbauche).ToString("yyyy-MM-dd H:mm:ss");

            string concatInsert = "'" + matricule + "','" + nom + "','" + prenom + "','" + adresse + "','" + ville + "','" + cp + "','" + dateEmbaucheParsed + "','" + labo + "','" + secteur + "'";

            string req = "INSERT INTO collaborateur(COL_MATRICULE, COL_NOM, COL_PRENOM, COL_ADRESSE, COL_VILLE, COL_CP" +
                " , COL_DATEEMBAUCHE, LAB_CODE, SEC_CODE) VALUES (" + concatInsert + ");";

            try
            {
                cs.ReqAdmin(req);
                cs.Fermer();

                // UPDATE IF DELEGUE
                if (delegue == 1)
                {
                    cs = new Curs(chaineConnexion);
                    req = "UPDATE visiteur SET DELEGUE = '" + delegue + "' WHERE COL_MATRICULE = '" + matricule + "';";
                    cs.ReqAdmin(req);
                    cs.Fermer();
                }

                MessageBox.Show("Enregistrement effectué", "Success lors de l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception errorInsert)
            {
                lbl_error_general.Text = "Erreur lors de l'insertion " + errorInsert.Message;
            }
        }

        private void dispatchError( string matricule, string nom, string prenom, string adresse, string cp,
            string ville, string labo )
        {
            lbl_error_matricule.Text = (matricule.Length == 0) ? "Veuillez renseigner un matricule" : "";
            lbl_error_nom.Text = (nom.Length == 0) ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = (prenom.Length == 0) ? "Veuillez renseigner un prénom" : "";
            lbl_error_adresse.Text = (adresse.Length == 0) ? "Veuillez renseigner une adresse" : "";
            lbl_error_cp.Text = (cp.Length == 0) ? "Veuillez renseigner un code postal" : "";
            lbl_error_ville.Text = (ville.Length == 0) ? "Veuillez renseigner une ville" : "";
            lbl_error_labo.Text = (labo.Length == 0) ? "Veuillez renseigner un labo" : "";
        }

        private void btn_retour_Click( object sender, EventArgs e ) => Close();

        private void cb_responsable_CheckedChanged( object sender, EventArgs e )
        {
            if (cb_responsable.Checked)
            {
                lbl_secteur.Visible = true;
                cbx_secteur.Visible = true;
                cb_delegue.Checked = false;
                cb_delegue.Visible = false;
            }
            else
            {
                lbl_secteur.Visible = false;
                cbx_secteur.Visible = false;
                cb_delegue.Visible = true;
            }
        }

        private void cb_delegue_CheckedChanged( object sender, EventArgs e )
        {
            if (!cb_delegue.Checked)
            {
                cb_responsable.Visible = true;
            }
            else
            {
                cb_responsable.Visible = false;
                lbl_secteur.Visible = false;
                cbx_secteur.Visible = false;
                cb_responsable.Checked = false;
            }
        }
    }
}
