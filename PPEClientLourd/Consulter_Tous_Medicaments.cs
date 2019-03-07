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
    public partial class Consulter_Tous_Medicaments : Form
    {
        string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public Consulter_Tous_Medicaments()
        {
            InitializeComponent();
        }

        private void Consulter_Tous_Medicaments_Load(object sender, EventArgs e)
        {
            Curs cs = new Curs(chaineConnexion);
            string sql = "SELECT MED_NOMCOMMERCIAL, FAM_CODE, MED_COMPOSITION, MED_DEPOTLEGAL FROM medicament";
            cs.ReqSelect(sql);
            string nom, code, composition, depot;
            while (!cs.Fin())
            {
                nom = cs.Champ("MED_NOMCOMMERCIAL").ToString();
                code = cs.Champ("FAM_CODE").ToString();
                composition = cs.Champ("MED_COMPOSITION").ToString();
                depot = cs.Champ("MED_DEPOTLEGAL").ToString();

                dataGridView1.Rows.Add(nom, code, composition, depot);

                cs.Suivant();
            }

            cs.Fermer();
        }
    }
}
