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

        //string requeteDevis = "Select * from devis";
        string requeteDevis = "Select * from Devis";
        int position = 0;

        public FormDevis()
        {
            InitializeComponent();
        }

        private void FormSaisirDevis_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            //dataGridChauffeur.DataSource = gestionBdd.request_select("SELECT * FROM Chauffeur");

            refresh_textboxs();

            calcul_textboxs();

        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select(requeteDevis);

            id_tb.Text = gestionBdd.getField_Datable(donnees, position, 0);
            client_tb.Text = gestionBdd.getField_Datable(donnees, position, 1);
            //contrat_tb.Text = gestionBdd.getField_Datable(donnees, position, 2);
            prixpeage_tb.Text = gestionBdd.getField_Datable(donnees, position, 3);
            prixcarburant_tb.Text = gestionBdd.getField_Datable(donnees, position, 4);
            prixmaint_tb.Text = gestionBdd.getField_Datable(donnees, position, 5);
            prixassur_tb.Text = gestionBdd.getField_Datable(donnees, position, 6);
            prixaukm_tb.Text = gestionBdd.getField_Datable(donnees, position, 7);
            prixvehicule_tb.Text = gestionBdd.getField_Datable(donnees, position, 8);
            prixchauffeur_tb.Text = gestionBdd.getField_Datable(donnees, position, 9);
            fraisemploye_tb.Text = gestionBdd.getField_Datable(donnees, position, 10);
            ammort_tb.Text = gestionBdd.getField_Datable(donnees, position,11);
            ressource_tb.Text = gestionBdd.getField_Datable(donnees, position, 12);
            kmclient_tb.Text = gestionBdd.getField_Datable(donnees, position, 13);
            kmallee_tb.Text = gestionBdd.getField_Datable(donnees, position, 14);
            kmretour_tb.Text = gestionBdd.getField_Datable(donnees, position, 15);
            volumemarchandise_tb.Text = gestionBdd.getField_Datable(donnees, position, 16);
            datedebut_tb.Text = gestionBdd.getField_Datable(donnees, position, 17);
            datefin_tb.Text = gestionBdd.getField_Datable(donnees, position, 18);

            string id = gestionBdd.getField_Datable(donnees, position, 0);

            dataGridTourneePrevi.DataSource = gestionBdd.request_select("SELECT * FROM Tournee where Tournee.idDevis=" + id);

            string etat = gestionBdd.getField_Datable(donnees, position, 2);

            if (etat == "check")
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

            id_tb.Text = "numéro automatique";
            prixpeage_tb.Text = "";
            prixcarburant_tb.Text = "";
            client_tb.Text = "";
            prixmaint_tb.Text = "";
            prixassur_tb.Text = "";
            prixaukm_tb.Text = "";
            prixvehicule_tb.Text = "";
            prixchauffeur_tb.Text = "";
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
            prixaukm_tb.Text = "";
            prixvehicule_tb.Text = "";
            prixchauffeur_tb.Text = "";
            total_tb.Text = "calcul automatique";


        }

        private void groupBoxTotaux_Enter(object sender, EventArgs e)
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
            if (position < gestionBdd.request_select(requeteDevis).Rows.Count && position > 0)
            {
                position = position - 1;

            }

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select(requeteDevis).Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select(requeteDevis).Rows.Count - 1;

            refresh_textboxs();

            calcul_textboxs();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void calcul_textboxs()
        {
            
            double kt = devis.kmTotal(Convert.ToDouble(this.kmclient_tb.Text), Convert.ToDouble(this.kmallee_tb.Text), Convert.ToDouble(this.kmretour_tb.Text));
            double total = Convert.ToDouble(this.prixaukm_tb.Text) + Convert.ToDouble(this.prixvehicule_tb.Text) + Convert.ToDouble(this.prixchauffeur_tb.Text);
           
            totalkm_tb.Text = Convert.ToString(kt);
            total_tb.Text = Convert.ToString(total);

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (this.buttonAjout.Text == "+")
            {

                initialize_textboxs();
                this.buttonAjout.Text = "OK";
            }


           else
                if ( this.prixpeage_tb.Text != null && this.prixcarburant_tb.Text != null 
                    && this.prixmaint_tb.Text != null && this.prixassur_tb.Text != null && this.fraisemploye_tb.Text != null 
                    && this.ammort_tb.Text != null && this.ressource_tb.Text!= null && this.kmclient_tb.Text != null
                    && this.kmallee_tb.Text != null && this.prixvehicule_tb.Text != null && this.volumemarchandise_tb.Text != null
                    && this.datedebut_tb.Text != null && this.datefin_tb.Text != null 
                    && this.prixaukm_tb.Text != null && this.total_tb.Text != null)
                {
                    int nc = Int32.Parse(this.client_tb.Text);
                    //string nc = Convert.ToString(this.cbc.SelectedValue);
                    string etat = Convert.ToString(checkBoxEtat.CheckState);
                    string pp = this.prixpeage_tb.Text;
                    string pc = this.prixcarburant_tb.Text;
                    string pm = this.prixmaint_tb.Text;
                    string pa = this.prixassur_tb.Text;
                    string pkm = this.prixaukm_tb .Text;
                    string pv = this.prixvehicule_tb.Text;
                    string pch = this.prixchauffeur_tb.Text;
                    string fe = this.fraisemploye_tb.Text;
                    string am = this.ammort_tb.Text;
                    string ress = ressource_tb.Text;
                    string kc = this.kmclient_tb.Text;
                    string ka = this.kmallee_tb.Text;
                    string kr = this.kmretour_tb.Text;
                    string vm = this.volumemarchandise_tb.Text;
                    string ddebut = Convert.ToString(this.dateTimePickerD.Text);
                    string dfin = Convert.ToString(this.dateTimePickerF.Text);


                    string req = "Insert into Devis Values ( null, " + nc + ", '" + etat + "'," + pp + "," + pch + "," + pm + "," + pa + "," + pkm + "," + pv + "," + pch + "," + fe + "," + am + ",'" + ress + "'," + kc + "," + ka + "," + kr + "," + vm + ",'" + ddebut + "','" + dfin + "');";
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

        private void buttonModif_Click(object sender, EventArgs e)
        {                    

                
            if (  this.prixpeage_tb.Text != null && this.prixcarburant_tb.Text != null 
                    && this.prixmaint_tb.Text != null && this.prixassur_tb.Text != null && this.fraisemploye_tb.Text != null 
                    && this.ammort_tb.Text != null && this.ressource_tb.Text!= null && this.kmclient_tb.Text != null
                    && this.kmallee_tb.Text != null && this.prixvehicule_tb.Text != null && this.volumemarchandise_tb.Text != null
                    && this.datedebut_tb.Text != null && this.datefin_tb.Text != null && this.prixaukm_tb.Text != null && this.total_tb.Text != null)
                {
                    int id = Int32.Parse(this.id_tb.Text);
                    int nc = Int32.Parse(this.client_tb.Text);
                    string etat = Convert.ToString(checkBoxEtat.CheckState);
                    string pp = this.prixpeage_tb.Text;
                    string pc = this.prixcarburant_tb.Text;
                    string pm = this.prixmaint_tb.Text;
                    string pa = this.prixassur_tb.Text;
                    string pkm = this.prixaukm_tb.Text;
                    string pv = this.prixvehicule_tb.Text;
                    string pch = this.prixchauffeur_tb.Text;
                    string fe = this.fraisemploye_tb.Text;
                    string am = this.ammort_tb.Text;
                    string ress = ressource_tb.Text;
                    string kc = this.kmclient_tb.Text;
                    string ka = this.kmallee_tb.Text;
                    string kr = this.kmretour_tb.Text;
                    string vm = this.volumemarchandise_tb.Text;
                    string ddebut = Convert.ToString(this.dateTimePickerD.Text);
                    string dfin = Convert.ToString(this.dateTimePickerF.Text);


                    string req = "update Devis set idClient=" + nc + ", Etat='" + etat + "', PrixPeage=" + pp + ", PrixCarburant=" + pc + ", PrixMaintenance=" + pm + ", PrixAssurance=" + pa + ", PrixKm= " + pkm + ", PrixVe= " + pv + ", PrixChauff= " + pch + ", FraisEmploye=" + fe + ", Ammortissement=" + am + ", ResourcesMaterielles='" + ress + "', KmClient=" + kc + ", KmAllee=" + ka + ", KmRetour=" + kr + ", VolumesMarchandises=" + vm + ", DateDebut='" + ddebut + "', DateFin='" + dfin + "' where idDevis=" + id + ";";
                    gestionBdd.request_action(req);

                    MessageBox.Show("Devis Modifié!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    calcul_textboxs();

                    this.buttonAjout.Text = "mod";

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
                int nd = Int32.Parse(this.id_tb.Text);


                string req = "Delete from Devis Where idDevis = " + nd + ";";
                gestionBdd.request_action(req);

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Devis Supprimé!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
