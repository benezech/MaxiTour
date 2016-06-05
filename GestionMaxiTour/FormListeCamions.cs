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

    public partial class FormListeCamions : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Camion camion = new Camion();

        public FormListeCamions()
        {
            InitializeComponent();
        }

        private void FormListeCamions_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridCamion.DataSource = gestionBdd.request_select("SELECT * FROM Camion");
        }
    }
}
