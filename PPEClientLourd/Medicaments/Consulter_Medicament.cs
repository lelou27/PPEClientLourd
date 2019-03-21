using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Consulter_Medicament : Form
    {
        private string chaineconnexion = ConnexionDb.chaineConnexion;
        // Constructeur
        public Consulter_Medicament( string idMedicament = "a" )
        {
            InitializeComponent();

            Curs cs = new Curs(chaineconnexion);
            // Sélection des médicaments
            string requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL`";
            cs.ReqSelect(requete);
            string nom = "";
            while (!cs.Fin())
            {
                nom = cs.Champ("MED_NOMCOMMERCIAL").ToString();
                // Ajout des items
                Consulter_medicament_combobox.Items.Add(nom);
                cs.Suivant();
            }

            cs.Fermer();
            // Si un id est définit
            if (idMedicament != "a")
            {
                cs = new Curs(chaineconnexion);

                cs.ReqSelect("SELECT MED_NOMCOMMERCIAL FROM medicament WHERE MED_DEPOTLEGAL = '" + idMedicament + "';");

                string medicamentParameter;
                while (!cs.Fin())
                {
                    medicamentParameter = cs.Champ("MED_NOMCOMMERCIAL").ToString();
                    Consulter_medicament_combobox.SelectedItem = medicamentParameter;

                    cs.Suivant();
                }
                cs.Fermer();
            }

        }
        // Au chagement d'état
        private void Consulter_medicament_combobox_SelectedIndexChanged( object sender, EventArgs e )
        {
            string nommed = Consulter_medicament_combobox.Text;

            Curs cs = new Curs(chaineconnexion);
            string requete = "SELECT * FROM `medicament` WHERE `medicament`.`MED_NOMCOMMERCIAL` = '" + nommed + "'";
            cs.ReqSelect(requete);
            Consulter_medicament_hidden_nom.Text = cs.Champ("MED_NOMCOMMERCIAL").ToString();
            Consulter_medicament_hidden_depot_legal.Text = cs.Champ("MED_DEPOTLEGAL").ToString();
            Consulter_medicament_hidden_code.Text = cs.Champ("FAM_CODE").ToString();
            Consulter_medicament_hidden_composition.Text = cs.Champ("MED_COMPOSITION").ToString();
            Consulter_medicament_box_effets.Text = cs.Champ("MED_EFFETS").ToString();
            Consulter_medicament_box_contreindic.Text = cs.Champ("MED_CONTREINDIC").ToString();
            Consulter_medicament_hidden_prixechant.Text = cs.Champ("MED_PRIXECHANTILLON").ToString();
            cs.Fermer();
        }

    }
}
