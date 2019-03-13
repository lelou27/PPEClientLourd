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

        }
    }
}
