using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class newPraticien : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;
        // Dictionnaire pour les types de praticien
        private Dictionary<string, string> typePraticiens = new Dictionary<string, string>();

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public newPraticien() => InitializeComponent();
        // Au chargement du form
        private void newPraticien_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);
            // Récupération des types de praticien
            string req = "SELECT TYP_CODE, TYP_LIBELLE FROM type_praticien;";
            cs.ReqSelect(req);

            while (!cs.Fin())
            {
                // Ajout dans le dictionnaire et dans la cbx
                typePraticiens.Add(cs.Champ("TYP_CODE").ToString(), cs.Champ("TYP_LIBELLE").ToString());
                cbx_typePraticien.Items.Add(cs.Champ("TYP_LIBELLE").ToString());

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void btn_retour_Click( object sender, EventArgs e ) => Close();

        // Lors de la validation
        private void btn_validate_Click( object sender, EventArgs e )
        {
            string nom, prenom, adresse, ville, typePraticienLibelle;
            double coefNotoriete;
            int cp;

            // Récupération des champs
            nom = txb_nom.Text.ToString().Trim();
            prenom = txb_prenom.Text.ToString().Trim();
            adresse = txb_adresse.Text.ToString().Trim();
            try { cp = Convert.ToInt16(txb_cp.Text.ToString()); } catch (Exception) { lbl_error_cp.Text = "Veuillez renseigner un code postal valide"; cp = 0; };
            ville = txb_ville.Text.ToString().Trim();
            try { typePraticienLibelle = cbx_typePraticien.SelectedItem.ToString(); } catch (Exception) { typePraticienLibelle = ""; lbl_error_typePraticien.Text = "Veuillez choisir une option"; }
            try { coefNotoriete = Convert.ToDouble(txb_coefNotoriete.Text.ToString()); } catch (Exception) { lbl_error_notoriete.Text = "Veuillez renseigner une valeur numérique"; coefNotoriete = 0; };

            // Dispersion des erreurs
            bool error = dispatchErrors(nom, prenom, ville, cp, adresse, typePraticienLibelle, coefNotoriete);

            if (!error)
            {
                // Récupération du praticien dans le dictionnaire
                string codeTypePraticien = typePraticiens.FirstOrDefault(x => x.Value == typePraticienLibelle).Key;

                Curs cs = new Curs(chaineConnexion);
                
                string coefNotorieteConvert = coefNotoriete.ToString().Replace(',', '.').ToString(); ;
                // Insertion
                string req = "INSERT INTO praticien(PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE) " +
                            " VALUES ('" + nom + "', '" + prenom + "', '" + adresse + "', " + cp + ", '" + ville + "', " + coefNotorieteConvert + ", '" + codeTypePraticien + "');";

                try
                {
                    cs.ReqAdmin(req);

                    MessageBox.Show("Succès lors de l'enregistrement", "Enregistrement éffectué", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception erreur)
                {
                    lbl_error_general.Text = "Erreur lors de l'insertion du praticien " + erreur.Message;
                }

                cs.Fermer();
            }
        }
        // Affiche les erreurs si il y en a
        private bool dispatchErrors( string nom, string prenom, string ville, int cp, string adresse, string typePraticien
                                    , double coefNotoriete )
        {
            bool error = false;
            // Ternaires erreurs
            lbl_errorNom.Text = (nom.Length == 0) ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = (prenom.Length == 0) ? "Veuillez renseigner un prénom" : "";
            lbl_error_ville.Text = (ville.Length == 0) ? "Veuillez renseigner une ville" : "";
            lbl_error_cp.Text = (cp == 0) ? "Veuillez renseigner un code postal" : "";
            lbl_error_adresse.Text = (adresse.Length == 0) ? "Veuillez renseigner une adresse" : "";
            lbl_error_typePraticien.Text = (typePraticien.Length == 0) ? "Veuillez renseigner un type de praticien" : "";
            lbl_error_notoriete.Text = (coefNotoriete == 0) ? "Veuillez renseigner un coefficient de notoriété" : "";

            if (nom.Length == 0 || prenom.Length == 0 || ville.Length == 0 || cp == 0 || adresse.Length == 0 || typePraticien.Length == 0
                || coefNotoriete == 0)
            {
                error = true;
            }

            return error;
        }
    }
}
