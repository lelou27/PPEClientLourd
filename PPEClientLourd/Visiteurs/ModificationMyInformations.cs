using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class ModificationMyInformations : Form
    {
        private string _matricule;
        private string _nom;
        private string _role;
        private Dictionary<string, string> labo = new Dictionary<string, string>();
        private Dictionary<string, string> secteur = new Dictionary<string, string>();
        private string chaineConnexion = ConnexionDb.chaineConnexion;


        public ModificationMyInformations( string matricule, string nom, string role )
        {
            InitializeComponent();
            _matricule = matricule;
            _nom = nom;
            _role = role;

            Curs cs = new Curs(chaineConnexion);

            if (_role == "visiteur")
            {
                lbl_secteur.Hide();
                cbx_secteur.Hide();
            }
            else
            {
                cs.ReqSelect("SELECT SEC_CODE, SEC_LIBELLE FROM secteur");
                while (!cs.Fin())
                {
                    secteur.Add(cs.Champ("SEC_CODE").ToString(), cs.Champ("SEC_LIBELLE").ToString());
                    cbx_secteur.Items.Add(cs.Champ("SEC_LIBELLE").ToString());
                    cs.Suivant();
                }
                cs.Fermer();
            }

            string laboCode = setChamps(matricule);
            addItemsToLabo(laboCode);
        }

        private string setChamps( string matricule )
        {
            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT * FROM collaborateur WHERE COL_MATRICULE = '" + matricule + "';");
            string laboCode = "";

            while (!cs.Fin())
            {
                txb_nom.Text = cs.Champ("COL_NOM").ToString();
                txb_prenom.Text = cs.Champ("COL_PRENOM").ToString();
                txb_adresse.Text = cs.Champ("COL_ADRESSE").ToString();
                txb_ville.Text = cs.Champ("COL_VILLE").ToString();
                txb_cp.Text = cs.Champ("COL_CP").ToString();

                laboCode = cs.Champ("LAB_CODE").ToString();

                if (_role == "responsable")
                {
                    cbx_secteur.SelectedItem = secteur[cs.Champ("SEC_CODE").ToString()];
                }

                cs.Suivant();
            }

            cs.Fermer();
            return laboCode;
        }

        private void addItemsToLabo( string laboCode )
        {
            Curs cs = new Curs(chaineConnexion);

            cs.ReqSelect("SELECT LAB_CODE, LAB_NOM FROM labo");

            while (!cs.Fin())
            {
                labo.Add(cs.Champ("LAB_CODE").ToString(), cs.Champ("LAB_NOM").ToString());

                cbx_labo.Items.Add(cs.Champ("LAB_NOM").ToString());

                if (laboCode == cs.Champ("LAB_CODE").ToString())
                {
                    cbx_labo.SelectedItem = cs.Champ("LAB_NOM").ToString();
                }

                cs.Suivant();
            }
            cs.Suivant();
        }


        private void btn_retour_Click( object sender, EventArgs e ) => Close();

        private void btn_modifier_Click( object sender, EventArgs e )
        {
            string nom, prenom, adresse, ville, cp, secteur, labo;

            nom = txb_nom.Text.Trim();
            prenom = txb_prenom.Text.Trim();
            adresse = txb_adresse.Text.Trim();
            ville = txb_ville.Text.Trim();
            cp = txb_cp.Text.Trim();

            if (_role == "responsable")
            {
                secteur = cbx_secteur.SelectedItem.ToString();
            }
            else
            {
                secteur = null;
            }

            labo = cbx_labo.SelectedItem.ToString();

            dispatchErrors(nom, prenom, adresse, ville, cp, secteur, labo);

            if (nom.Length != 0 && prenom.Length != 0 && ville.Length != 0 && cp.Length != 0 && labo.Length != 0)
            {
                bool error = false;

                if (!int.TryParse(cp, out int codePostal))
                {
                    lbl_error_cp.Text = "Veuillez renseigner une valeur numérique";
                    error = true;
                }

                if (!error)
                {
                    Curs cs = new Curs(chaineConnexion);

                    labo = this.labo.FirstOrDefault(x => x.Value == labo).Key;

                    string req;

                    if (_role == "responsable")
                    {
                        secteur = this.secteur.FirstOrDefault(x => x.Value == secteur).Key;

                        req = "UPDATE collaborateur SET COL_NOM = '" + nom + "', COL_PRENOM = '" + prenom + "', COL_ADRESSE = '" + adresse + "'" +
                        ", COL_VILLE = '" + ville + "', COL_CP = '" + cp + "', LAB_CODE = '" + labo + "', SEC_CODE = '" + secteur + "'" +
                        " WHERE COL_MATRICULE = '" + _matricule + "';";

                    }
                    else
                    {
                        req = "UPDATE collaborateur SET COL_NOM = '" + nom + "', COL_PRENOM = '" + prenom + "', COL_ADRESSE = '" + adresse + "'" +
                        ", COL_VILLE = '" + ville + "', COL_CP = '" + cp + "', LAB_CODE = '" + labo + "'" +
                        " WHERE COL_MATRICULE = '" + _matricule + "';";
                    }

                    try
                    {
                        cs.ReqAdmin(req);
                        cs.Fermer();

                        MessageBox.Show("Mise à jour effectué", "Success lors de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                    catch (Exception)
                    {
                        lbl_error_general.Text = "Erreur lors de la mise à jour";
                    }
                }
            }
        }

        private void dispatchErrors( string nom, string prenom, string adresse, string ville, string cp, string secteur, string labo )
        {
            lbl_error_nom.Text = nom.Length == 0 ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = prenom.Length == 0 ? "Veuillez renseigner un prénom" : "";
            lbl_error_adresse.Text = adresse.Length == 0 ? "Veuillez renseigner une adresse" : "";
            lbl_error_ville.Text = ville.Length == 0 ? "Veuillez renseigner une ville" : "";
            lbl_error_cp.Text = cp.Length == 0 ? "Veuillez renseigner un code postal" : "";
            if (_role == "responsable")
            {
                lbl_error_secteur.Text = secteur.Length == 0 ? "Veuillez renseigner un secteur" : "";
            }

            lbl_error_labo.Text = labo.Length == 0 ? "Veuillez renseigner un laboratoire" : "";
        }
    }
}
