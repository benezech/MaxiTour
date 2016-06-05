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
    public partial class FormListeChauffeur : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Chauffeur facture = new Chauffeur();

        public FormListeChauffeur()
        {
            InitializeComponent();
        }

        private void FormListeChauffeur_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");
        }
    }
}
