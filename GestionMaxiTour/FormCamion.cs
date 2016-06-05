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
    public partial class FormCamion : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Camion camion = new Camion();

        int position = 0;

        public FormCamion()
        {
            InitializeComponent();
        }

        private void FormCamion_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            refresh_textboxs();

            calcul_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from camion");

            idCamion_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            //nom_tb.Text = gestionBdd.getField_Datable(donnees, position, 1); // etat checkbox
            immat_tb.Text = gestionBdd.getField_Datable(donnees, position, 2); // Immatriculation
            km_tb.Text = gestionBdd.getField_Datable(donnees, position, 3); // kilometrage
            modele_tb.Text = gestionBdd.getField_Datable(donnees, position, 4); // modele
            marque_tb.Text = gestionBdd.getField_Datable(donnees, position, 5); // marque
            conso_tb.Text = gestionBdd.getField_Datable(donnees, position, 6); //  consommation
            carbu_tb.Text = gestionBdd.getField_Datable(donnees, position, 7); // carburant
            datea_tb.Text = gestionBdd.getField_Datable(donnees, position, 8); // date achat
            datec_tb.Text = gestionBdd.getField_Datable(donnees, position, 9); // date circulation
            //dateemb_tb.Text = gestionBdd.getField_Datable(donnees, position, 10); // Hayon
            poidv_tb.Text = gestionBdd.getField_Datable(donnees, position, 11); // Poid à vide 
            ptac_tb.Text = gestionBdd.getField_Datable(donnees, position, 12); // ptac
            longint_tb.Text = gestionBdd.getField_Datable(donnees, position, 13); // longueurInt
            largint_tb.Text = gestionBdd.getField_Datable(donnees, position, 14); // largeurInt
            hautint_tb.Text = gestionBdd.getField_Datable(donnees, position, 15); // hauteurInt

            string etat = gestionBdd.getField_Datable(donnees, position, 1);

            if (etat == "check")
            {
                checkBoxEtat.Checked = true;

            }
            else
            {
                checkBoxEtat.Checked = false;
            }

            string hayon = gestionBdd.getField_Datable(donnees, position, 10);

            if (hayon == "check")
            {
                checkBoxEtat.Checked = true;

            }
            else
            {
                checkBoxEtat.Checked = false;
            }


        }

        public void initialize_textboxs()
        {
            idCamion_tb.Text = "numéro automatique";
            immat_tb.Text = ""; 
            km_tb.Text = ""; 
            modele_tb.Text = ""; 
            marque_tb.Text = ""; 
            conso_tb.Text = ""; 
            carbu_tb.Text = ""; 
            datea_tb.Text = "choisir la date en dessous"; 
            datec_tb.Text = "choisir la date en dessous"; 
            poidv_tb.Text = ""; 
            ptac_tb.Text = ""; 
            longint_tb.Text = ""; 
            largint_tb.Text = ""; 
            hautint_tb.Text = ""; 
            volume_tb.Text = "calcul automatique";
            volumelibre_tb.Text = "calcul automatique";
        }

        public void calcul_textboxs()
        {
            double volume = camion.calculVolume(Convert.ToDouble(this.longint_tb.Text), Convert.ToDouble(this.largint_tb.Text), Convert.ToDouble(this.hautint_tb.Text));
            double volumelibre = 300;

            volume_tb.Text = Convert.ToString(volume);
            volumelibre_tb.Text = Convert.ToString(volumelibre);

        }



        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from camion").Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Camion").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from Camion").Rows.Count - 1;

            refresh_textboxs();

            calcul_textboxs();
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
                if (this.immat_tb.Text != null && this.km_tb.Text != null && this.modele_tb.Text != null
                    && this.marque_tb.Text != null && this.conso_tb.Text != null && this.carbu_tb.Text != null
                    && this.poidv_tb.Text != null && this.ptac_tb.Text != null && this.longint_tb.Text != null
                    && this.largint_tb.Text != null && this.hautint_tb.Text != null)
                {
                    
                    string etat = Convert.ToString(checkBoxEtat.CheckState);
                    string imat = immat_tb.Text;
                    string km = this.km_tb.Text;
                    string mo = this.modele_tb.Text;
                    string ma = this.marque_tb.Text;
                    string conso = this.conso_tb.Text;
                    string carbu = this.carbu_tb.Text;
                    string da = Convert.ToString(this.dateTimePickerAchat.Text);
                    string dc = Convert.ToString(this.dateTimePickerCirculation.Text);
                    string hayon = Convert.ToString(checkBoxHayon.CheckState);
                    string pv = this.poidv_tb.Text;
                    string ptac = this.ptac_tb.Text;
                    string loint = this.longint_tb.Text;
                    string laint = this.largint_tb.Text;
                    string hauint = this.hautint_tb.Text;


                    string req = "Insert into Camion Values ( null, '" + etat + "','" + imat + "'," + km + ", '" + mo + "', '" + ma + "' ," + conso + ", '" + carbu + "', '" + da + "', '" + dc + "', '" + hayon + "'," + pv + "," + ptac + "," + loint + "," + laint + "," + hauint + ");";

                    gestionBdd.request_action(req);

                    MessageBox.Show("Camion Ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    calcul_textboxs();

                    this.buttonAjout.Text = "+";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {

            if (this.immat_tb.Text != null && this.km_tb.Text != null && this.modele_tb.Text != null
                && this.marque_tb.Text != null && this.conso_tb.Text != null && this.carbu_tb.Text != null
                && this.poidv_tb.Text != null && this.ptac_tb.Text != null && this.longint_tb.Text != null
                && this.largint_tb.Text != null && this.hautint_tb.Text != null)
            {
                int idCamion = Int32.Parse(this.idCamion_tb.Text);
                string etat = Convert.ToString(checkBoxEtat.CheckState);
                string imat = immat_tb.Text;
                string km = this.km_tb.Text;
                string mo = this.modele_tb.Text;
                string ma = this.marque_tb.Text;
                string conso = this.conso_tb.Text;
                string carbu = this.carbu_tb.Text;
                string da = Convert.ToString(this.dateTimePickerAchat.Text);
                string dc = Convert.ToString(this.dateTimePickerCirculation.Text);
                string hayon = Convert.ToString(checkBoxHayon.CheckState);
                string pv = this.poidv_tb.Text;
                string ptac = this.ptac_tb.Text;
                string loint = this.longint_tb.Text;
                string laint = this.largint_tb.Text;
                string hauint = this.hautint_tb.Text;


                string req = "update Camion Set EtatCamion='" + etat + "', Immatriculation='" + imat + "', Kilometrage= " + km + ", Modele= '" + mo + "', Marque= '" + ma + "', Consommation= " + conso + ", Carburant= '" + carbu + "', DateAchat= '" + da + "', DateCirculation= '" + dc + "', Hayon= '" + hayon + "', PoidVide=" + pv + ", PTAC=" + ptac + ", LongueurIntRem=" + loint + ", LargeurIntRem=" + laint + ", HauteurIntRem= " + hauint + " where idCamion= " + idCamion + ";";

                gestionBdd.request_action(req);

                MessageBox.Show("Camion Modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refresh_textboxs();

                calcul_textboxs();

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
                int idCamion = Int32.Parse(this.idCamion_tb.Text);


                string req = "Delete from Camion Where idCamion = " + idCamion + ";";
                gestionBdd.request_action(req);

                position = 0;

                refresh_textboxs();

                calcul_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Camion Supprimée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonListeC_Click(object sender, EventArgs e)
        {
            FormListeCamions listecamion = new FormListeCamions();
            listecamion.ShowDialog(); 

        }
    }
}
