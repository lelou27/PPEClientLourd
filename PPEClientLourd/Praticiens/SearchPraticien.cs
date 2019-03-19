using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class SearchPraticien : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;
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

            cs.ReqSelect("SELECT PRA_NUM, PRA_NOM, PRA_PRENOM FROM praticien");

            while (!cs.Fin())
            {
                praticiens.Add(cs.Champ("PRA_NUM").ToString(), cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString());
                cbx_praticien.Items.Add(cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString());

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void btn_showInformations_Click( object sender, EventArgs e )
        {
            string itemSelected = cbx_praticien.SelectedItem.ToString();

            if (itemSelected.Length == 0)
            {
                lbl_error.Text = "Veuillez sélectionner un praticien";
            }
            else
            {
                string praNum = praticiens.FirstOrDefault(x => x.Value == itemSelected).Key;
                DetailsPraticien dp = new DetailsPraticien(Convert.ToInt16(praNum));
                dp.Show();
            }
        }
    }
}
