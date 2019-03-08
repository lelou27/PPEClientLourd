using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Consulter_Medicament : Form
    {

        public Consulter_Medicament(int idMedicament = -1)
        {
            if(idMedicament != -1)
            {
                // requête recup medoc
                // remplissage du combobox
            }
            InitializeComponent();
            string chaineconnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=; SslMode=none";

            Curs cs = new Curs(chaineconnexion);
            string requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL`";
            cs.ReqSelect(requete);
            string nom = "";
            while(!cs.Fin())
            {
                nom = cs.Champ("MED_NOMCOMMERCIAL").ToString();
                Consulter_medicament_combobox.Items.Add(nom);
                cs.Suivant();
            }

        }
        private void Consulter_medicament_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nommed = Consulter_medicament_combobox.Text;
            string chaineconnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=; SslMode=none";
            Curs cs = new Curs(chaineconnexion);
            string requete = "SELECT * FROM `medicament` WHERE `medicament`.`MED_NOMCOMMERCIAL` = '" + nommed + "'";
            cs.ReqSelect(requete);
            Consulter_medicament_hidden_nom.Text = cs.Champ("MED_NOMCOMMERCIAL").ToString();
            Consulter_medicament_hidden_depot_legal.Text = cs.Champ("MED_DEPOTLEGAL").ToString();
            Consulter_medicament_hidden_code.Text = cs.Champ("FAM_CODE").ToString();
            Consulter_medicament_hidden_composition.Text = cs.Champ("MED_COMPOSITION").ToString();
            Consulter_medicament_hidden_effets.Text = cs.Champ("MED_EFFETS").ToString();
            Consulter_medicament_hidden_contreindic.Text = cs.Champ("MED_CONTREINDIC").ToString();
            Consulter_medicament_hidden_prixechant.Text = cs.Champ("MED_PRIXECHANTILLON").ToString();
            cs.Fermer();
        }

        private void Consulter_Medicament_Load(object sender, EventArgs e)
        {

        }
    }
}
