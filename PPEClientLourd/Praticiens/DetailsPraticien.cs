﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class DetailsPraticien : Form
    {
        private string connection = ConnexionDb.chaineConnexion;
        private Dictionary<string, string> typePraticiens = new Dictionary<string, string>();
        private string _previous;
        private int _NumPraticiens;

        /// <summary>
        /// Affichage d'un praticien, modification d'un praticien
        /// </summary>
        /// <param name="NumPraticiens">numéro du praticien </param>
        /// <param name="previous">valeur de la page précédente</param>
        public DetailsPraticien( int NumPraticiens, string previous = "AllPraticiens" )
        {

            InitializeComponent();
            //On remplit les variables
            _previous = previous;
            _NumPraticiens = NumPraticiens;

            // Récuperation des données du praticien
            Curs cs2 = new Curs(connection);
            string requete = "SELECT praticien.`PRA_NUM`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM`,`praticien`.`PRA_ADRESSE`,`praticien`.`PRA_CP`" +
                ",`praticien`.`PRA_VILLE`,`praticien`.`PRA_COEFNOTORIETE`,`type_praticien`.`TYP_LIBELLE` FROM praticien,`type_praticien`" +
                " WHERE type_praticien.`TYP_CODE` = praticien.`TYP_CODE` AND praticien.`PRA_NUM` = " + NumPraticiens.ToString();
            Curs cs3 = new Curs(connection);
            string req = "SELECT TYP_CODE, TYP_LIBELLE FROM type_praticien;";

            cs2.ReqSelect(requete);
            cs3.ReqSelect(req);

            //Remplissage des champs
            while (!cs2.Fin())
            {
                textBox_num.Text = cs2.Champ("PRA_NUM").ToString();
                textBox_nom.Text = cs2.Champ("PRA_NOM").ToString();
                textBox_prenom.Text = cs2.Champ("PRA_PRENOM").ToString();
                textBox_adresse.Text = cs2.Champ("PRA_ADRESSE").ToString();
                textBox_CP.Text = cs2.Champ("PRA_CP").ToString();
                textBox_ville.Text = cs2.Champ("PRA_VILLE").ToString();
                textBox_coef.Text = cs2.Champ("PRA_COEFNOTORIETE").ToString();
                textBox_lieu.Text = cs2.Champ("TYP_LIBELLE").ToString();
                cbx_tp.SelectedItem = cs2.Champ("TYP_LIBELLE").ToString();
                cs2.Suivant();
            }
            cs2.Fermer();

            //Remplissage du comboBox
            while (!cs3.Fin())
            {
                typePraticiens.Add(cs3.Champ("TYP_CODE").ToString(), cs3.Champ("TYP_LIBELLE").ToString());
                cs3.Suivant();
            }
            cs3.Fermer();

            if (_previous == "RapportVisite")
            {
                btn_modif.Visible = false;
            }
        }


        private void button_Fermer_Click( object sender, EventArgs e )
        {
            Form.ActiveForm.Close();
            if (_previous == "AllPraticiens")
            {
                AllPraticiens ap = new AllPraticiens();
                ap.Show();
                Close();
            }
        }

        //Possibilité de modifier les champs après pression du bouton modifier
        private void btn_modif_Click( object sender, EventArgs e )
        {
            textBox_nom.ReadOnly = false;
            textBox_prenom.ReadOnly = false;
            textBox_adresse.ReadOnly = false;
            textBox_ville.ReadOnly = false;
            textBox_CP.ReadOnly = false;
            textBox_coef.ReadOnly = false;
            btn_maj.Visible = true;
            btn_modif.Visible = false;
            textBox_lieu.Visible = false;
            cbx_tp.Visible = true;
        }

        //Modification des informations suite à la pression du bouton "mettre à jour"
        private void btn_maj_Click( object sender, EventArgs e )
        {
            string numero, nom, prenom, adresse, cp, ville, coefnot, typePraticiens;

            //Récupération des champs et suppression des espaces blancs ("trim()")
            numero = textBox_num.Text.Trim();
            nom = textBox_nom.Text.Trim();
            prenom = textBox_prenom.Text.Trim();
            adresse = textBox_adresse.Text.Trim();
            ville = textBox_ville.Text.Trim();
            cp = textBox_CP.Text.Trim();
            coefnot = textBox_coef.Text.Trim().Replace(',', '.');
            typePraticiens = cbx_tp.SelectedItem.ToString();

            // Remplis les erreurs si il y en a
            dispatchErrors(numero, nom, prenom, adresse, ville, cp, coefnot, typePraticiens);

            // Vérification de champs vides
            if (numero.Length != 0 && nom.Length != 0 && prenom.Length != 0 && adresse.Length != 0 && ville.Length != 0 && cp.Length != 0 && coefnot.Length != 0 && typePraticiens.Length != 0)
            {
                bool error = false;

                // Try parse en numérique
                if (!int.TryParse(cp, out int codePostal))
                {
                    lbl_error_cp.Text = "Veuillez renseigner une valeur numérique";
                    error = true;
                }

                // Si pas d'erreurs
                if (!error)
                {
                    Curs cs = new Curs(connection);

                    // Récupération du type de praticien dans le dictionnaire
                    typePraticiens = this.typePraticiens.FirstOrDefault(x => x.Value == typePraticiens).Key;

                    string req;

                    req = "UPDATE praticien SET PRA_NUM = " + numero + ", PRA_NOM = '" + nom + "', PRA_PRENOM = '" + prenom + "'" +
                    ", PRA_ADRESSE = '" + adresse + "', PRA_VILLE = '" + ville + "', PRA_CP = '" + cp + "', PRA_COEFNOTORIETE = " + coefnot + ", TYP_CODE = '" + typePraticiens + "'" +
                    " WHERE PRA_NUM = " + _NumPraticiens.ToString() + ";";

                    try
                    {
                        //Envoie de la requête pour effectuer la mise à jour
                        cs.ReqAdmin(req);
                        cs.Fermer();

                        //Message de validation si la mise à jour est bonne
                        MessageBox.Show("Mise à jour effectué", "Success lors de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                    catch (Exception)
                    {
                        //Message d'erreur si la mise à jour est ratée
                        lbl_error_general.Text = "Erreur lors de la mise à jour";
                    }
                }
            }

        }

        //Affichage des erreurs
        private void dispatchErrors( string numero, string nom, string prenom, string adresse, string ville, string cp, string coefnot, string lieu )
        {
            // Ternaires affichant les erreurs
            lbl_error_num.Text = nom.Length == 0 ? "Veuillez renseigner un numéro" : "";
            lbl_error_nom.Text = nom.Length == 0 ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = prenom.Length == 0 ? "Veuillez renseigner un prénom" : "";
            lbl_error_adresse.Text = adresse.Length == 0 ? "Veuillez renseigner une adresse" : "";
            lbl_error_ville.Text = ville.Length == 0 ? "Veuillez renseigner une ville" : "";
            lbl_error_cp.Text = cp.Length == 0 ? "Veuillez renseigner un code postal" : "";
            lbl_error_coefnot.Text = nom.Length == 0 ? "Veuillez renseigner un coefficient de notoriété" : "";
            lbl_error_lieu.Text = lieu.Length == 0 ? "Veuillez renseigner un laboratoire" : "";
        }

    }
}
