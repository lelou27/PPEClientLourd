using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PPEClientLourd
{
    public partial class rapportVisite : Form
    {
        private string _colMatricule;
        private string _colNom;
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();
        public rapportVisite(string colNom, string colMat)
        {
            InitializeComponent();

            this._colNom = colNom;
            this._colMatricule = colMat;

            string connection = "server=127.0.0.1; DATABASE=applicationppe; user=root; PASSWORD=;SslMode=none";
            Curs cs = new Curs(connection);
            string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
            cs.ReqSelect(requete);
            string Name = "";
            while (!cs.Fin())
            {
                Name = cs.Champ("PRA_NOM").ToString() + " " + cs.Champ("PRA_PRENOM").ToString();
                praticiens.Add(Convert.ToInt16(cs.Champ("PRA_NUM").ToString()), Name);
                comboBox_Practiciens.Items.Add(Name);
                cs.Suivant();
            }
            cs.Fermer();

            dataGridView_echantillon.ColumnCount = 2;
            dataGridView_echantillon.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_echantillon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            Curs cs2 = new Curs(connection);
            requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` FROM `medicament` ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
            cs2.ReqSelect(requete);
            while (!cs2.Fin())
            {
                Medicaments.Items.Add(cs2.Champ("MED_NOMCOMMERCIAL").ToString());
                cs2.Suivant();
            }
            cs2.Fermer();
        }


        private void ComboBox_NewRDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_NewRDV.Text == "Non")
            {
                DateProVisite.Visible = false;
                dateTimePicker_DateProVisite.Visible = false;
            }
            else if (comboBox_NewRDV.Text == "Oui")
            {
                DateProVisite.Visible = true;
                dateTimePicker_DateProVisite.Visible = true;
            }
        }

        private void ComboBox_Motif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Motif.Text == "Autre")
            {
                AutreMotif.Visible = true;
                textBox_AutreMotif.Visible = true;
            }
            else
            {
                AutreMotif.Visible = false;
                textBox_AutreMotif.Visible = false;
            }
        }


        private void button_Fermer_Click_1(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();

            Home homeForm = new Home(this._colMatricule, this._colNom);

            homeForm.Show();
        }

        private void comboBox_Practiciens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Practiciens.Text == "" || comboBox_Practiciens.Text == null)
            {
                Btn_detailsPracticiens.Visible = false;
            }
            else
            {
                Btn_detailsPracticiens.Visible = true;
            }
        }

        private void rapportVisite_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_detailsPracticiens_Click(object sender, EventArgs e)
        {

            int myKey = praticiens.FirstOrDefault(x => x.Value == comboBox_Practiciens.Text).Key;

            DetailsPatricien DP = new DetailsPatricien(myKey);

            DP.Show();
        }

        private void button_Nouveau_Click(object sender, EventArgs e)
        {
            int err = 0;

            if (comboBox_Practiciens == null || comboBox_Practiciens.ToString() == "")
            {
                label_errPratricien.Text = "";
                err++;
            }
        }
    }
}
