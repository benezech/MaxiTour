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
    public partial class FormImprevu : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Imprevus imprevus = new Imprevus();

        int position = 0;

        public FormImprevu()
        {
            InitializeComponent();
        }

        private void FormImprevu_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from Imprevus");

            identifiant_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            numfacture_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            type_tb.Text = gestionBdd.getField_Datable(donnees, position, 2);
            cout_tb.Text = gestionBdd.getField_Datable(donnees, position, 3);

        }

        public void initialize_textboxs()
        {
            identifiant_tb.Text = "numéro automatique";
            type_tb.Text = "";
            numfacture_tb.Text = "";
            cout_tb.Text = "";

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

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (this.buttonAjout.Text == "+")
            {

                initialize_textboxs();
                this.buttonAjout.Text = "OK";
            }


            else
                if (this.type_tb.Text != null && this.numfacture_tb.Text != null && this.cout_tb.Text != null)
                {
                    int nf = Int32.Parse(this.identifiant_tb.Text);
                    string type = this.type_tb.Text;
                    double cout = Convert.ToDouble(this.cout_tb.Text);
                   
                    string req = "Insert into Imprevus Values ( null, " + nf + ",'" + type + "'," + cout + ");";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Imprévus Ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonAjout.Text = "+";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonSupprim_Click(object sender, EventArgs e)
        {
            if (this.buttonSupprim.Text == "-")
            {

                this.buttonSupprim.Text = "Suppr";
            }

            else
            {
                int id = Int32.Parse(this.identifiant_tb.Text);


                string req = "Delete from Imprevus Where idImprevus = " + id + ";";
                gestionBdd.request_action(req);

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Imprévus Supprimé!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (this.buttonModif.Text == "mod")
            {
                this.buttonModif.Text = "Modif";
            }


            else
                if (this.numfacture_tb.Text != null && this.type_tb.Text != null && this.cout_tb.Text != null)
                {
                    int id = Int32.Parse(this.identifiant_tb.Text);
                    int nf = Int32.Parse(this.numfacture_tb.Text );
                    string type = this.type_tb.Text;
                    double cout = Convert.ToDouble(this.cout_tb.Text);

                    string req = "update Imprevus Set NumFacture= " + nf + ", TypeImprevus ='" + type + "', Cout= " + cout + " where idImprevus =" + id + ";";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Imprévus modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonModif.Text = "mod";

                }

                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
       
        }

        private void btn_imprevus_Click(object sender, EventArgs e)
        {
            FormListeImprevu listeimprevus = new FormListeImprevu();
            listeimprevus.ShowDialog(); 
        }
    }
}
