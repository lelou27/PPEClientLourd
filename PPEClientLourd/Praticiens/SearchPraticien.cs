using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class SearchPraticien : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;
        // Dictionnaire de praticiens
        private Dictionary<string, string> praticiens = new Dictionary<string, string>();

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public SearchPraticien() => InitializeComponent();

        private void SearchPraticien_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);

            // Récupération de tous les praticiens
            cs.ReqSelect("SELECT PRA_NUM, PRA_NOM, PRA_PRENOM FROM praticien");

            while (!cs.Fin())
            {
                praticiens.Add(cs.Champ("PRA_NUM").ToString(), cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString());
                cbx_praticien.Items.Add(cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString());

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void cbx_praticien_SelectedIndexChanged( object sender, EventArgs e )
        {

        }
        // Au clique sur voir les infos
        private void btn_showInformations_Click( object sender, EventArgs e )
        {
            string itemSelected = "";
            try
            {
                itemSelected = cbx_praticien.SelectedItem.ToString();
            }
            catch (Exception)
            {
                lbl_error.Text = "Veuillez sélectionner un praticien";
            }

            if (itemSelected.Length == 0)
            {
                lbl_error.Text = "Veuillez sélectionner un praticien";
            }
            else
            {
                // Récupération du praticien dans le dictionnaire
                string praNum = praticiens.FirstOrDefault(x => x.Value == itemSelected).Key;
                // Affichage du détail
                DetailsPraticien dp = new DetailsPraticien(Convert.ToInt16(praNum), "SearchPraticien");
                dp.Show();
            }
        }
    }
}
