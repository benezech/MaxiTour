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
    public partial class FormTournee : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Tournee tournee = new Tournee();
        string requestTournee = "SELECT * FROM Tournee";

        int position = 0;

        public FormTournee()
        {
            InitializeComponent();
        }

        private void FormTournee_Load(object sender, EventArgs e)
        {
           gestionBdd.Connexion();

           refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select(requestTournee);

            id_tb.Text = gestionBdd.getField_Datable(donnees, position, 0); // id tournee
            //etat_tb.Text = gestionBdd.getField_Datable(donnees, position, 1); // etat checkbox
            devis_tb.Text = gestionBdd.getField_Datable(donnees, position, 2); // idDevis
            facture_tb.Text = gestionBdd.getField_Datable(donnees, position, 3); // NumFacture
            duree_tb.Text = gestionBdd.getField_Datable(donnees, position, 4); // Duree Tournee
            intitul_tb.Text = gestionBdd.getField_Datable(donnees, position, 5); // Intitule liaison
            depart_tb.Text = gestionBdd.getField_Datable(donnees, position, 6); //  Depart Tournee
            arrivee_tb.Text = gestionBdd.getField_Datable(donnees, position, 7); // Arrivee tournee
            frequence_tb.Text = gestionBdd.getField_Datable(donnees, position, 8); // frequence tournee
            period_tb.Text = gestionBdd.getField_Datable(donnees, position, 9); // periodicite tournee
            nombrej_tb.Text = gestionBdd.getField_Datable(donnees, position, 10); // Nombre par jour


            string etat = gestionBdd.getField_Datable(donnees, position, 1);

            if (etat == "check")
            {
                checkBoxE.Checked = true;

            }
            else
            {
                checkBoxE.Checked = false;
            }

       }

        public void initialize_textboxs()
        {
            id_tb.Text = "numéro automatique";
            devis_tb.Text = "";
            facture_tb.Text = "";
            duree_tb.Text = "";
            intitul_tb.Text = "";
            depart_tb.Text = "";
            arrivee_tb.Text = "";
            frequence_tb.Text = "";
            period_tb.Text = "";
            nombrej_tb.Text = "";

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();

           
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select(requestTournee).Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select(requestTournee).Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select(requestTournee).Rows.Count - 1;

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
                if (this.devis_tb.Text != null && this.facture_tb.Text != null && this.duree_tb.Text != null
                    && this.intitul_tb.Text != null && this.depart_tb.Text != null && this.arrivee_tb.Text != null
                    && this.frequence_tb.Text != null && this.period_tb.Text != null && this.nombrej_tb.Text != null)
                {

                    string etat = Convert.ToString(checkBoxE.CheckState);
                    int devis = Int32.Parse(this.devis_tb.Text);
                    int fact = Int32.Parse(this.facture_tb.Text);
                    int duree = Int32.Parse(this.duree_tb.Text);
                    string intitul = this.intitul_tb.Text;
                    string depart = this.depart_tb.Text;
                    string arrivee = this.arrivee_tb.Text ;
                    int freq = Int32.Parse(this.frequence_tb.Text);
                    int period = Int32.Parse(this.period_tb.Text);
                    int nj = Int32.Parse(this.nombrej_tb.Text);



                    string req = "Insert into Tournee Values ( null, '" + etat + "'," + devis + "," + fact + "," + duree + ", '" + intitul + "', '" + depart + "' , '" + arrivee + "', " + freq + ", " + period + ", " + nj + ");";

                    gestionBdd.request_action(req);

                    MessageBox.Show("Tournée Ajoutée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonAjout.Text = "+";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {

                if (this.devis_tb.Text != null && this.facture_tb.Text != null && this.duree_tb.Text != null
                    && this.intitul_tb.Text != null && this.depart_tb.Text != null && this.arrivee_tb.Text != null
                    && this.frequence_tb.Text != null && this.period_tb.Text != null && this.nombrej_tb.Text != null)
                {
                    int id = Int32.Parse(this.id_tb.Text);
                    string etat = Convert.ToString(checkBoxE.CheckState);
                    int devis = Int32.Parse(this.devis_tb.Text);
                    int fact = Int32.Parse(this.facture_tb.Text);
                    int duree = Int32.Parse(this.duree_tb.Text);
                    string intitul = this.intitul_tb.Text;
                    string depart = this.depart_tb.Text;
                    string arrivee = this.arrivee_tb.Text;
                    int freq = Int32.Parse(this.frequence_tb.Text);
                    int period = Int32.Parse(this.period_tb.Text);
                    int nj = Int32.Parse(this.nombrej_tb.Text);



                   string req = "update Tournee set Etat='" + etat + "', idDevis=" + devis + ", NumFacture=" + fact + ", DureeTournee=" + duree + ", IntituleLiaison='" + intitul + "', DepartTournee='" + depart + "' , ArriveeTournee='" + arrivee + "', FrequenceTournee=" + freq + ", PeriodiciteTournee= " + period + ", NombreParJour= " + nj + " where idTournee= " + id + ";";
                    
                   gestionBdd.request_action(req);

                   MessageBox.Show("Tournée Modifiée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int id = Int32.Parse(this.id_tb.Text);


                string req = "Delete from Tournee Where idTournee = " + id + ";";
                gestionBdd.request_action(req);

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Tournée Supprimée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_tournee_Click(object sender, EventArgs e)
        {
            FormListeTournees listetournee = new FormListeTournees();
            listetournee.ShowDialog(); 
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_devis_Click(object sender, EventArgs e)
        {
            FormListeDevis listedevis = new FormListeDevis();
            listedevis.ShowDialog(); 
        }

        private void btn_facture_Click(object sender, EventArgs e)
        {
            FormListeFacture listefacture = new FormListeFacture();
            listefacture.ShowDialog(); 

        }
    }
}
