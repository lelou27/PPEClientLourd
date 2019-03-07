﻿using MySql.Data.MySqlClient;
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
    public partial class Ajouter_Medicament : Form
    {
        private string dépôt;
        private string nom;
        private string code;
        private string composition;
        private string effets;
        private string contreindic;
        private double prixechant;
        //private curs connection;

        private string chaineConnexion = "SERVER=127.0.0.1; DATABASE=applicationppe; UID=root; PASSWORD=; SslMode=none";


        public Ajouter_Medicament()
        {
            InitializeComponent();
            //this.InitConnexion();
        }

        public string Dépôt { get => dépôt; set => dépôt = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Code { get => code; set => code = value; }
        public string Composition { get => composition; set => composition = value; }
        public string Effets { get => effets; set => effets = value; }
        public string Contreindic { get => contreindic; set => contreindic = value; }
        public double Prixechant { get => prixechant; set => prixechant = value; }

        /*public void InitConnexion()
        {
            string connectionstring = "SERVER=127.0.0.1; DATABASE=clientlourdtest; UID=root; PASSWORD=; SslMode=none";
            this.connection = new curs(connectionstring);
        } */

        private void Ajouter_Medicament_Load(object sender, EventArgs e)
        {

        }

        private void Ajouter_medicament_valider_bouton_Click(object sender, EventArgs e)
        {
            string depot_legal = depot_legal_input.Text;
            string nom = nom_input.Text;
            string code = code_input.Text;
            string composition = composition_input.Text;
            string effets = effets_input.Text;
            string contreindic = contreindic_input.Text;
            string prixech = prixech_input.Text;

            if( (depot_legal.Length == 0) || (nom.Length == 0) || (code.Length == 0) || (composition.Length == 0) || (effets.Length == 0) || (contreindic.Length == 0) || (prixech.ToString().Length == 0))
            {
                Aj_med_error_label.Text = "Veuillez remplir tous les champs";
                Aj_med_error_label.Show();
            }

            else
            {
                Aj_med_error_label.Hide();
                if(code.Length > 3)
                {
                    Aj_med_error_code.Text = "Trois caractères maximum";
                }
                else
                {
                    Curs cs = new Curs(this.chaineConnexion);

                    Aj_med_error_code.Hide();
                    Aj_med_error_prix.Hide();
                    double prix = double.Parse(prixech_input.Text);
                    string sql = "INSERT INTO medicament VALUES ('" + depot_legal_input.Text + "','" + nom_input.Text + "','" + code_input.Text + "','" + composition_input.Text + "','" + effets_input.Text + "','" + contreindic_input.Text + "'," + prix + ");";
                    cs.ReqAdmin(sql);

                    cs.Fermer();
                    //MySqlCommand SelectCommand = new MySqlCommand(sql);
                    depot_legal_input.Text = "";
                    nom_input.Text = "";
                    code_input.Text = "";
                    composition_input.Text = "";
                    effets_input.Text = "";
                    contreindic_input.Text = "";
                    prixech_input.Text = "";
                }
            }
        }

        private void contreindic_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
