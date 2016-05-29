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
    public partial class FormDevis : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        FormDevis devis = new FormDevis();

        int position = 0;

        public FormDevis()
        {
            InitializeComponent();
        }

        private void FormSaisirDevis_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from Devis");

            //identifiant_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            //numfacture_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            //type_tb.Text = gestionBdd.getField_Datable(donnees, position, 2);
            //cout_tb.Text = gestionBdd.getField_Datable(donnees, position, 3);

        }

        private void groupBoxTotaux_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Imprevus").Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Imprevus").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from Imprevus").Rows.Count - 1;

            refresh_textboxs();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
