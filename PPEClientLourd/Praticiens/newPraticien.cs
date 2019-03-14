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
    public partial class newPraticien : Form
    {
        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql
        private Dictionary<string, string> typePraticiens = new Dictionary<string, string>();

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public newPraticien()
        {
            InitializeComponent();
        }

        private void newPraticien_Load(object sender, EventArgs e)
        {
            Curs cs = new Curs(this.chaineConnexion);

            string req = "SELECT TYP_CODE, TYP_LIBELLE FROM type_praticien;";
            cs.ReqSelect(req);

            while(!cs.Fin())
            {
                typePraticiens.Add(cs.Champ("TYP_CODE").ToString(), cs.Champ("TYP_LIBELLE").ToString());
                cbx_typePraticien.Items.Add(cs.Champ("TYP_LIBELLE").ToString());

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            string nom, prenom, adresse, ville, typePraticienLibelle;
            double coefNotoriete;
            int cp;

            nom = txb_nom.Text.ToString().Trim();
            prenom = txb_prenom.Text.ToString().Trim();
            adresse = txb_adresse.Text.ToString().Trim();
            try { cp = Convert.ToInt16(txb_cp.Text.ToString()); } catch (Exception) { lbl_error_cp.Text = "Veuillez renseigner un code postal valide"; cp = 0; };
            ville = txb_ville.Text.ToString().Trim();
            try { typePraticienLibelle = cbx_typePraticien.SelectedItem.ToString(); } catch(Exception) { typePraticienLibelle = ""; lbl_error_typePraticien.Text = "Veuillez choisir une option"; }
            try { coefNotoriete = Convert.ToDouble(txb_coefNotoriete.Text.ToString()); } catch (Exception) { lbl_error_notoriete.Text = "Veuillez renseigner une valeur numérique"; coefNotoriete = 0; };

            bool error = this.dispatchErrors(nom, prenom, ville, cp, adresse, typePraticienLibelle, coefNotoriete);

            if(!error)
            {
                string codeTypePraticien = this.typePraticiens.FirstOrDefault(x => x.Value == typePraticienLibelle).Key;

                Curs cs = new Curs(this.chaineConnexion);

                string coefNotorieteConvert = coefNotoriete.ToString().Replace(',', '.').ToString(); ;

                string req = "INSERT INTO praticien(PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE) " +
                            " VALUES ('"+nom+"', '"+prenom+"', '"+adresse+"', "+cp+", '"+ville+"', "+ coefNotorieteConvert + ", '"+codeTypePraticien+"');";
              
                try
                {
                    cs.ReqAdmin(req);

                    MessageBox.Show("Succès lors de l'enregistrement", "Enregistrement éffectué", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch(Exception erreur)
                {
                    lbl_error_general.Text = "Erreur lors de l'insertion du praticien " + erreur.Message;
                }

                cs.Fermer();
            }
        }

        private bool dispatchErrors(string nom, string prenom, string ville, int cp, string adresse, string typePraticien
                                    , double coefNotoriete)
        {
            bool error = false;

            lbl_errorNom.Text = (nom.Length == 0) ? "Veuillez renseigner un nom" : "";
            lbl_error_prenom.Text = (prenom.Length == 0) ? "Veuillez renseigner un prénom" : "";
            lbl_error_ville.Text = (ville.Length == 0) ? "Veuillez renseigner une ville" : "";
            lbl_error_cp.Text = (cp == 0) ? "Veuillez renseigner un code postal" : "";
            lbl_error_adresse.Text = (adresse.Length == 0) ? "Veuillez renseigner une adresse" : "";
            lbl_error_typePraticien.Text = (typePraticien.Length == 0) ? "Veuillez renseigner un type de praticien" : "";
            lbl_error_notoriete.Text = (coefNotoriete == 0) ? "Veuillez renseigner un coefficient de notoriété" : "";

            if (nom.Length == 0 || prenom.Length == 0 || ville.Length == 0 || cp == 0 || adresse.Length == 0 || typePraticien.Length == 0
                || coefNotoriete == 0)
                error = true;
            

            return error;
        }
    }
}
