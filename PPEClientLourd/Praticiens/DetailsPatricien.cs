﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class DetailsPatricien : Form
    {
        string connection = ConnexionDb.chaineConnexion;
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        private string _previous;
        public DetailsPatricien(int NomPatriciens, string previous = "AllPraticiens")
        {

            InitializeComponent();
            _previous = previous;

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
            textBox_num.ReadOnly = false;
            textBox_nom.ReadOnly = false;
            textBox_prenom.ReadOnly = false;
            textBox_adresse.ReadOnly = false;
            textBox_ville.ReadOnly = false;
            textBox_CP.ReadOnly = false;
            textBox_coef.ReadOnly = false;
            textBox_lieu.ReadOnly = false;
            btn_maj.Visible = true;
            btn_modif.Visible = false; 


        }

        private void btn_maj_Click(object sender, EventArgs e)
        {

        }
    }
}
