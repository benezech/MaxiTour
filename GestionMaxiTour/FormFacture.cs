﻿using System;
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

    public partial class FormFacture : Form
    {
        GestionBDD gestionBdd = new GestionBDD();
        Facture facture = new Facture();

        int position= 0;
        
       
        public FormFacture()
        {
            InitializeComponent();
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            gestionBdd.Connexion();

            dataGridFacture.DataSource = gestionBdd.request_select("SELECT * FROM facture");

            comboBoxImp.DataSource = gestionBdd.request_select("select TypeImprevus from Imprevus");
            comboBoxImp.DisplayMember = "TypeImprevus";


            refresh_textboxs();
        }

        public void refresh_textboxs()
        {
            DataTable donnees = gestionBdd.request_select("select * from facture");

            textBoxNumF.Text = gestionBdd.getField_Datable(donnees, position, 0);
            textBoxNumD.Text = gestionBdd.getField_Datable(donnees, position, 1);
            textBoxDateF.Text = gestionBdd.getField_Datable(donnees, position, 2);
            textBoxHT.Text = gestionBdd.getField_Datable(donnees, position, 3);
            textBoxTVA.Text = gestionBdd.getField_Datable(donnees, position, 4);
            textBoxTTC.Text = gestionBdd.getField_Datable(donnees, position, 5);


        }

        public void initialize_textboxs()
        {

            textBoxNumF.Text = "numéro automatique";
            textBoxNumD.Text = "";
            textBoxDateF.Text = "choisir date en dessous";
            textBoxHT.Text = "calcul automatique";
            textBoxTVA.Text = "calcul automatique";
            textBoxTTC.Text = "";


        }

        private void buttonDebut_Click(object sender, EventArgs e)
        {
            position = 0;

            refresh_textboxs();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from facture").Rows.Count - 1)
            {
                position = position + 1;

            }

            refresh_textboxs();
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            position = gestionBdd.request_select("select * from facture").Rows.Count - 1;

            refresh_textboxs();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (position < gestionBdd.request_select("select * from facture").Rows.Count && position > 0)
            {
                position = position - 1;

            }

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
                if (this.textBoxNumD != null && this.textBoxDateF != null && this.textBoxHT != null
                    && this.textBoxTVA != null && this.textBoxTTC != null)
                {
                    int nd = Int32.Parse(this.textBoxNumD.Text);
                    string df = Convert.ToString(this.dateTimePickerF.Text);
                    double ttc = Convert.ToDouble(this.textBoxTTC.Text);
                    double tva = facture.calculTVA(Convert.ToDouble(this.textBoxTTC.Text));
                    double ht = facture.calculHT(Convert.ToDouble(this.textBoxTTC.Text), tva);

                    string req = "Insert into Facture Values ( null, " + nd + ",'" + df + "'," + ht + "," + tva + "," + ttc + ");";
                    gestionBdd.request_action(req);
                    dataGridFacture.DataSource = gestionBdd.request_select("SELECT * FROM facture");

                    MessageBox.Show("Facture Ajoutée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int nf = Int32.Parse(this.textBoxNumF.Text);


                string req = "Delete from Facture Where NumFacture = " + nf + ";";
                gestionBdd.request_action(req);
                dataGridFacture.DataSource = gestionBdd.request_select("SELECT * FROM facture");

                position = 0;

                refresh_textboxs();

                this.buttonSupprim.Text = "-";

                MessageBox.Show("Facture Supprimée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (this.buttonModif.Text == "mod")
            {
                this.buttonModif.Text = "Modif";
            }


            else
                if (this.textBoxNumD != null && this.textBoxDateF != null && this.textBoxHT != null
                    && this.textBoxTVA != null && this.textBoxTTC != null)
                {
                    int cf = Int32.Parse(this.textBoxNumF.Text);
                    int nd = Int32.Parse(this.textBoxNumD.Text);
                    string df = Convert.ToString(this.dateTimePickerF.Text);
                    double ttc = Convert.ToDouble(this.textBoxTTC.Text);
                    double tva = facture.calculTVA(Convert.ToDouble(this.textBoxTTC.Text));
                    double ht = facture.calculHT(Convert.ToDouble(this.textBoxTTC.Text), tva);

                    string req = "update Facture Set idDevis= " + nd + ", DateFacture='" + df + "', TotalHT= " + ht + ", TVA= " + tva + ", TotalTTC=" + ttc + " where NumFacture =" + cf + ";";
                    gestionBdd.request_action(req);
                    dataGridFacture.DataSource = gestionBdd.request_select("SELECT * FROM facture");

                    MessageBox.Show("Facture Modifiée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refresh_textboxs();

                    this.buttonModif.Text = "mod";

                }
                else
                {
                    MessageBox.Show("Il manque un ou plusieurs champs !", "Alerte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*public afficherImprevus()
        {
            foreach (Imprevus unimprevus in facture.ListeImprevus){ assignedToColumn.Items.Add(unimprevus);}
        }*/



    }
}
