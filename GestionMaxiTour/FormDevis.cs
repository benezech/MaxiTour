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
        Devis devis = new Devis();

        int position = 0;

        public FormDevis()
        {
            InitializeComponent();
        }

        private void FormSaisirDevis_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            comboBoxClient.DataSource = gestionBdd.request_select("select idClient from Client");
            comboBoxClient.DisplayMember = "idClient";

            refresh_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from Devis");

            id_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            client_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            prixpeage_tb.Text = gestionBdd.getField_Datable(donnees, position, 4);
            prixcarburant_tb.Text = gestionBdd.getField_Datable(donnees, position, 5);
            prixmaint_tb.Text = gestionBdd.getField_Datable(donnees, position, 6);
            prixassur_tb.Text = gestionBdd.getField_Datable(donnees, position, 7);
            fraisemploye_tb.Text = gestionBdd.getField_Datable(donnees, position, 8);
            calcultaxe_tb.Text = gestionBdd.getField_Datable(donnees, position, 9);
            ammort_tb.Text = gestionBdd.getField_Datable(donnees, position, 10);
            ressource_tb.Text = gestionBdd.getField_Datable(donnees, position, 11);
            kmclient_tb.Text = gestionBdd.getField_Datable(donnees, position, 12);
            kmallee_tb.Text = gestionBdd.getField_Datable(donnees, position, 13);
            kmretour_tb.Text = gestionBdd.getField_Datable(donnees, position, 14);
            volumemarchandise_tb.Text = gestionBdd.getField_Datable(donnees, position, 15);
            datedebut_tb.Text = gestionBdd.getField_Datable(donnees, position, 16);
            datefin_tb.Text = gestionBdd.getField_Datable(donnees, position, 17);

        }

        public void initialize_textboxs()
        {

            id_tb.Text = "numéro automatique";
            client_tb.Text = "";
            prixpeage_tb.Text = "";
            prixcarburant_tb.Text = "";
            prixmaint_tb.Text = "";
            prixassur_tb.Text = "";
            fraisemploye_tb.Text = "";
            ammort_tb.Text = "";
            ressource_tb.Text = "";
            kmclient_tb.Text = "";
            kmallee_tb.Text = "";
            kmretour_tb.Text = "";
            totalkm_tb.Text = "calcul automatique";
            volumemarchandise_tb.Text = "";
            datedebut_tb.Text = " choisir date au dessus";
            datefin_tb.Text = " choisir date au dessus";
            prixaukm_tb.Text = "calcul automatique";
            prixvehicule_tb.Text = "calcul automatique";
            prixchauffeur_tb.Text = "calcul automatique";
            calcultaxe_tb.Text = "calcul automatique";
            total_tb.Text = "calcul automatique";


        }

        private void groupBoxTotaux_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();

            //calcul_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Devis").Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();

            //calcul_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from Devis").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();

            //calcul_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from Devis").Rows.Count - 1;

            refresh_textboxs();

            //calcul_textboxs();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void calcul_textboxs()
        {

            double kmt = devis.kmTotal(Convert.ToDouble(this.kmclient_tb.Text), Convert.ToDouble(this.kmallee_tb.Text), Convert.ToDouble(this.kmretour_tb.Text));
            double pk = devis.prixAuKm();
            //double pv = prix véhicule;
            //double pc = prix chauffeur ( faire un foreach jusqu'à chauffeur);
           //double pt = prix total;

            prixaukm_tb.Text = Convert.ToString(kmt);
            prixvehicule_tb.Text = Convert.ToString(pk); ;
            //prixchauffeur_tb.Text = Convert.ToString(pv); ;
            //calcultaxe_tb.Text = Convert.ToString(pc); ;
            //total_tb.Text = Convert.ToString(pt);

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (this.buttonAjout.Text == "+")
            {

                initialize_textboxs();
                this.buttonAjout.Text = "OK";
            }


           else
                if (this.client_tb.Text != null &&  this.prixpeage_tb.Text != null && this.prixcarburant_tb != null 
                    && this.prixmaint_tb.Text != null && this.prixassur_tb.Text != null && this.fraisemploye_tb.Text != null 
                    && this.ammort_tb.Text != null && this.ressource_tb.Text!= null && this.kmclient_tb.Text != null
                    && this.kmallee_tb.Text != null && this.prixvehicule_tb.Text != null && this.volumemarchandise_tb.Text != null
                    && this.datedebut_tb.Text != null && this.datefin_tb.Text != null & this.prixaukm_tb.Text != null
                    && this.prixaukm_tb.Text != null && this.prixvehicule_tb.Text != null && this.prixchauffeur_tb.Text != null
                    && this.calcultaxe_tb.Text != null && this.total_tb.Text != null)
                {
                    int nc = Int32.Parse(this.client_tb.Text);
                    string etat = Convert.ToString(checkBoxEtat.CheckState);
                    double pp = Convert.ToDouble(this.prixpeage_tb.Text);
                    double pc = Convert.ToDouble(this.prixcarburant_tb.Text);
                    double pm = Convert.ToDouble(this.prixmaint_tb.Text);
                    double pa = Convert.ToDouble(this.prixassur_tb.Text);
                    double fe = Convert.ToDouble(this.fraisemploye_tb.Text);
                    double am = Convert.ToDouble(this.ammort_tb.Text);
                    string ress = ressource_tb.Text;
                    double kc = Convert.ToDouble(this.kmclient_tb.Text);
                    double ka = Convert.ToDouble(this.kmallee_tb.Text);
                    double kr = Convert.ToDouble(this.kmretour_tb.Text);
                    double vm = Convert.ToDouble(this.volumemarchandise_tb.Text);
                    string ddebut = Convert.ToString(this.dateTimePickerD.Text);
                    string dfin = Convert.ToString(this.dateTimePickerF.Text);
                    //double ct = calcultaxe_tb taxe;

                    int dir = 1; /*----- Enlever la table dirigeant plus tard-------*/
          

                    string req = "Insert into Devis Values ( null, " + nc + ",'" + etat + "'," + pp + "," + dir + ");";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Devis Ajouté!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    calcul_textboxs();

                    this.buttonAjout.Text = "+";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btn_listedevis_Click(object sender, EventArgs e)
        {
            FormListeDevis flistedevis = new FormListeDevis();
            flistedevis.ShowDialog();
        }

        private void btn_listeclients_Click(object sender, EventArgs e)
        {

            FormListeClients flisteclients = new FormListeClients();
            flisteclients.ShowDialog();

        }
    }
}
