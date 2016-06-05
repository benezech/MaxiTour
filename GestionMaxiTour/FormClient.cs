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
    public partial class FormClient : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Client client = new Client();
        string requestClient = "SELECT * FROM Client";

        int position = 0;

        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridClient.DataSource = gestionBdd.request_select(requestClient);

            refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select(requestClient);

            IdClient_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            nom_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            prenom_tb.Text = gestionBdd.getField_Datable(donnees, position, 2);
            numsecu_tb.Text = gestionBdd.getField_Datable(donnees, position, 3);
            adresse_tb.Text = gestionBdd.getField_Datable(donnees, position, 4);
            cp_tb.Text = gestionBdd.getField_Datable(donnees, position, 5);
            ville_tb.Text = gestionBdd.getField_Datable(donnees, position, 6);
            tel_tb.Text = gestionBdd.getField_Datable(donnees, position, 7);
            email_tb.Text = gestionBdd.getField_Datable(donnees, position, 8);
            raisonssociale_tb.Text = gestionBdd.getField_Datable(donnees, position, 9);
            siret_tb.Text = gestionBdd.getField_Datable(donnees, position, 10);
            codenaf_tb.Text = gestionBdd.getField_Datable(donnees, position, 11);
           
        }

        public void initialize_textboxs()
        {
            IdClient_tb.Text = "numéro automatique";
            nom_tb.Text = "";
            prenom_tb.Text = "";
            numsecu_tb.Text = "";
            adresse_tb.Text = "";
            cp_tb.Text = "";
            ville_tb.Text = "";
            tel_tb.Text = "";
            email_tb.Text = "";
            raisonssociale_tb.Text = "";
            siret_tb.Text = "";
            codenaf_tb.Text = "";

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select(requestClient).Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            
            if (position < gestionBdd.request_select(requestClient).Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select(requestClient).Rows.Count - 1;

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
                    && this.tel_tb.Text != null && this.email_tb.Text != null && this.raisonssociale_tb.Text != null
                    && this.siret_tb.Text != null && this.codenaf_tb.Text != null )
                {
                    
                    string nom = nom_tb.Text;
                    string prenom = prenom_tb.Text;
                    int ns = Int32.Parse(this.numsecu_tb.Text);
                    string adresse = adresse_tb.Text;
                    int cp = Int32.Parse(this.cp_tb.Text);
                    string ville = ville_tb.Text;
                    string tel = tel_tb.Text;
                    string email = email_tb.Text;
                    string rs = raisonssociale_tb.Text;
                    int siret = Int32.Parse(this.siret_tb.Text);
                    string coden = codenaf_tb.Text;
         


                    string req = "Insert into Client Values ( null, '" + nom + "', '" + prenom + "'," + ns + ", '" + adresse + "', " + cp + ",'" + ville + "','" + tel + "', '" + email + "', '" + rs + "', " + siret + ",'" + coden + "');";
                    gestionBdd.request_action(req);
                    dataGridClient.DataSource = gestionBdd.request_select(requestClient);

                    MessageBox.Show("Client Ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int nc = Int32.Parse(this.IdClient_tb.Text);


                string req = "Delete from Client Where idClient = " + nc + ";";
                gestionBdd.request_action(req);
                dataGridClient.DataSource = gestionBdd.request_select(requestClient);

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Client Supprimée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {


                if (this.nom_tb.Text != null && this.prenom_tb.Text != null && this.numsecu_tb.Text != null
                    && this.adresse_tb.Text != null && this.cp_tb.Text != null && this.ville_tb.Text != null
                    && this.tel_tb.Text != null && this.email_tb.Text != null && this.raisonssociale_tb.Text != null
                    && this.siret_tb.Text != null && this.codenaf_tb.Text != null)
                {
                    int id = Int32.Parse(this.IdClient_tb.Text);
                    string nom = nom_tb.Text;
                    string prenom = prenom_tb.Text;
                    int ns = Int32.Parse(this.numsecu_tb.Text);
                    string adresse = adresse_tb.Text;
                    int cp = Int32.Parse(this.cp_tb.Text);
                    string ville = ville_tb.Text;
                    string tel = tel_tb.Text;
                    string email = email_tb.Text;
                    string rs = raisonssociale_tb.Text;
                    int siret = Int32.Parse(this.siret_tb.Text);
                    string coden = codenaf_tb.Text;



                    string req = "update Client Set Nom= '" + nom + "', Prenom= '" + prenom + "', NumSecu=" + ns + ", adresse='" + adresse + "', CP=" + cp + ", Ville='" + ville + "', Telephone='" + tel + "', Email= '" + email + "', RaisonSociale='" + rs + "', Siret=" + siret + ", CodeNaf='" + coden + "' where idClient =" + id + ";";
                    gestionBdd.request_action(req);
                    dataGridClient.DataSource = gestionBdd.request_select(requestClient);

                    MessageBox.Show("Client Modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonModif.Text = "mod";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        
    }
}
