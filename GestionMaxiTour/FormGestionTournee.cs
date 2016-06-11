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
    public partial class FormGestionTournee : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
    

        int position = 0;

        public FormGestionTournee()
        {
            InitializeComponent();
        }

        private void GestionTournee_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            refresh_textboxs();
        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from Gestion_Tournee");

            idT_tb.Text = gestionBdd.getField_Datable(donnees, position, 0); 
            idCh_tb.Text = gestionBdd.getField_Datable(donnees, position, 1); 
            idCa_tb.Text = gestionBdd.getField_Datable(donnees, position, 2); 
            affect_tb.Text = gestionBdd.getField_Datable(donnees, position, 3); 
        }

        public void initialize_textboxs()
        {
            idT_tb.Text = "";
            idCh_tb.Text = "";
            idCa_tb.Text = "";
            affect_tb.Text = "choisir date en dessous";


        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Gestion_Tournee").Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Gestion_Tournee").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from Gestion_Tournee").Rows.Count - 1;

            refresh_textboxs();
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (this.buttonAjout.Text == "+")
            {

                initialize_textboxs();
                this.buttonAjout.Text = "OK";
            }


            else
                if (this.idT_tb.Text != null && this.idCh_tb.Text != null && this.idCa_tb.Text != null && this.affect_tb.Text != null)
                {
                    int idt = Int32.Parse(this.idT_tb.Text);
                    int idch = Int32.Parse(this.idCh_tb.Text);
                    int idca= Int32.Parse(this.idCa_tb.Text);
                    string affect = Convert.ToString(this.dateTimePickerAf.Text); 

                    string req = "Insert into Gestion_Tournee Values ( " + idt + "," + idch + "," + idca+ ", '" + affect + "');";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Affectation Validée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int idt = Int32.Parse(this.idT_tb.Text);
                int idch = Int32.Parse(this.idCh_tb.Text);
                int idca = Int32.Parse(this.idCa_tb.Text);


                string req = "delete from Gestion_Tournee where idTournee =" + idt + " and idChauffeur =" + idch + " and idCamion=" + idca + " ;";
                gestionBdd.request_action(req);

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Affectation Supprimée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
                      
               if (this.idT_tb.Text != null && this.idCh_tb.Text != null && this.idCa_tb.Text != null && this.affect_tb.Text != null)
                {
                    int idt = Int32.Parse(this.idT_tb.Text);
                    int idch = Int32.Parse(this.idCh_tb.Text);
                    int idca = Int32.Parse(this.idCa_tb.Text);
                    string affect = Convert.ToString(this.dateTimePickerAf.Text);

                    string req = "update Gestion_Tournee Set Dateaffchauffeur= '" + affect + "' where idTournee =" + idt + " and idChauffeur =" + idch + " and idCamion=" + idca + " ;";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Affectation modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonModif.Text = "mod";

                }

                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chauffeur_btn_Click(object sender, EventArgs e)
        {
            FormListeChauffeur listechauffeurs = new FormListeChauffeur();
            listechauffeurs.ShowDialog(); 
        }

        private void camion_btn_Click(object sender, EventArgs e)
        {
            FormListeCamions listecamions = new FormListeCamions();
            listecamions.ShowDialog(); 
        }
    }
}
