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
    public partial class OneVisiteur : Form
    {
        private string _matricule;

        public OneVisiteur(string matricule)
        {
            InitializeComponent();
            this._matricule = matricule;
        }

        private void OneVisiteur_Load(object sender, EventArgs e)
        {

        }
    }
}
