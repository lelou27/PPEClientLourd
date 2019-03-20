using System;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class AllPraticiens : Form
    {
        /// <summary>
        /// Affichage de liste de tous les praticiens, affichage des détails d'un praticien
        /// </summary>
        private string chaineConnexion = ConnexionDb.chaineConnexion;

        public string ChaineConnexion
        {
            get => chaineConnexion;
            set => chaineConnexion = value;
        }
        public AllPraticiens() => InitializeComponent();

        private void Retour_Click( object sender, EventArgs e ) => Close();

        /// <summary>
        /// Permet d'afficher les détails d'un praticien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex >= 0)
            {
                string numero = dgv_praticiens[0, e.RowIndex].Value.ToString();

                if (numero.Length != 0)
                {
                    DetailsPraticien op = new DetailsPraticien(Convert.ToInt32(numero));
                    op.Show();

                    Hide();
                }
            }
        }


        /// <summary>
        /// Remplissage du datagridView et du comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllPraticiens_Load_1( object sender, EventArgs e )
        {
            //Connexion à la base de donnée
            Curs cs = new Curs(chaineConnexion);

            //Requête pour récupérer les valeurs des praticiens 
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


                //Remplissage des champs du dataGridView 
                dgv_praticiens.Rows.Add(Numero, Nom, Prenom, Adresse, Cp, Ville, Coefnotoriete, Libelle);

                cs.Suivant();


                if (dgv_praticiens.Rows.Count == 0)
                {
                    dgv_praticiens.Rows.Add("Désolé, aucun praticiens n'a été trouvé");
                }
            }

            cs.Fermer();
        }

        private void AllPraticiens_Load( object sender, EventArgs e )
        {

        }
    }
}
