using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class Consulter_Tous_Medicaments : Form
    {
        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }
        public Consulter_Tous_Medicaments() => InitializeComponent();

        private void Consulter_Tous_Medicaments_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);
            string sql = "SELECT MED_NOMCOMMERCIAL, FAM_LIBELLE, MED_COMPOSITION, MED_DEPOTLEGAL " +
                            " FROM medicament " +
                            "       INNER JOIN famille ON medicament.FAM_CODE = famille.FAM_CODE ;";
            cs.ReqSelect(sql);
            string nom, familleLibelle, composition, depot;
            while (!cs.Fin())
            {
                nom = cs.Champ("MED_NOMCOMMERCIAL").ToString();
                familleLibelle = cs.Champ("FAM_LIBELLE").ToString();
                composition = cs.Champ("MED_COMPOSITION").ToString();
                depot = cs.Champ("MED_DEPOTLEGAL").ToString();

                dgv_allMedicaments.Rows.Add(nom, familleLibelle, composition, depot);

                cs.Suivant();
            }

            cs.Fermer();
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex >= 0)
            {
                string depotLegal = dgv_allMedicaments[3, e.RowIndex].Value.ToString();

                Consulter_Medicament cm = new Consulter_Medicament(depotLegal);
                cm.Show();

                Close();
            }
        }

        private void btn_close_Click( object sender, EventArgs e ) => Close();
    }
}
