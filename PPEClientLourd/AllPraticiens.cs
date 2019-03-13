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
    public partial class AllPraticiens : Form
    {

        string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";  //ceci permettra la connexion à la base de données	Mysql

        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        private string _colNom, _colMatricule;
        public AllPraticiens(string colNom, string colMat)
        {
            InitializeComponent();

            this._colNom = colNom;
            this._colMatricule = colMat;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();

            Home h = new Home(this._colMatricule, this._colNom);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_praticiens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AllPraticiens_Load_1(object sender, EventArgs e)
        {
            Curs cs = new Curs(this.chaineConnexion);

            cs.ReqSelect("SELECT p.PRA_NUM, p.PRA_NOM, p.PRA_PRENOM, p.PRA_ADRESSE, p.PRA_CP, p.PRA_VILLE, p.PRA_COEFNOTORIETE, tp.TYP_LIBELLE FROM praticien p " +
                            " INNER JOIN type_praticien tp ON p.TYP_CODE = tp.TYP_CODE ");

            int Numero;
            string Nom, Prenom, Adresse, Cp, Ville, Libelle;
            double Coefnotoriete;

            while (!cs.Fin())
            {
                Numero = Convert.ToInt32(cs.Champ("PRA_NUM").ToString());
                Nom = cs.Champ("PRA_NOM").ToString();
                Prenom = cs.Champ("PRA_PRENOM").ToString();
                Adresse = cs.Champ("PRA_ADRESSE").ToString();
                Cp = cs.Champ("PRA_CP").ToString();
                Ville = cs.Champ("PRA_VILLE").ToString();
                Coefnotoriete = Math.Round(Convert.ToDouble(cs.Champ("PRA_COEFNOTORIETE")), 2);
                Libelle = cs.Champ("TYP_LIBELLE").ToString();

                dgv_praticiens.Rows.Add(Numero, Nom, Prenom, Adresse, Cp, Ville, Libelle, Coefnotoriete);

                cs.Suivant();

                if (dgv_praticiens.Rows.Count == 0)
                    dgv_praticiens.Rows.Add("Désolé, aucun praticiens n'a été trouvé");
            }

            cs.Fermer();
        }

        private void AllPraticiens_Load(object sender, EventArgs e)
        {

        }
    }
}
