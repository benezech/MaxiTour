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
    public partial class FormListeDevis : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Devis devis = new Devis();

        public FormListeDevis()
        {
            InitializeComponent();
        }

        private void FormListeDevis_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridDevis.DataSource = gestionBdd.request_select("SELECT * FROM Devis");

        }
    }
}
