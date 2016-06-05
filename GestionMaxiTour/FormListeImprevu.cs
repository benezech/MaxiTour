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
    public partial class FormListeImprevu : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Imprevus camion = new Imprevus();

        public FormListeImprevu()
        {
            InitializeComponent();
        }

        private void FormListeImprevu_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridImprevus.DataSource = gestionBdd.request_select("SELECT * FROM Imprevus");
        }
    }
}
