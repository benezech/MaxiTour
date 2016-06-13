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
    public partial class FormListeClients : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Client client = new Client();

        //string requeteClient = "Select * from client";
        string requeteClient = "Select * from Client";
        public FormListeClients()
        {
            InitializeComponent();
        }

        private void FormListeClients_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridListeClients.DataSource = gestionBdd.request_select(requeteClient);

        }
    }
}
