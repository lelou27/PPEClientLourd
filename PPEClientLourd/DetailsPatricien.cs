using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class DetailsPatricien : Form
    {
        string connection = "server=127.0.0.1; DATABASE=applicationppe; user=root; PASSWORD=;SslMode=none";
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        public DetailsPatricien(int NomPatriciens)
        {

            InitializeComponent();

            Curs cs = new Curs(connection);
            string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
            cs.ReqSelect(requete);
            string Name = "";
            while (!cs.Fin())
            {
                Name = cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString();
                praticiens.Add(Convert.ToInt16(cs.Champ("PRA_NUM").ToString()), Name);
                comboBox_chercher.Items.Add(Name);
                cs.Suivant();
            }

            cs.Fermer();
            Curs cs2 = new Curs(connection);
            requete = "SELECT `praticien`.`PRA_NUM`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM`,`praticien`.`PRA_ADRESSE`,`praticien`.`PRA_CP`,`praticien`.`PRA_VILLE`,`praticien`.`PRA_COEFNOTORIETE`,`type_praticien`.`TYP_LIBELLE` FROM `praticien`,`type_praticien` WHERE `type_praticien`.`TYP_CODE` = `praticien`.`TYP_CODE` AND `praticien`.`PRA_NUM` = " + NomPatriciens.ToString();
            cs2.ReqSelect(requete);
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
                cs2.Suivant();
            }
            cs2.Fermer();

        }

        private void comboBox_chercher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curs cs3 = new Curs(connection);
            int myKey = praticiens.FirstOrDefault(x => x.Value == comboBox_chercher.Text).Key;
            string requete = "SELECT `praticien`.`PRA_NUM`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM`,`praticien`.`PRA_ADRESSE`,`praticien`.`PRA_CP`,`praticien`.`PRA_VILLE`,`praticien`.`PRA_COEFNOTORIETE`,`type_praticien`.`TYP_LIBELLE` FROM `praticien`,`type_praticien` WHERE `type_praticien`.`TYP_CODE` = `praticien`.`TYP_CODE` AND `praticien`.`PRA_NUM` = " + myKey;
            cs3.ReqSelect(requete);
            while (!cs3.Fin())
            {
                textBox_num.Text = cs3.Champ("PRA_NUM").ToString();
                textBox_nom.Text = cs3.Champ("PRA_NOM").ToString();
                textBox_prenom.Text = cs3.Champ("PRA_PRENOM").ToString();
                textBox_adresse.Text = cs3.Champ("PRA_ADRESSE").ToString();
                textBox_CP.Text = cs3.Champ("PRA_CP").ToString();
                textBox_ville.Text = cs3.Champ("PRA_VILLE").ToString();
                textBox_coef.Text = cs3.Champ("PRA_COEFNOTORIETE").ToString();
                textBox_lieu.Text = cs3.Champ("TYP_LIBELLE").ToString();
                cs3.Suivant();
            }
            cs3.Fermer();
        }

        private void button_Fermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
