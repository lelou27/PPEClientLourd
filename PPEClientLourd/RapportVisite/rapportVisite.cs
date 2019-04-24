using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{

    public partial class RapportVisite : Form
    {
        //création des variables
        private string connection = ConnexionDb.chaineConnexion, _colMatricule, _previous, _colNom, _role, _colMatClic;
        private int _numRap;
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        private Dictionary<string, int> echantillonsPresente = new Dictionary<string, int>();
        private Dictionary<string, int> echantillonsOffert = new Dictionary<string, int>();
        private DateTime test;

        /// <summary>
        /// Création, Affichage et Modification d'un rapport de visite
        /// </summary>
        /// <param name="colNom">Nom du collaborateur connecté</param>
        /// <param name="colMat">Matricule du collaborateur connecté</param>
        /// <param name="previous">"Home" pour création, "ShowAllRaports" pour affichage, "Modif" pour modification</param>
        /// <param name="numRap">Le numéro du rapport (affichage/modification)</param>
        /// <param name="colMatClic">Le matricule du collaborateur sélectionné (affichage/modification)</param>
        /// <param name="role">Le rôle du collaborateur sélectionné (affichage/modification)</param>
        public RapportVisite( string colNom, string colMat, string previous = "Home", int numRap = 0, string colMatClic = "", string role = "" )
        {
            InitializeComponent();
            //On remplit les variables
            _previous = previous;
            _colNom = colNom;
            _colMatricule = colMat;
            _numRap = numRap;
            _colMatClic = colMatClic;
            _role = role;

            //Si on vient de la page d'accueil
            if (_previous == "Home")
            {
                Add_comboBox_Praticiens();
                Btn_detailsPracticiens.Visible = false;
                Add_comboBox_Medicament();
            }
            //Si on vient de la page ShowAllRapport
            else if (_previous == "ShowAllRaports")
            {
                //Combobox
                comboBox_Praticiens.Enabled = false;
                comboBox_Motif.Enabled = false;
                comboBox_presenceconcurrence.Enabled = false;
                comboBox_connaissancePraticien.Enabled = false;
                comboBox_NewRDV.Enabled = false;
                comboBox_confianceLabo.Enabled = false;
                //Bouton
                Btn_detailsPracticiens.Visible = true;
                button_Creer.Visible = false;
                //DateTime
                dateTimePicker_DateRap.Enabled = false;
                dateTimePicker_DateProVisite.Enabled = false;
                //TextBox
                textBox_BilanRap.Enabled = false;
                textBox_AutreMotif.Enabled = false;
                //DatagridViewOffert
                dataGridView_echantillonOffert.Enabled = false;
                //DatagridViewPresente
                dataGridView_echantillonPresente.Enabled = false;

                Add_comboBox_Praticiens();
                Add_allChamp();
                Add_comboBox_Medicament();
                Prefill_Medicament();

                if (_colMatClic == colMat)
                {
                    button_modifier.Visible = true;
                }
            }
            //Si on choisit de modifier le rapport
            else if (_previous == "Modif")
            {
                button_Creer.Visible = false;
                button_modifier.Visible = true;
                Add_comboBox_Praticiens();
                Add_allChamp();
                Add_comboBox_Medicament();
                Prefill_Medicament();
            }
        }

        /// <summary>
        /// Rempli le dataGridViewComboBox pour médicaments présentés et offerts
        /// </summary>
        private void Add_comboBox_Medicament()
        {
            Curs cs2 = new Curs(connection);
            string requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` " +
                "FROM `medicament` " +
                "ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
            cs2.ReqSelect(requete);
            while (!cs2.Fin())
            {
                Medicaments.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                dataGridViewComboBoxColumn1.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                cs2.Suivant();
            }
            cs2.Fermer();
        }
        /// <summary>
        /// Rempli le dictionnaire de données des praticiens et rempli le comboBox_Praticiens
        /// </summary>
        private void Add_comboBox_Praticiens()
        {
            string Name = "";
            Curs cs = new Curs(connection);
            string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM`" +
                " FROM `praticien`" +
                " ORDER BY `praticien`.`PRA_NOM`";
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                Name = cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString();
                praticiens.Add(Convert.ToInt16(cs.Champ("PRA_NUM").ToString()), Name);
                comboBox_Praticiens.Items.Add(Name);
                cs.Suivant();
            }
            cs.Fermer();
        }
        /// <summary>
        /// Rempli tout les champs sauf les dataGridViews
        /// </summary>
        private void Add_allChamp()
        {
            string requete = "SELECT `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`,`PRA_NUM`" +
                " FROM `rapport_visite`" +
                " WHERE `rapport_visite`.`RAP_NUM` = " + _numRap +
                " AND `rapport_visite`.`COL_MATRICULE` = '";

            if (_role == "responsable")
            {
                requete += _colMatClic + "'";
            }
            else
            {
                requete += _colMatricule + "'";
            }

            Curs cs2 = new Curs(connection);
            cs2.ReqSelect(requete);
            while (!cs2.Fin())
            {
                //comboBox
                comboBox_connaissancePraticien.SelectedItem = cs2.Champ("RAP_CONNAISSANCE_PRACTICIEN").ToString() == "" ? "Je ne sais pas" : cs2.Champ("RAP_CONNAISSANCE_PRACTICIEN").ToString();
                comboBox_confianceLabo.SelectedItem = cs2.Champ("RAP_CONFIANCE_LABO").ToString() == "" ? "Je ne sais pas" : cs2.Champ("RAP_CONFIANCE_LABO").ToString();
                comboBox_Praticiens.SelectedItem = praticiens[Convert.ToInt16(cs2.Champ("PRA_NUM").ToString())];
                comboBox_Motif.SelectedItem = cs2.Champ("RAP_MOTIF").ToString();
                //Textbox
                textBox_BilanRap.Text = cs2.Champ("RAP_BILAN").ToString();
                //dateTime
                
                try
                {
                    dateTimePicker_DateRap.Value = DateTime.Parse(cs2.Champ("RAP_DATE_VISITE").ToString());
                }
                catch (Exception)
                {
                    DateTime.TryParse(cs2.Champ("RAP_DATE_VISITE").ToString(),out test);
                    dateTimePicker_DateRap.Value = test.AddYears(1980);
                }



                bool verifDate = cs2.Champ("RAP_DATE_PROCHAINE_VISITE").ToString() == "" ? false : true;
                if (!verifDate)
                {
                    comboBox_NewRDV.SelectedItem = "Non";
                }
                else
                {
                    comboBox_NewRDV.SelectedItem = "Oui";
                    DateProVisite.Visible = true;
                    dateTimePicker_DateProVisite.Visible = true;
                    dateTimePicker_DateProVisite.Value = DateTime.Parse(cs2.Champ("RAP_DATE_PROCHAINE_VISITE").ToString());
                }

                if (comboBox_Motif.Text.Trim() == "")
                {
                    comboBox_Motif.SelectedItem = "Autre";
                    textBox_AutreMotif.Visible = true;
                    textBox_AutreMotif.Text = cs2.Champ("RAP_MOTIF").ToString();
                }
                switch (cs2.Champ("RAP_PRESENCE_CONCURENCE").ToString())
                {
                    case "":
                        comboBox_presenceconcurrence.SelectedItem = "Je ne sais pas";
                        break;
                    case "True":
                        comboBox_presenceconcurrence.SelectedItem = "Oui";
                        break;
                    case "False":
                        comboBox_presenceconcurrence.SelectedItem = "Non";
                        break;
                }
                cs2.Suivant();
            }
            cs2.Fermer();
        }
        /// <summary>
        /// Requetes nécessaire pour remplir les dataGridViews selon un numéro de rapport
        /// </summary>
        private void Prefill_Medicament()
        {
            string requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL`,`distribuer`.`QUANTITE`,`distribuer`.`OFFERT`" +
                " FROM `distribuer`,`echantillon`,`medicament`" +
                " WHERE `distribuer`.`RAP_NUM` = " + _numRap +
                " AND `echantillon`.`ECH_ID` = `distribuer`.`ECH_ID`" +
                " AND `medicament`.`MED_DEPOTLEGAL` = `echantillon`.`MED_ID`" +
                " AND `distribuer`.`COL_MATRICULE` = '";

            string Medicament = "";
            int NbMedicament = 0, indexOffert = 0, IndexPresente = 0;

            if (_role == "responsable")
            {
                requete += _colMatClic + "'";
            }
            else
            {
                requete += _colMatricule + "'";
            }

            Curs cs3 = new Curs(connection);
            cs3.ReqSelect(requete);
            while (!cs3.Fin())
            {
                Medicament = cs3.Champ("MED_NOMCOMMERCIAL").ToString();
                NbMedicament = Convert.ToInt16(cs3.Champ("QUANTITE"));
                if (cs3.Champ("OFFERT").ToString() == "True")
                {
                    Fill_Combobox_Medicament(dataGridView_echantillonOffert, Medicament, NbMedicament, indexOffert);
                    indexOffert++;
                }
                else
                {
                    Fill_Combobox_Medicament(dataGridView_echantillonPresente, Medicament, NbMedicament, IndexPresente);
                    IndexPresente++;
                }
                cs3.Suivant();
            }
            cs3.Fermer();
        }
        /// <summary>
        /// Rempli un dataGridView avec un nom de médicament, un nombre entier de médicament et un numéro de ligne
        /// </summary>
        /// <param name="dataGridView">Le dataGridView à remplir</param>
        /// <param name="Medoc">Le nom du médicament</param>
        /// <param name="nbMedoc">Le nombre de médicament</param>
        /// <param name="nbRows">Le numéro de la ligne</param>
        private void Fill_Combobox_Medicament( DataGridView dataGridView, string Medoc, int nbMedoc, int nbRows )
        {
            dataGridView.Rows.Add();
            dataGridView[0, nbRows].Value = Medoc;
            dataGridView[1, nbRows].Value = nbMedoc;
        }
        /// <summary>
        /// Permet la saisie des erreurs pour les médicaments
        /// </summary>
        /// <param name="listErr">Liste des médicaments aec erreurs</param>
        /// <returns>Le message d'erreur</returns>
        private string ErreurSaisieNbEchan( List<string> listErr )
        {
            string errResult = "";

            foreach (string err in listErr)
            {
                errResult = listErr.IndexOf(err) == 0 ? "Vérifiez le nombre saisi pour le médicament : " + err : errResult + ", " + err;
            }

            return errResult;
        }
        /// <summary>
        /// Permet de calculer le nombre d'erreur lors de la saisie lors de la création
        /// </summary>
        /// <returns>Le nombre d'erreur</returns>
        private int DispatchErrors_Creer()
        {
            int Error = 0;

            //ComboBox
            Error += Gestion_erreur_comboBox_Praticiens();
            Error += Gestion_erreur_comboBox_Motif();
            //DateTime
            Error += GetGestion_erreur_dateTimePicker_DateRap();
            Error += Gestion_erreur_dateTimePicker_DateProVisite();
            //TextBox
            Error += Gestion_erreur_textBox_AutreMotif();
            Error += Gestion_erreur_textBox_BilanRap();

            return Error;
        }
        /// <summary>
        /// Permet de calculer le nombre d'erreur lors de la saisie lors de la modification
        /// </summary>
        /// <returns>Le nombre d'erreur</returns>
        private int DispatchErrors_Modif()
        {
            int Error = 0;

            //ComboBox
            Error += Gestion_erreur_comboBox_Praticiens();
            Error += Gestion_erreur_comboBox_Motif();
            //TextBox
            Error += Gestion_erreur_textBox_AutreMotif();
            Error += Gestion_erreur_textBox_BilanRap();

            return Error;
        }
        /// <summary>
        /// Lance les tests afin de vérifier les erreurs
        /// </summary>
        /// <param name="Action">"Creer" pour vérifier la création et "Modif" pour vérifier la modification</param>
        /// <returns>Le nombre d'erreur</returns>
        private int Verif_error( string Action )
        {
            int err = 0;
            if (Action == "Creer")
            {
                err += DispatchErrors_Creer();
            }
            else if (Action == "Modif")
            {
                err += DispatchErrors_Modif();
            }
            err += SetDatasInDictionnarys(dataGridView_echantillonOffert, true);
            err += SetDatasInDictionnarys(dataGridView_echantillonPresente, false);

            return err;
        }
        /// <summary>
        /// Permet d'insérer dans la table distribuer
        /// </summary>
        /// <param name="ListEchantillon">Le dictionnaire d'échantillon</param>
        /// <param name="rapNum">Le numéro du rapport</param>
        /// <param name="offert">true si l'échantillon est offert</param>
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
        /// <summary>
        /// Permet de remplir les dictionnaires d'échantillon et calcule le nombre d'erreur
        /// </summary>
        /// <param name="dataGrid">Le dataGridView d'origine</param>
        /// <param name="offert">true si l'échantillon est offert</param>
        /// <returns></returns>
        private int SetDatasInDictionnarys( DataGridView dataGrid, bool offert )
        {
            int Error = 0;

            List<object[]> Result = dataGrid.Rows.OfType<DataGridViewRow>().Select(
                r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();

            List<string> erreurs = new List<string>();

            Result.RemoveAt(Result.Count - 1);
            Dictionary<string, int> tempEchantillon = new Dictionary<string, int>();

            foreach (object[] Echan in Result)
            {
                object medoc = Echan.GetValue(0);
                object nbMedoc = Echan.GetValue(1);
                if (medoc == null)
                {
                    Error += 1;
                }
                else
                {
                    try
                    {
                        int nbMedic = Convert.ToInt32(nbMedoc.ToString().Trim());
                        if (!tempEchantillon.ContainsKey(medoc.ToString()))
                        {
                            if (nbMedic > 0)
                            {
                                tempEchantillon.Add(medoc.ToString(), nbMedic);
                            }
                            else if (nbMedic != 0)
                            {
                                erreurs.Add(medoc.ToString());
                                Error += 1;
                            }
                        }
                        else
                        {
                            tempEchantillon[medoc.ToString()] += nbMedic;
                        }
                    }
                    catch (Exception)
                    {
                        erreurs.Add(medoc.ToString());
                        Error += 1;
                    }
                }
            }
            if (offert)
            {
                echantillonsOffert = tempEchantillon;
                label_errechanOffert.Text = erreurs.Count != 0 ? ErreurSaisieNbEchan(erreurs) : "";
            }
            else
            {
                echantillonsPresente = tempEchantillon;
                label_errEchanPresente.Text = erreurs.Count != 0 ? ErreurSaisieNbEchan(erreurs) : "";
            }

            return Error;
        }
        
        private void DateTimePicker_DateProVisite_ValueChanged( object sender, EventArgs e ) => label_datepro.Text = "";
        private void DateTimePicker_DateRap_ValueChanged( object sender, EventArgs e ) => label_DateRap.Text = "";
        private void TextBox_AutreMotif_TextChanged( object sender, EventArgs e )
        {
            if (textBox_AutreMotif.Text.Trim() != "")
            {
                label_autremotif.Text = "";
            }
        }
        private void TextBox_BilanRap_TextChanged( object sender, EventArgs e )
        {
            if (textBox_BilanRap.Text.Trim() != "")
            {
                label_bilan.Text = "";
            }
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
        private void ComboBox_Practiciens_SelectedIndexChanged( object sender, EventArgs e )
        {
            Btn_detailsPracticiens.Visible = true;
            Btn_detailsPracticiens.Show();
            label_errPratricien.Text = "";
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

        private void Btn_detailsPracticiens_Click( object sender, EventArgs e )
        {
            int myKey;
            myKey = Convert.ToInt16(Recup_comboBox_Praticiens());
            DetailsPraticien DP = new DetailsPraticien(myKey, "RapportVisite");

            DP.Show();
        }
        private void Button_praticien2_Click( object sender, EventArgs e )
        {
            int myKey;
            myKey = Convert.ToInt16(Recup_comboBox_Praticiens());
            DetailsPraticien DP = new DetailsPraticien(myKey, "RapportVisite");

            DP.Show();
        }
        private void Button_Nouveau_Click( object sender, EventArgs e )
        {
            int Error = Verif_error("Creer");

            if (Error == 0)
            {
                string dateJour = DateTime.Today.ToString("yyyy-MM-dd H:mm:ss");
                List<string> Recup_All_Value = new List<string>();
                Recup_All_Value = Recup_All();
                string requete = "";

                string rapBilan = Recup_All_Value[0];
                string rapMotif = Recup_All_Value[1];
                string rapConnaissancePraticien = Recup_All_Value[2];
                string rapConnaissanceLabo = Recup_All_Value[3];
                string rapDate = Recup_All_Value[4];
                string rapDateProVisite = Recup_All_Value[5];
                string rapPresenceConcurence = Recup_All_Value[6];
                string praNum = Recup_All_Value[7];
                string rapNum = Recup_All_Value[8];

                requete = "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`," +
                    " `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`)" +
                    " VALUES ('" + _colMatricule + "', '" + rapNum + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePraticien +
                    ", " + rapConnaissanceLabo + ", '" + rapDate + "',";
                requete += comboBox_NewRDV.Text == "Oui"
                    ? "'" + rapDateProVisite + "'"
                    : rapDateProVisite;
                requete += ", " + rapPresenceConcurence + ", " + praNum + ")";

                Curs cs = new Curs(connection);
                cs.ReqAdmin(requete);
                cs.Fermer();

                Insert_distribuer(echantillonsPresente, rapNum, false);
                Insert_distribuer(echantillonsOffert, rapNum, true);

                MessageBox.Show("Votre rapport à été enregistré !");
                Form.ActiveForm.Close();
            }
        }
        private void Button_modifier_Click( object sender, EventArgs e )
        {
            if (_previous == "ShowAllRaports")
            {
                RapportVisite rapport_modif = new RapportVisite(_colNom, _colMatricule, "Modif", _numRap);
                Hide();
                rapport_modif.Show();
            }
            else
            {
                int Error = Verif_error("Modif");

                if (Error == 0)
                {
                    string dateJour = DateTime.Today.ToString("yyyy-MM-dd H:mm:ss");
                    List<string> Recup_All_Value = new List<string>();
                    Recup_All_Value = Recup_All();
                    string requete = "";

                    string rapBilan = Recup_All_Value[0];
                    string rapMotif = Recup_All_Value[1];
                    string rapConnaissancePraticien = Recup_All_Value[2];
                    string rapConnaissanceLabo = Recup_All_Value[3];
                    string rapDate = Recup_All_Value[4];
                    string rapDateProVisite = Recup_All_Value[5];
                    string rapPresenceConcurence = Recup_All_Value[6];
                    string praNum = Recup_All_Value[7];
                    string rapNum = Recup_All_Value[8];

                    requete = "UPDATE `rapport_visite` " +
                        "SET `COL_MATRICULE`='" + _colMatricule + "',`RAP_NUM`='" + rapNum + "',`RAP_DATE`='" + dateJour + "',`RAP_BILAN`='" + rapBilan + "',`RAP_MOTIF`='" + rapMotif + "',`RAP_CONNAISSANCE_PRACTICIEN`=" + rapConnaissancePraticien + ",`RAP_CONFIANCE_LABO`=" + rapConnaissanceLabo + ",`RAP_DATE_VISITE`='" + rapDate + "',`RAP_DATE_PROCHAINE_VISITE`= ";
                    requete += comboBox_NewRDV.Text == "Oui"
                       ? "'" + rapDateProVisite + "'"
                       : rapDateProVisite;
                    requete += ", `RAP_PRESENCE_CONCURENCE`=" + rapPresenceConcurence + ",`PRA_NUM`='" + praNum + "' WHERE `COL_MATRICULE` = '" + _colMatricule + "' AND `RAP_NUM` ='" + rapNum + "'";

                    Curs cs = new Curs(connection);
                    cs.ReqAdmin(requete);
                    cs.Fermer();

                    requete = "DELETE FROM `distribuer`" +
                        " WHERE `distribuer`.`COL_MATRICULE` ='" + _colMatricule + "'" +
                        " AND `distribuer`.`RAP_NUM` =" + rapNum;

                    Curs cs2 = new Curs(connection);
                    cs2.ReqAdmin(requete);
                    cs2.Fermer();

                    Insert_distribuer(echantillonsOffert, rapNum, true);
                    Insert_distribuer(echantillonsPresente, rapNum, false);

                    MessageBox.Show("Votre rapport à été modifié !");
                    Form.ActiveForm.Close();
                }
            }
        }
        private void Button_Fermer_Click_1( object sender, EventArgs e ) => ActiveForm.Close();

        /// <summary>
        /// Permet de récupérer tout les valeurs
        /// </summary>
        /// <returns>Une liste de toutes valeurs</returns>
        private List<string> Recup_All()
        {
            string requete;
            string rapNum = "";
            int nbRapNum = -1;
            List<string> Result = new List<string>();

            foreach (KeyValuePair<string, int> item in echantillonsOffert)
            {
                if (echantillonsPresente.ContainsKey(item.Key))
                {
                    echantillonsPresente.Remove(item.Key);
                }
            }
            Curs cs2 = new Curs(connection);
            requete = "SELECT RAP_NUM" +
                " FROM `rapport_visite`" +
                " WHERE `rapport_visite`.`COL_MATRICULE` = '" + _colMatricule +
                "' ORDER  BY RAP_NUM DESC LIMIT 1";
            cs2.ReqSelect(requete);
            while (!cs2.Fin())
            {
                nbRapNum = Convert.ToInt32(cs2.Champ("RAP_NUM").ToString());
                if (_previous != "Modif")
                {
                    nbRapNum++;
                }
                cs2.Suivant();
            }
            cs2.Fermer();
            if (nbRapNum == -1)
            {
                nbRapNum = 1;
            }
            rapNum = nbRapNum.ToString();

            Result.Add(Recup_textBox_BilanRap());
            Result.Add(Recup_comboBox_Motif());
            Result.Add(Recup_comboBox_connaissancePraticien());
            Result.Add(Recup_comboBox_confianceLabo());
            Result.Add(Recup_dateTimePicker_DateRap());
            Result.Add(Recup_dateTimePicker_DateProVisite());
            Result.Add(Recup_comboBox_presenceconcurrence());
            Result.Add(Recup_comboBox_Praticiens());
            Result.Add(rapNum);

            return Result;
        }
        //textBox
        /// <summary>
        /// Récupère la valeur du textBox_BilanRap
        /// </summary>
        /// <returns>string du textBox_BilanRap</returns>
        private string Recup_textBox_BilanRap() => textBox_BilanRap.Text;
        //comboBox
        /// <summary>
        /// Récupère la valeur du comboBox_Praticiens
        /// </summary>
        /// <returns></returns>
        private string Recup_comboBox_Praticiens() => praticiens.FirstOrDefault(x => x.Value == comboBox_Praticiens.Text).Key.ToString();
        /// <summary>
        /// Récupère la valeur du comboBox_Motif ou textBox_AutreMotif
        /// </summary>
        /// <returns>string du comboBox_Motif ou textBox_AutreMotif</returns>
        private string Recup_comboBox_Motif() => comboBox_Motif.Text == "Autre" ? textBox_AutreMotif.Text.Trim().Replace("'"," ") : comboBox_Motif.Text;
        /// <summary>
        /// Récupère la valeur du comboBox_connaissancePraticien
        /// </summary>
        /// <returns>string du comboBox_connaissancePraticien</returns>
        private string Recup_comboBox_connaissancePraticien()
        {
            bool rapConnaissancePraticienFlag = short.TryParse(s: comboBox_connaissancePraticien.Text.Trim().Replace("'", " "), result: out short connaissanceP);
            return rapConnaissancePraticienFlag ? connaissanceP.ToString() : "NULL";
        }
        /// <summary>
        /// Récupère la valeur du comboBox_confianceLabo
        /// </summary>
        /// <returns>string du comboBox_confianceLabo</returns>
        private string Recup_comboBox_confianceLabo()
        {
            bool rapConnaissanceLaboFlag = short.TryParse(s: comboBox_confianceLabo.Text, result: out short confianceL);
            return rapConnaissanceLaboFlag ? confianceL.ToString() : "NULL";
        }
        /// <summary>
        /// Récupère la valeur du comboBox_presenceconcurrence
        /// </summary>
        /// <returns>string du comboBox_presenceconcurrence</returns>
        private string Recup_comboBox_presenceconcurrence()
        {
            switch (comboBox_presenceconcurrence.Text.Trim())
            {
                case "Je ne sais pas":
                    return "NULL";
                case "":
                    return "NULL";
                case "Oui":
                    return "True";
                case "Non":
                    return "False";
            }
            return "NULL";
        }
        //DateTime
        /// <summary>
        /// Récupère la valeur du dateTimePicker_DateRap
        /// </summary>
        /// <returns>string du dateTimePicker_DateRap</returns>
        private string Recup_dateTimePicker_DateRap() => Convert.ToDateTime(dateTimePicker_DateRap.Value).ToString("yyyy-MM-dd H:mm:ss");
        /// <summary>
        /// Récupère la valeur du dateTimePicker_DateProVisite
        /// </summary>
        /// <returns>string du dateTimePicker_DateProVisite</returns>
        private string Recup_dateTimePicker_DateProVisite() => comboBox_NewRDV.Text == "Oui" ? Convert.ToDateTime(dateTimePicker_DateProVisite.Value).ToString("yyyy-MM-dd H:mm:ss") : "NULL";

        /// <summary>
        /// Gestion d'erreur sur comboBox_Praticiens
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int Gestion_erreur_comboBox_Praticiens()
        {
            int Err = 0;
            if (comboBox_Praticiens == null || comboBox_Praticiens.Text == "")
            {
                label_errPratricien.Text = "Veuillez choisir un praticien";
                Err = 1;
            }
            return Err;
        }
        /// <summary>
        /// Gestion d'erreur sur comboBox_Motif
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int Gestion_erreur_comboBox_Motif()
        {
            int Err = 0;
            if (comboBox_Motif == null || comboBox_Motif.Text == "")
            {
                label_motifvisite.Text = "Veuillez choisir un motif";
                Err = 1;
            }
            return Err;
        }
        /// <summary>
        /// Gestion d'erreur sur dateTimePicker_DateRap
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int GetGestion_erreur_dateTimePicker_DateRap()
        {
            int Err = 0;
            if (dateTimePicker_DateRap.Value.DayOfYear > DateTime.Now.DayOfYear)
            {
                label_DateRap.Text = "Veuillez choisir une date correcte";
                Err = 1;
            }
            return Err;
        }
        /// <summary>
        /// Gestion d'erreur sur dateTimePicker_DateProVisite
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int Gestion_erreur_dateTimePicker_DateProVisite()
        {
            int Err = 0;
            if (comboBox_NewRDV.Text == "Oui" && dateTimePicker_DateProVisite.Value < DateTime.Now)
            {
                label_datepro.Text = "Veuillez choisir une date correcte";
                Err = 1;
            }
            return Err;
        }
        /// <summary>
        /// Gestion d'erreur sur textBox_AutreMotif
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int Gestion_erreur_textBox_AutreMotif()
        {
            int Err = 0;
            if (comboBox_Motif.Text == "Autre" && (textBox_AutreMotif.Text.Trim() == "" || textBox_AutreMotif.Text == null))
            {
                label_autremotif.Text = "Veuillez écrire un motif";
                Err = 1;
            }
            return Err;
        }
        /// <summary>
        /// Gestion d'erreur sur textBox_BilanRap
        /// </summary>
        /// <returns>0 si pas d'erreur</returns>
        private int Gestion_erreur_textBox_BilanRap()
        {
            int Err = 0;
            if (textBox_BilanRap.Text.Trim() == "" || textBox_BilanRap.Text == null)
            {
                label_bilan.Text = "Veuillez écrire un bilan";
                Err = 1;
            }
            return Err;
        }
    }
}