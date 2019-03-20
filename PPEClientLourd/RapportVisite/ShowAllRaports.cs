using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class ShowAllRaports : Form
    {
        private string _matricule;
        private string _nom;
        private string _role;

        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public ShowAllRaports( string matricule, string nom, string role )
        {
            InitializeComponent();

            _matricule = matricule;
            _nom = nom;
            _role = role;
        }

        private void ShowAllRaports_Load( object sender, EventArgs e )
        {
            Curs cs = new Curs(chaineConnexion);
            string req;

            if (_role == "responsable")
            {
                req = "SELECT c.COL_NOM, r.RAP_NUM, r.RAP_DATE, r.RAP_MOTIF, p.PRA_NOM, c.COL_MATRICULE " +
                             "FROM rapport_visite r " +
                             "  INNER JOIN collaborateur c ON r.COL_MATRICULE = c.COL_MATRICULE " +
                             "  INNER JOIN praticien p ON r.PRA_NUM = p.PRA_NUM" +
                             "  ORDER BY r.RAP_DATE DESC";
            }
            else
            {
                req = "SELECT c.COL_NOM, r.RAP_NUM, r.RAP_DATE, r.RAP_MOTIF, p.PRA_NOM " +
                             "FROM rapport_visite r " +
                             "  INNER JOIN collaborateur c ON r.COL_MATRICULE = c.COL_MATRICULE " +
                             "  INNER JOIN praticien p ON r.PRA_NUM = p.PRA_NUM" +
                             "  WHERE c.COL_MATRICULE = '" + _matricule + "'" +
                             "  ORDER BY r.RAP_DATE DESC";
            }

            cs.ReqSelect(req);

            string colNom, rapNum, rapDate, rapMotif, praNom, colMat = "";

            while (!cs.Fin())
            {
                colNom = cs.Champ("COL_NOM").ToString();
                rapNum = cs.Champ("RAP_NUM").ToString();
                rapDate = cs.Champ("RAP_DATE").ToString();
                rapMotif = cs.Champ("RAP_MOTIF").ToString();
                praNom = cs.Champ("PRA_NOM").ToString();
                if (_role == "responsable")
                {
                    colMat = cs.Champ("COL_MATRICULE").ToString();
                }

                rapDate = Convert.ToDateTime(rapDate).ToString();
                rapDate = rapDate.Split(' ')[0];
                dgv_rapports.Rows.Add(colNom, rapNum, rapDate, rapMotif, praNom, colMat);

                cs.Suivant();
            }

            cs.Fermer();

            if (dgv_rapports.Rows.Count == 0)
            {
                dgv_rapports.Hide();
                lbl_noResults.Text = "Aucun rapports correspondants";
            }
        }

        private void dgv_rapports_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex >=0)
            {
                string rapNum = dgv_rapports[1, e.RowIndex].Value.ToString();
                string colMat = dgv_rapports[5, e.RowIndex].Value.ToString();
                int noRapport = Convert.ToInt16(rapNum);

                if (noRapport != 0)
                {
                    RapportVisite rv = new RapportVisite(_nom, _matricule, "ShowAllRaports", noRapport, colMat, _role);
                    rv.Show();
                }
            }
        }

        private void btn_return_Click( object sender, EventArgs e ) => Close();
    }
}
