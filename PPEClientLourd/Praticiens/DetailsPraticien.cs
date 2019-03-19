using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class DetailsPraticien : Form
    {
        string connection = ConnexionDb.chaineConnexion;
        private Dictionary<string, string> typePraticiens = new Dictionary<string, string>();
        private string _previous;
        private int _NumPraticiens;
        public DetailsPraticien(int NumPraticiens, string previous = "AllPraticiens")
        {
            
            InitializeComponent();
            _previous = previous;
            _NumPraticiens = NumPraticiens;

            Curs cs2 = new Curs(connection);
            string requete = "SELECT praticien.`PRA_NUM`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM`,`praticien`.`PRA_ADRESSE`,`praticien`.`PRA_CP`,`praticien`.`PRA_VILLE`,`praticien`.`PRA_COEFNOTORIETE`,`type_praticien`.`TYP_LIBELLE` FROM praticien,`type_praticien` WHERE type_praticien.`TYP_CODE` = praticien.`TYP_CODE` AND praticien.`PRA_NUM` = " + NumPraticiens.ToString();
            Curs cs3 = new Curs(connection);
            string req = "SELECT TYP_CODE, TYP_LIBELLE FROM type_praticien;";

            cs2.ReqSelect(requete);
            cs3.ReqSelect(req);
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

            while (!cs3.Fin())
            {
                typePraticiens.Add(cs3.Champ("TYP_CODE").ToString(), cs3.Champ("TYP_LIBELLE").ToString());
                cs3.Suivant();
            }
            cs3.Fermer();


        }



        private void addItemsToTypePraticiens(string tpCode)
         {
             Curs cs = new Curs(this.connection);

             cs.ReqSelect("SELECT TYP_CODE, TYP_LIBELLE FROM type_praticien");

             while (!cs.Fin())
             {
                 this.typePraticiens.Add(cs.Champ("TYP_CODE").ToString(), cs.Champ("TYP_LIBELLE").ToString());

                 cbx_tp.Items.Add(cs.Champ("TYP_LIBELLE").ToString());

                 if (tpCode == cs.Champ("TYP_CODE").ToString())
                     cbx_tp.SelectedItem = cs.Champ("TYP_LIBELLE").ToString();

                 cs.Suivant();
             }
             cs.Fin();
         }


        private void button_Fermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            if (_previous == "AllPraticiens")
            {
                AllPraticiens ap = new AllPraticiens();
                ap.Show();
                this.Close();
            }
        }

        private void btn_modif_Click(object sender, EventArgs e)
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

        private void btn_maj_Click(object sender, EventArgs e)
        {
            string numero, nom, prenom, adresse, cp, ville, coefnot, typePraticiens;
            int codePostal;


            numero = textBox_num.Text.Trim();
            nom = textBox_nom.Text.Trim();
            prenom = textBox_prenom.Text.Trim();
            adresse = textBox_adresse.Text.Trim();
            ville = textBox_ville.Text.Trim();
            cp = textBox_CP.Text.Trim();
            coefnot = textBox_coef.Text.Trim().Replace(',' , '.');
            typePraticiens = cbx_tp.SelectedItem.ToString();

            this.dispatchErrors(numero, nom, prenom, adresse, ville, cp, coefnot, typePraticiens);
            if (numero.Length != 0 && nom.Length != 0 && prenom.Length != 0 && adresse.Length != 0 && ville.Length != 0 && cp.Length != 0 && coefnot.Length != 0 && typePraticiens.Length != 0)
            {
                bool error = false;

                if (!Int32.TryParse(cp, out codePostal))
                {
                    lbl_error_cp.Text = "Veuillez renseigner une valeur numérique";
                    error = true;
                }

                if (!error)
                {
                    Curs cs = new Curs(this.connection);

                    typePraticiens = this.typePraticiens.FirstOrDefault(x => x.Value == typePraticiens).Key;

                    string req;

                        req = "UPDATE praticien SET PRA_NUM = " + numero + ", PRA_NOM = '" + nom + "', PRA_PRENOM = '" + prenom + "'" +
                        ", PRA_ADRESSE = '" + adresse + "', PRA_VILLE = '" + ville + "', PRA_CP = '" + cp + "', PRA_COEFNOTORIETE = " + coefnot + ", TYP_CODE = '" + typePraticiens + "'" +
                        " WHERE PRA_NUM = " + _NumPraticiens.ToString() + ";";

                    try
                    {
                        cs.ReqAdmin(req);
                        cs.Fermer();

                        MessageBox.Show("Mise à jour effectué", "Success lors de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception)
                    {
                        lbl_error_general.Text = "Erreur lors de la mise à jour";
                    }
                }
            }

        }

        private void dispatchErrors(string numero, string nom, string prenom, string adresse, string ville, string cp, string coefnot, string lieu)
        {
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
