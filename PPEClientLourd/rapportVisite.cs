using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class rapportVisite : Form
    {
        private string _colMatricule;
        private string _colNom;
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        private string connection = "server=127.0.0.1; DATABASE=applicationppe; user=root; PASSWORD=;SslMode=none";

        public rapportVisite( string colNom, string colMat )
        {
            InitializeComponent();

            _colNom = colNom;
            _colMatricule = colMat;

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

            //Pour remplir le combobox dans le datagridview presenté des medicaments
            Curs cs2 = new Curs(connection);
            requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
            cs2.ReqSelect(requete);
            while (!cs2.Fin())
            {
                Medicaments.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                cs2.Suivant();
            }
            cs2.Fermer();

            //Pour remplir le combobox dans le datagridview Offert des medicaments
            Curs cs3 = new Curs(connection);
            requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
            cs3.ReqSelect(requete);
            while (!cs3.Fin())
            {
                dataGridViewComboBoxColumn1.Items.Add(cs3.Champ("MED_NOMCOMMERCIAL").ToString());
                cs3.Suivant();
            }
            cs3.Fermer();
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
            Btn_detailsPracticiens.Visible = comboBox_Practiciens.Text == "" || comboBox_Practiciens.Text == null ? false : true;
            label_errPratricien.Text = "";
        }

        private void Btn_detailsPracticiens_Click( object sender, EventArgs e )
        {

            int myKey = praticiens.FirstOrDefault(x => x.Value == comboBox_Practiciens.Text).Key;

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
                string rapMotif = comboBox_Motif.Text == "autre" ? textBox_AutreMotif.Text : comboBox_Motif.Text;
                bool rapConnaissancePatricienFlag = short.TryParse(s: comboBox_connaissancePraticien.Text, result: out short connaissanceP);
                string rapConnaissancePatricien = rapConnaissancePatricienFlag ? connaissanceP.ToString() : "NULL";
                bool rapConnaissanceLaboFlag = short.TryParse(s: comboBox_confianceLabo.Text, result: out short confianceL);
                string rapConnaissanceLabo = rapConnaissancePatricienFlag ? confianceL.ToString() : "NULL";
                string rapDate = Convert.ToDateTime(dateTimePicker_DateRap.Value).ToString("yyyy-MM-dd H:mm:ss");
                string rapDateProVisite = comboBox_NewRDV.Text == "Oui" ? Convert.ToDateTime(dateTimePicker_DateProVisite.Value).ToString("yyyy-MM-dd H:mm:ss") : "NULL";
                string rapPresenceConcurence = "";
                switch (comboBox_presenceconcurrence.Text.Trim())
                {
                    case "Je sais pas":
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
                requete = "SELECT RAP_NUM FROM `rapport_visite`ORDER BY RAP_NUM DESC LIMIT 1;";
                cs2.ReqSelect(requete);
                string rapNum = "";
                int nbRapNum = 0;
                while (!cs2.Fin())
                {
                    nbRapNum = Convert.ToInt32(cs2.Champ("RAP_NUM").ToString());
                    nbRapNum++;
                    cs2.Suivant();
                }

                rapNum = nbRapNum.ToString();
                cs2.Fermer();

                requete = comboBox_NewRDV.Text == "Oui"
                    ? "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`) VALUES ('" + _colMatricule + "', '" + rapNum + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePatricien + ", " + rapConnaissanceLabo + ", '" + rapDate + "', '" + rapDateProVisite + "', " + rapPresenceConcurence + ", " + praNum + ")"
                    : "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`) VALUES ('" + _colMatricule + "', '" + rapNum + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePatricien + ", " + rapConnaissanceLabo + ", '" + rapDate + "', " + rapDateProVisite + ", " + rapPresenceConcurence + ", " + praNum + ")";
                Curs cs = new Curs(connection);
                cs.ReqAdmin(requete);
                cs.Fermer();

                foreach (KeyValuePair<string, int> item in echantillons)
                {
                    Curs echanpre = new Curs(connection);
                    requete = "SELECT `ech_id` FROM `echantillon`, `medicament` WHERE `medicament`.`MED_DEPOTLEGAL`=`echantillon`.`MED_ID` AND `medicament`.`MED_NOMCOMMERCIAL` = '" + item.Key + "'";
                    echanpre.ReqSelect(requete);
                    string echpreid = "";
                    while (!echanpre.Fin())
                    {
                        echpreid = echanpre.Champ("ech_id").ToString();
                        echanpre.Suivant();
                    }
                    echanpre.Fermer();

                    string echprequantite = item.Value.ToString();

                    requete = "insert into `distribuer` (`ech_id`, `col_matricule`, `rap_num`, `quantite`, `offert`, `presente`) values (" + echpreid + ", '" + _colMatricule + "', " + rapNum + ", " + echprequantite + ", false, true)";
                    Curs insertechanpre = new Curs(connection);
                    insertechanpre.ReqAdmin(requete);
                    insertechanpre.Fermer();
                }

                foreach (KeyValuePair<string, int> item in echantillonsOffert)
                {
                    Curs echanoff = new Curs(connection);
                    requete = "SELECT `ech_id` FROM `echantillon`, `medicament` WHERE `medicament`.`MED_DEPOTLEGAL`=`echantillon`.`MED_ID` AND `medicament`.`MED_NOMCOMMERCIAL` = '" + item.Key + "'";
                    echanoff.ReqSelect(requete);
                    string echoffid = "";
                    while (!echanoff.Fin())
                    {
                        echoffid = echanoff.Champ("ech_id").ToString();
                        echanoff.Suivant();
                    }
                    echanoff.Fermer();

                    string echoffquantite = item.Value.ToString();

                    requete = "insert into `distribuer` (`ech_id`, `col_matricule`, `rap_num`, `quantite`, `offert`, `presente`) values (" + echoffid + ", '" + _colMatricule + "', " + rapNum + ", " + echoffquantite + ", true, false)";
                    Curs insertechanoff = new Curs(connection);
                    insertechanoff.ReqAdmin(requete);
                    insertechanoff.Fermer();
                }
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
    }
}
