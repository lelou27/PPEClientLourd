﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class DetailsPatricien : Form
    {
        private string connection = "server=127.0.0.1; DATABASE=applicationppe; user=root; PASSWORD=;SslMode=none";
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        public DetailsPatricien( int NomPatriciens )
        {
            InitializeComponent();

            Curs cs2 = new Curs(connection);
            string requete = "SELECT `praticien`.`PRA_NUM`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM`,`praticien`.`PRA_ADRESSE`,`praticien`.`PRA_CP`,`praticien`.`PRA_VILLE`,`praticien`.`PRA_COEFNOTORIETE`,`type_praticien`.`TYP_LIBELLE` FROM `praticien`,`type_praticien` WHERE `type_praticien`.`TYP_CODE` = `praticien`.`TYP_CODE` AND `praticien`.`PRA_NUM` = " + NomPatriciens.ToString();
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
        private void button_Fermer_Click( object sender, EventArgs e ) => Form.ActiveForm.Close();
    }
}
