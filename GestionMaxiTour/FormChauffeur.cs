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
    public partial class FormChauffeur : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Chauffeur chauffeur = new Chauffeur();

        int position = 0;

        public FormChauffeur()
        {
            InitializeComponent();
        }

        private void FormChauffeur_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");

            refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from Chauffeur");

            IdChauffeur_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            nom_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            prenom_tb.Text = gestionBdd.getField_Datable(donnees, position, 2);
            numsecu_tb.Text = gestionBdd.getField_Datable(donnees, position, 3);
            adresse_tb.Text = gestionBdd.getField_Datable(donnees, position, 4);
            cp_tb.Text = gestionBdd.getField_Datable(donnees, position, 5);
            ville_tb.Text = gestionBdd.getField_Datable(donnees, position, 6);
            tel_tb.Text = gestionBdd.getField_Datable(donnees, position, 7);
            email_tb.Text = gestionBdd.getField_Datable(donnees, position, 8);
            dateemb_tb.Text = gestionBdd.getField_Datable(donnees, position, 9); 
            typecontrat_tb.Text = gestionBdd.getField_Datable(donnees, position, 10);
            salaire_tb.Text = gestionBdd.getField_Datable(donnees, position, 11);
            heure_tb.Text = gestionBdd.getField_Datable(donnees, position, 12);
           
        }

        public void initialize_textboxs()
        {
           IdChauffeur_tb.Text = "numéro automatique";
           nom_tb.Text = "";
           prenom_tb.Text = "";
           numsecu_tb.Text = "";
           adresse_tb.Text = "";
           cp_tb.Text = "";
           ville_tb.Text = "";
           tel_tb.Text = "";
           email_tb.Text = "";
           dateemb_tb.Text = "Choisir la date en dessous";
           typecontrat_tb.Text = "";
           salaire_tb.Text = "";
           heure_tb.Text = "";
        }

        private void labelRaisonSocialeClient_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Chauffeur").Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Chauffeur").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from Chauffeur").Rows.Count - 1;

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
                if (this.nom_tb.Text != null && this.prenom_tb.Text != null && this.numsecu_tb.Text != null
                    && this.adresse_tb.Text != null && this.cp_tb.Text != null && this.ville_tb.Text != null
                    && this.tel_tb.Text != null && this.email_tb.Text != null && this.salaire_tb.Text != null 
                    && this.typecontrat_tb.Text != null && this.heure_tb.Text != null)
                {

                    string nom = nom_tb.Text;
                    string prenom = prenom_tb.Text;
                    int ns = Int32.Parse(this.numsecu_tb.Text);
                    string adresse = adresse_tb.Text;
                    int cp = Int32.Parse(this.cp_tb.Text);
                    string ville = ville_tb.Text;
                    string tel = tel_tb.Text;
                    string email = email_tb.Text;
                    string salaire = this.salaire_tb.Text;
                    string dateE = Convert.ToString(this.dateTimePickerE.Text);
                    string tc = typecontrat_tb.Text;
                    string heure = this.heure_tb.Text;



                    string req = "Insert into Chauffeur Values ( null, '" + nom + "', '" + prenom + "'," + ns + ", '" + adresse + "', " + cp + ", '" + ville + "', '" + tel + "', '" + email + "', '" + dateE + "', '" + tc + "', " + salaire + "," + heure + ");";
                    gestionBdd.request_action(req);
                    dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");

                    MessageBox.Show("Chauffeur Ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int nc = Int32.Parse(this.IdChauffeur_tb.Text);


                string req = "Delete from Chauffeur Where idChauffeur = " + nc + ";";
                gestionBdd.request_action(req);
                dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Chauffeur Supprimé!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {

            if (this.nom_tb.Text != null && this.prenom_tb.Text != null && this.numsecu_tb.Text != null
                    && this.adresse_tb.Text != null && this.cp_tb.Text != null && this.ville_tb.Text != null
                    && this.tel_tb.Text != null && this.email_tb.Text != null && this.typecontrat_tb.Text != null && this.salaire_tb.Text != null && this.heure_tb.Text != null)
                {

                    int id = Int32.Parse(this.IdChauffeur_tb.Text);
                    string nom = nom_tb.Text;
                    string prenom = prenom_tb.Text;
                    int ns = Int32.Parse(this.numsecu_tb.Text);
                    string adresse = this.adresse_tb.Text;
                    string cp= cp_tb.Text;
                    string ville = ville_tb.Text;
                    string tel = tel_tb.Text;
                    string email = email_tb.Text;
                    string dateE = Convert.ToString(this.dateTimePickerE.Text);
                    double salaire = Convert.ToDouble(this.salaire_tb.Text);
                    string tc = typecontrat_tb.Text; 
                    double heure = Convert.ToDouble(this.heure_tb.Text);


                    string req = "update Chauffeur set Nom='" + nom + "', Prenom='" + prenom + "', NumSecu=" + ns + ", adresse='" + adresse + "', CP= " + cp + ", Ville='" + ville + "', Telephone='" + tel + "', Email='" + email + "', DateEmbauche='" + dateE + "', TypeContrat='"+ tc + "', Salaire=" + salaire + ", NombreHeure=" + heure + " where idChauffeur=" + id + ";";
                    gestionBdd.request_action(req);
                    dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");

                    MessageBox.Show("Chauffeur Modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void salaire_tb_TextChanged(object sender, EventArgs e)
        {

        }

        public TextBox salaireBox
        {
            get
            {
                return  salaire_tb;
            }
        }


        


    }
}
