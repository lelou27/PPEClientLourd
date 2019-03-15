using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class rapportVisite : Form
    {
        private string _colMatricule;
        private string _previous;
        private string _colNom;
        private string _role;
        private string _colMatClic;
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        private string connection = ConnexionDb.chaineConnexion;

        public rapportVisite( string colNom, string colMat, string previous = "Home", int numRap = 0, string colMatClic = "", string role = "" )
        {
            InitializeComponent();
            _previous = previous;
            _colNom = colNom;
            _colMatricule = colMat;
            _colMatClic = colMatClic;
            _role = role;

            if (previous == "Home")
            {
                Btn_detailsPracticiens.Visible = false;
                //Pour remplir le combobox des Pratitiens
                Curs cs = new Curs(connection);
                string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
                cs.ReqSelect(requete);
                string Name = "";
                while (!cs.Fin())
                {
                    Name = cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString();
                    praticiens.Add(Convert.ToInt16(cs.Champ("PRA_NUM").ToString()), Name);
                    comboBox_Practiciens.Items.Add(Name);
                    cs.Suivant();
                }
                cs.Fermer();

                dataGridView_echantillonPresente.ColumnCount = 2;
                dataGridView_echantillonPresente.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dataGridView_echantillonPresente.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                //Pour remplir le combobox dans les datagridview des medicaments
                Curs cs2 = new Curs(connection);
                requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
                cs2.ReqSelect(requete);
                while (!cs2.Fin())
                {
                    Medicaments.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                    dataGridViewComboBoxColumn1.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                    cs2.Suivant();
                }
                cs2.Fermer();
            }
            else if (_previous == "ShowAllRaports")
            {
                Curs cs = new Curs(connection);
                string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
                cs.ReqSelect(requete);
                string Name = "";
                while (!cs.Fin())
                {
                    Name = cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString();
                    praticiens.Add(Convert.ToInt16(cs.Champ("PRA_NUM").ToString()), Name);
                    cs.Suivant();
                }
                cs.Fermer();

                textBox_paticien.Visible = true;
                Btn_detailsPracticiens.Visible = true;
                comboBox_Practiciens.Visible = false;

                textBox_NewRDV.Visible = true;
                comboBox_NewRDV.Visible = false;

                dateTimePicker_DateRap.Enabled = false;

                comboBox_Motif.Visible = false;
                textBox_motif.Visible = true;

                comboBox_presenceconcurrence.Visible = false;
                textBox_concurence.Visible = true;

                comboBox_connaissancePraticien.Visible = false;
                textBox_connaissance.Visible = true;

                dataGridView_echantillonPresente.Visible = false;
                textBox_BilanRap.Enabled = false;
                dateTimePicker_DateProVisite.Enabled = false;
                textBox_AutreMotif.Enabled = false;
                textBox_confiance.Visible = true;
                comboBox_confianceLabo.Visible = false;
                dataGridView_echantillonOffert.Visible = false;
                button_Creer.Visible = false;
                dataGridView_echantillonO.Visible = true;
                dataGridView_echantillonP.Visible = true;
                if (_role == "responsable")
                {
                    requete = "SELECT `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM` FROM `rapport_visite`,`praticien` WHERE `praticien`.`PRA_NUM` = `rapport_visite`.`PRA_NUM`AND  `rapport_visite`.`RAP_NUM` = " + numRap + " AND `rapport_visite`.`COL_MATRICULE` = '" + _colMatClic + "'";
                }
                else
                {
                    requete = "SELECT `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`,`praticien`.`PRA_NOM`,`praticien`.`PRA_PRENOM` FROM `rapport_visite`,`praticien` WHERE `praticien`.`PRA_NUM` = `rapport_visite`.`PRA_NUM`AND  `rapport_visite`.`RAP_NUM` = " + numRap + " AND `rapport_visite`.`COL_MATRICULE` = '" + _colMatricule + "'";
                }

                Curs cs2 = new Curs(connection);
                cs2.ReqSelect(requete);
                while (!cs2.Fin())
                {
                    textBox_paticien.Text = cs2.Champ("PRA_NOM") + " " + cs2.Champ("PRA_PRENOM");
                    bool verifDate = cs2.Champ("RAP_DATE_PROCHAINE_VISITE").ToString() == "" ? false : true;
                    if (!verifDate)
                    {
                        textBox_NewRDV.Text = "Non";
                    }
                    else
                    {
                        textBox_NewRDV.Text = "Oui";
                        DateProVisite.Visible = true;
                        dateTimePicker_DateProVisite.Visible = true;
                        dateTimePicker_DateProVisite.Value = DateTime.Parse(cs2.Champ("RAP_DATE_PROCHAINE_VISITE").ToString());
                    }
                    dateTimePicker_DateRap.Value = DateTime.Parse(cs2.Champ("RAP_DATE").ToString());
                    textBox_motif.Text = cs2.Champ("RAP_MOTIF").ToString();
                    string tessstt = cs2.Champ("RAP_PRESENCE_CONCURENCE").ToString();
                    switch (cs2.Champ("RAP_PRESENCE_CONCURENCE").ToString())
                    {
                        case "":
                            textBox_concurence.Text = "Ne sais pas";
                            break;
                        case "True":
                            textBox_concurence.Text = "Oui";
                            break;
                        case "False":
                            textBox_concurence.Text = "Non";
                            break;
                    }

                    textBox_connaissance.Text = cs2.Champ("RAP_CONNAISSANCE_PRACTICIEN").ToString() == "" ? "Ne sais pas" : cs2.Champ("RAP_CONNAISSANCE_PRACTICIEN").ToString();
                    textBox_BilanRap.Text = cs2.Champ("RAP_BILAN").ToString();
                    textBox_confiance.Text = cs2.Champ("RAP_CONFIANCE_LABO").ToString() == "" ? "Ne sais pas" : cs2.Champ("RAP_CONFIANCE_LABO").ToString();

                    cs2.Suivant();
                }
                cs2.Fermer();

                if (_role == "responsable")
                {
                    requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL`,`distribuer`.`QUANTITE`,`distribuer`.`OFFERT` FROM `distribuer`,`echantillon`,`medicament` WHERE `distribuer`.`RAP_NUM` = " + numRap + " AND `echantillon`.`ECH_ID` = `distribuer`.`ECH_ID` AND `medicament`.`MED_DEPOTLEGAL` = `echantillon`.`MED_ID` AND `distribuer`.`COL_MATRICULE` = '" + _colMatClic + "'";
                }
                else
                {
                    requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL`,`distribuer`.`QUANTITE`,`distribuer`.`OFFERT` FROM `distribuer`,`echantillon`,`medicament` WHERE `distribuer`.`RAP_NUM` = " + numRap + " AND `echantillon`.`ECH_ID` = `distribuer`.`ECH_ID` AND `medicament`.`MED_DEPOTLEGAL` = `echantillon`.`MED_ID` AND `distribuer`.`COL_MATRICULE` = '" + _colMatricule + "'";
                }
                Dictionary<string, int> EchantillionO = new Dictionary<string, int>();
                Dictionary<string, int> EchantillionP = new Dictionary<string, int>();

                Curs cs3 = new Curs(connection);
                cs3.ReqSelect(requete);
                while (!cs3.Fin())
                {
                    string eiqhfdod = cs3.Champ("OFFERT").ToString();
                    if (cs3.Champ("OFFERT").ToString() == "True")
                    {
                        EchantillionO.Add(cs3.Champ("MED_NOMCOMMERCIAL").ToString(), Convert.ToInt16(cs3.Champ("QUANTITE")));
                    }
                    else
                    {
                        EchantillionP.Add(cs3.Champ("MED_NOMCOMMERCIAL").ToString(), Convert.ToInt16(cs3.Champ("QUANTITE")));
                    }
                    cs3.Suivant();
                }
                cs3.Fermer();

                foreach (KeyValuePair<string, int> item in EchantillionO)
                {
                    dataGridView_echantillonO.Rows.Add(item.Key, item.Value);
                }
                foreach (KeyValuePair<string, int> item in EchantillionP)
                {
                    dataGridView_echantillonP.Rows.Add(item.Key, item.Value);
                }

                //if (role == "visiteur")
                //{
                //    button_modifier.Visible = true;
                //}
            }
        }


        private void ComboBox_NewRDV_SelectedIndexChanged( object sender, EventArgs e )
        {
            switch (comboBox_NewRDV.Text)
            {
                case "Non":
                    DateProVisite.Visible = false;
                    dateTimePicker_DateProVisite.Visible = false;
                    break;
                case "Oui":
                    DateProVisite.Visible = true;
                    dateTimePicker_DateProVisite.Visible = true;
                    break;
            }
            label_datepro.Text = "";
        }

        private void ComboBox_Motif_SelectedIndexChanged( object sender, EventArgs e )
        {
            switch (comboBox_Motif.Text)
            {
                case "Autre":
                    AutreMotif.Visible = true;
                    textBox_AutreMotif.Visible = true;
                    break;
                default:
                    AutreMotif.Visible = false;
                    textBox_AutreMotif.Visible = false;
                    break;
            }
            label_motifvisite.Text = "";
            label_autremotif.Text = "";
        }


        private void button_Fermer_Click_1( object sender, EventArgs e ) => Form.ActiveForm.Close();

        private void comboBox_Practiciens_SelectedIndexChanged( object sender, EventArgs e )
        {
            Btn_detailsPracticiens.Visible = true;
            Btn_detailsPracticiens.Show();
            label_errPratricien.Text = "";
        }

        private void Btn_detailsPracticiens_Click( object sender, EventArgs e )
        {
            int myKey;
            if (_previous == "Home")
            {
                myKey = praticiens.FirstOrDefault(x => x.Value == comboBox_Practiciens.Text).Key;
            }
            else
            {
                myKey = praticiens.FirstOrDefault(x => x.Value == textBox_paticien.Text).Key;
            }

            DetailsPatricien DP = new DetailsPatricien(myKey);

            DP.Show();
        }

        private void button_Nouveau_Click( object sender, EventArgs e )
        {
            int err = 0;

            if (comboBox_Practiciens == null || comboBox_Practiciens.Text == "")
            {
                label_errPratricien.Text = "Veuillez choisir un praticien";
                err++;
            }

            if (comboBox_NewRDV.Text == "Oui" && dateTimePicker_DateProVisite.Value < DateTime.Now)
            {
                label_datepro.Text = "Veuillez choisir une date correcte";
                err++;
            }

            if (dateTimePicker_DateRap.Value > DateTime.Now)
            {
                label_DateRap.Text = "Veuillez choisir une date correcte";
                err++;
            }

            if (comboBox_Motif == null || comboBox_Motif.Text == "")
            {
                label_motifvisite.Text = "Veuillez choisir un motif";
                err++;
            }

            if (comboBox_Motif.Text == "Autre" && (textBox_AutreMotif.Text.Trim() == "" || textBox_AutreMotif.Text == null))
            {
                label_autremotif.Text = "Veuillez écrire un motif";
                err++;
            }

            if (textBox_BilanRap.Text.Trim() == "" || textBox_BilanRap.Text == null)
            {
                label_bilan.Text = "Veuillez écrire un bilan";
                err++;
            }

            List<object[]> Result = dataGridView_echantillonPresente.Rows.OfType<DataGridViewRow>().Select(
            r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();

            List<string> erreurs = new List<string>();
            Dictionary<string, int> echantillons = new Dictionary<string, int>();

            Result.RemoveAt(Result.Count - 1);

            foreach (object[] Echan in Result)
            {
                object medoc = Echan.GetValue(0);
                object nbMedoc = Echan.GetValue(1);
                try
                {
                    Convert.ToInt32(nbMedoc.ToString().Trim());
                    echantillons.Add(medoc.ToString(), Convert.ToInt32(nbMedoc.ToString().Trim()));
                }
                catch (Exception)
                {
                    erreurs.Add(medoc.ToString());
                    err++;
                }
            }
            label_errEchanPresente.Text = erreurs.Count != 0 ? ErreurSaisieNbEchan(erreurs) : "";

            List<object[]> ResultOffert = dataGridView_echantillonOffert.Rows.OfType<DataGridViewRow>().Select(
                r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();

            List<string> erreursOffert = new List<string>();
            Dictionary<string, int> echantillonsOffert = new Dictionary<string, int>();

            ResultOffert.RemoveAt(ResultOffert.Count - 1);

            foreach (object[] Echan in ResultOffert)
            {
                object medoc = Echan.GetValue(0);
                object nbMedoc = Echan.GetValue(1);
                try
                {
                    Convert.ToInt32(nbMedoc.ToString().Trim());
                    echantillonsOffert.Add(medoc.ToString(), Convert.ToInt32(nbMedoc.ToString().Trim()));
                }
                catch (Exception)
                {
                    erreursOffert.Add(medoc.ToString());
                    err++;
                }
            }

            label_errechanOffert.Text = erreursOffert.Count != 0 ? ErreurSaisieNbEchan(erreursOffert) : "";

            if (err == 0)
            {
                string dateJour = DateTime.Today.ToString("yyyy-MM-dd H:mm:ss");
                string rapBilan = textBox_BilanRap.Text;
                string rapMotif = comboBox_Motif.Text == "Autre" ? textBox_AutreMotif.Text : comboBox_Motif.Text;
                bool rapConnaissancePatricienFlag = short.TryParse(s: comboBox_connaissancePraticien.Text, result: out short connaissanceP);
                string rapConnaissancePatricien = rapConnaissancePatricienFlag ? connaissanceP.ToString() : "NULL";
                bool rapConnaissanceLaboFlag = short.TryParse(s: comboBox_confianceLabo.Text, result: out short confianceL);
                string rapConnaissanceLabo = rapConnaissancePatricienFlag ? confianceL.ToString() : "NULL";
                string rapDate = Convert.ToDateTime(dateTimePicker_DateRap.Value).ToString("yyyy-MM-dd H:mm:ss");
                string rapDateProVisite = comboBox_NewRDV.Text == "Oui" ? Convert.ToDateTime(dateTimePicker_DateProVisite.Value).ToString("yyyy-MM-dd H:mm:ss") : "NULL";
                string rapPresenceConcurence = "";
                switch (comboBox_presenceconcurrence.Text.Trim())
                {
                    case "Je ne sais pas":
                        rapPresenceConcurence = "NULL";
                        break;
                    case "":
                        rapPresenceConcurence = "NULL";
                        break;
                    case "Oui":
                        rapPresenceConcurence = "True";
                        break;
                    case "Non":
                        rapPresenceConcurence = "False";
                        break;
                }
                string praNum = praticiens.FirstOrDefault(x => x.Value == comboBox_Practiciens.Text).Key.ToString();


                string requete = "";
                Curs cs2 = new Curs(connection);
                requete = "SELECT RAP_NUM FROM `rapport_visite` WHERE `rapport_visite`.`COL_MATRICULE` = '" + _colMatricule + "' ORDER  BY RAP_NUM DESC LIMIT 1";
                cs2.ReqSelect(requete);
                string rapNum = "";
                int nbRapNum = -1;
                while (!cs2.Fin())
                {
                    nbRapNum = Convert.ToInt32(cs2.Champ("RAP_NUM").ToString());
                    nbRapNum++;
                    cs2.Suivant();
                }
                if (nbRapNum == -1)
                {
                    nbRapNum = 1;
                }
                rapNum = nbRapNum.ToString();
                cs2.Fermer();

                requete = comboBox_NewRDV.Text == "Oui"
                    ? "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`) VALUES ('" + _colMatricule + "', '" + rapNum + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePatricien + ", " + rapConnaissanceLabo + ", '" + rapDate + "', '" + rapDateProVisite + "', " + rapPresenceConcurence + ", " + praNum + ")"
                    : "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`) VALUES ('" + _colMatricule + "', '" + rapNum + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePatricien + ", " + rapConnaissanceLabo + ", '" + rapDate + "', " + rapDateProVisite + ", " + rapPresenceConcurence + ", " + praNum + ")";
                Curs cs = new Curs(connection);
                cs.ReqAdmin(requete);
                cs.Fermer();

                Insert_distribuer(echantillons, rapNum, false);
                Insert_distribuer(echantillonsOffert, rapNum, true);

                MessageBox.Show("Votre rapport à été enregistré !");
                Form.ActiveForm.Close();
            }
        }

        private void Insert_distribuer( Dictionary<string, int> ListEchantillon, string rapNum, bool offert )
        {
            foreach (KeyValuePair<string, int> item in ListEchantillon)
            {
                Curs Insert_Distri = new Curs(connection);

                string echoffquantite = item.Value.ToString();
                if (offert)
                {
                    Insert_Distri.DefFonctStockee("insert_distribuer_offert");
                }
                else
                {
                    Insert_Distri.DefFonctStockee("insert_distribuer_presente");
                }

                Insert_Distri.AjouteparametreCol("MED_NOM", item.Key);
                Insert_Distri.DirectionparametreCol("MED_NOM", ParameterDirection.Input);
                Insert_Distri.AjouteparametreCol("COL_MAT", _colMatricule);
                Insert_Distri.DirectionparametreCol("COL_MAT", ParameterDirection.Input);
                Insert_Distri.AjouteparametreCol("RAP_NUM", rapNum);
                Insert_Distri.DirectionparametreCol("RAP_NUM", ParameterDirection.Input);
                Insert_Distri.AjouteparametreCol("QUANTITE", echoffquantite);
                Insert_Distri.DirectionparametreCol("QUANTITE", ParameterDirection.Input);

                Insert_Distri.Appelfonctstockee();
            }
        }

        private string ErreurSaisieNbEchan( List<string> listErr )
        {
            string errResult = "";

            foreach (string err in listErr)
            {
                errResult = listErr.IndexOf(err) == 0 ? "Vérifiez le nombre saisi pour le médicament : " + err : errResult + ", " + err;
            }

            return errResult;
        }

        private void dateTimePicker_DateProVisite_ValueChanged( object sender, EventArgs e ) => label_datepro.Text = "";

        private void dateTimePicker_DateRap_ValueChanged( object sender, EventArgs e ) => label_DateRap.Text = "";

        private void textBox_AutreMotif_TextChanged( object sender, EventArgs e )
        {
            if (textBox_AutreMotif.Text.Trim() != "")
            {
                label_autremotif.Text = "";
            }
        }

        private void textBox_BilanRap_TextChanged( object sender, EventArgs e )
        {
            if (textBox_BilanRap.Text.Trim() != "")
            {
                label_bilan.Text = "";
            }
        }

        private void button_praticien2_Click( object sender, EventArgs e )
        {
            int myKey;
            myKey = praticiens.FirstOrDefault(x => x.Value == comboBox_Practiciens.Text).Key;
            DetailsPatricien DP = new DetailsPatricien(myKey);

            DP.Show();
        }
    }
}
