using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaxiTour;

using MySql.Data.MySqlClient;

namespace GestionMaxiTour
{
    public partial class FormListeFacture : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Facture facture = new Facture();

        //string requeteFacture = "SELECT * FROM facture";
        string requeteFacture = "SELECT * FROM Facture";
        public FormListeFacture()
        {
            InitializeComponent();
        }

        private void FormListeFacture_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridFacture.DataSource = gestionBdd.request_select(requeteFacture);
        }
    }
}
