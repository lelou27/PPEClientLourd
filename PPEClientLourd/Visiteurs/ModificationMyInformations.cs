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
    public partial class ModificationMyInformations : Form
    {
        private string _matricule;
        private string _nom;
        private string _role;
        // Dictionnaire pour enregistrer le numéro de labo en correspondance au nom du labo
        private Dictionary<string, string> labo = new Dictionary<string, string>();
        // Dictionnaire permettant d'enregistrer la relation numéro de secteur, nom du secteur
        private Dictionary<string, string> secteur = new Dictionary<string, string>();

        string chaineConnexion = ConnexionDb.chaineConnexion;

        // Constructeur, le rôle est important pour savoir si on donne l'autorisation de modifier le secteur
        public ModificationMyInformations(string matricule, string nom, string role)
        {
            InitializeComponent();
            this._matricule = matricule;
            this._nom = nom;
            this._role = role;

            Curs cs = new Curs(this.chaineConnexion);

            if(this._role == "visiteur")
            {
                // Si l'utilisateur est un visiteur, inutile d'afficher le secteur (responsable)
                lbl_secteur.Hide();
                cbx_secteur.Hide();
            }
            else
            {
                // Sinon récupération des secteurs
                cs.ReqSelect("SELECT SEC_CODE, SEC_LIBELLE FROM secteur");
                while(!cs.Fin())
                {
                    // Ajout au dictionnaire de secteurs
                    secteur.Add(cs.Champ("SEC_CODE").ToString(), cs.Champ("SEC_LIBELLE").ToString());
                    cbx_secteur.Items.Add(cs.Champ("SEC_LIBELLE").ToString());
                    cs.Suivant();
                }
                cs.Fermer();
            }

            string laboCode = this.setChamps(matricule);
            this.addItemsToLabo(laboCode);
        }

        // Permet de remplir les champs de formulaire
        private string setChamps(string matricule)
        {
            Curs cs = new Curs(this.chaineConnexion);

            // Récupération du collaborateur
            cs.ReqSelect("SELECT * FROM collaborateur WHERE COL_MATRICULE = '" + matricule + "';");
            string laboCode = "";

            while (!cs.Fin())
            {
                // Remplissage des champs
                txb_nom.Text = cs.Champ("COL_NOM").ToString();
                txb_prenom.Text = cs.Champ("COL_PRENOM").ToString();
                txb_adresse.Text = cs.Champ("COL_ADRESSE").ToString();
                txb_ville.Text = cs.Champ("COL_VILLE").ToString();
                txb_cp.Text = cs.Champ("COL_CP").ToString();

                laboCode = cs.Champ("LAB_CODE").ToString();

                // Si responsable, remplissage du secteur
                if (_role == "responsable")
                    cbx_secteur.SelectedItem = secteur[cs.Champ("SEC_CODE").ToString()];

                cs.Suivant();
            }

            cs.Fermer();
            return laboCode;
        }

        // Ajoute les laboratoire au comboBox labo
        private void addItemsToLabo(string laboCode)
        {
            Curs cs = new Curs(this.chaineConnexion);

            // Récupération des labos
            cs.ReqSelect("SELECT LAB_CODE, LAB_NOM FROM labo");

            while(!cs.Fin())
            {
                // Ajout au dictionnaire
                this.labo.Add(cs.Champ("LAB_CODE").ToString(), cs.Champ("LAB_NOM").ToString());

                cbx_labo.Items.Add(cs.Champ("LAB_NOM").ToString());

                // Si le labo récupérer est le même que celui de l'utilisateur, on le sélectionne
                if (laboCode == cs.Champ("LAB_CODE").ToString())
                    cbx_labo.SelectedItem = cs.Champ("LAB_NOM").ToString();

                cs.Suivant();
            }
            cs.Suivant();
        }


        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lors de l'appui sur le bouton modifier
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            string nom, prenom, adresse, ville, cp, secteur, labo;
            int codePostal;

            // Récupération des champs
            nom = txb_nom.Text.Trim();
            prenom = txb_prenom.Text.Trim();
            adresse = txb_adresse.Text.Trim();
            ville = txb_ville.Text.Trim();
            cp = txb_cp.Text.Trim();

            if (_role == "responsable")
                secteur = cbx_secteur.SelectedItem.ToString();
            else
                secteur = null;

            labo = cbx_labo.SelectedItem.ToString();

            // Remplis les erreurs si il y en a
            this.dispatchErrors(nom, prenom, adresse, ville, cp, secteur, labo);

            // Vérification de champs vides
            if(nom.Length != 0 && prenom.Length != 0 && ville.Length != 0 && cp.Length != 0 && labo.Length != 0)
            {
                bool error = false;

                // Try parse en numérique
                if (!Int32.TryParse(cp, out codePostal))
                {
                    lbl_error_cp.Text = "Veuillez renseigner une valeur numérique";
                    error = true;
                }

                // Si pas d'erreurs
                if(!error)
                {
                    Curs cs = new Curs(this.chaineConnexion);
                    // Récupération du labo dans le dictionnaire
                    labo = this.labo.FirstOrDefault(x => x.Value == labo).Key;

                    string req;

                    if (_role == "responsable")
                    {
                        // Récupération du secteur dans le dictionnaire
                        secteur = this.secteur.FirstOrDefault(x => x.Value == secteur).Key;

                        req = "UPDATE collaborateur SET COL_NOM = '" + nom + "', COL_PRENOM = '" + prenom + "', COL_ADRESSE = '" + adresse + "'" +
                        ", COL_VILLE = '" + ville + "', COL_CP = '" + cp + "', LAB_CODE = '" + labo + "', SEC_CODE = '" + secteur + "'" +
                        " WHERE COL_MATRICULE = '"+_matricule+"';";

                    }
                    else
                    {
                        req = "UPDATE collaborateur SET COL_NOM = '" + nom + "', COL_PRENOM = '" + prenom + "', COL_ADRESSE = '" + adresse + "'" +
                        ", COL_VILLE = '" + ville + "', COL_CP = '" + cp + "', LAB_CODE = '" + labo + "'" +
                        " WHERE COL_MATRICULE = '"+_matricule+"';";
                    }

                    try
                    {
                        // Update de l'utilisateur
                        cs.ReqAdmin(req);
                        cs.Fermer();

                        // Message de confirmation
                        MessageBox.Show("Mise à jour effectué", "Success lors de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception)
                    {
                        // Erreur lors de la maj
                        lbl_error_general.Text = "Erreur lors de la mise à jour";
                    }
                }
            }
        }

        // Permet d'afficher les erreurs si il y en a
        private void dispatchErrors(string nom, string prenom, string adresse, string ville, string cp, string secteur, string labo)
        {
            // Ternaires affichant les erreurs
            lbl_error_nom.Text = nom.Length == 0 ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = prenom.Length == 0 ? "Veuillez renseigner un prénom" : "";
            lbl_error_adresse.Text = adresse.Length == 0 ? "Veuillez renseigner une adresse" : "";
            lbl_error_ville.Text = ville.Length == 0 ? "Veuillez renseigner une ville" : "";
            lbl_error_cp.Text = cp.Length == 0 ? "Veuillez renseigner un code postal" : "";
            if(_role == "responsable")
                lbl_error_secteur.Text = secteur.Length == 0 ? "Veuillez renseigner un secteur" : "";
            lbl_error_labo.Text = labo.Length == 0 ? "Veuillez renseigner un laboratoire" : "";
        }
    }
}
