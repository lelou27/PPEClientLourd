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
    public partial class ShowAllRaports : Form
    {
        private string _matricule;
        private string _nom;
        private string _role;

        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }

        public ShowAllRaports(string matricule, string nom, string role)
        {
            InitializeComponent();

            this._matricule = matricule;
            this._nom = nom;
            this._role = role;
        }

        private void ShowAllRaports_Load(object sender, EventArgs e)
        {
            Curs cs = new Curs(this.chaineConnexion);
            string req;

            if (this._role == "responsable")
            {
                req = "SELECT c.COL_NOM, r.RAP_NUM, r.RAP_DATE, r.RAP_MOTIF, p.PRA_NOM " +
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
                             "  WHERE c.COL_MATRICULE = '" + this._matricule + "'" +
                             "  ORDER BY r.RAP_DATE DESC";
            }

            cs.ReqSelect(req);

            string colNom, rapNum, rapDate, rapMotif, praNom;

            while (!cs.Fin())
            {
                colNom = cs.Champ("COL_NOM").ToString();
                rapNum = cs.Champ("RAP_NUM").ToString();
                rapDate = cs.Champ("RAP_DATE").ToString();
                rapMotif = cs.Champ("RAP_MOTIF").ToString();
                praNom = cs.Champ("PRA_NOM").ToString();

                rapDate = Convert.ToDateTime(rapDate).ToString();
                rapDate = rapDate.Split(' ')[0];

                dgv_rapports.Rows.Add(colNom, rapNum, rapDate, rapMotif, praNom);

                cs.Suivant();
            }

            cs.Fermer();

            if (dgv_rapports.Rows.Count == 0)
            {
                dgv_rapports.Hide();
                lbl_noResults.Text = "Aucun rapports correspondants";
            }
        }

        private void dgv_rapports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string rapNum = dgv_rapports[1, e.RowIndex].Value.ToString();
            int noRapport = Convert.ToInt16(rapNum);
            lbl_noResults.Text = noRapport.ToString();

            if (noRapport != 0)
            {
                Home h = new Home(this._matricule, this._nom);

                Hide();

            }
        }
    }
}
