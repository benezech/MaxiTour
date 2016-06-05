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
    public partial class FormListeTournees : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Tournee camion = new Tournee();

        public FormListeTournees()
        {
            InitializeComponent();
        }

        private void FormListeTournees_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridTournee.DataSource = gestionBdd.request_select("SELECT * FROM Tournee");
        }
    }
}
