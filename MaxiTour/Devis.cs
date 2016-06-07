using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Devis
    {
        public int Id { get; private set; }
        public string Etat { get; set; }
        public double PrixPeage { get; set; }
        public double PrixCarburant { get; set; }
        public double PrixMaintenance { get; set; }
        public double PrixAssurance { get; set; }
        public double FraisEmploye { get; set; }
        public double Taxe { get; set; }
        public double Ammortissement { get; set; }
        public string RessourceMateriel { get; set; }
        public double KmClient { get; set; }
        public double KmAlle { get; set; }
        public double KmRetour { get; set; }
        public double VolumeMarchandise { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }

        public Client Client { get; set; }

        List<TourneePrevi> ListTourneePrevi = new List<TourneePrevi>();
        


        #region constructeurs

        public Devis(int id, string etat, double prixPeage, double prixCarburant, double prixMaintenance, double prixAssurance, double salaireEmploye, 
                       double fraisEmploye, double taxe, double ammortissement, string ressourceMateriel,
                       double kmClient, double kmAlle, double kmRetour, double volumeMarchandise, string dateDebut, string dateFin) 
        {
            this.Id = id;
            this.Etat = etat;
            this.PrixPeage = prixPeage;
            this.PrixCarburant = prixCarburant;
            this.PrixMaintenance = prixMaintenance;
            this.PrixAssurance = prixAssurance;
            this.FraisEmploye = fraisEmploye;
            this.Taxe = taxe;
            this.Ammortissement = ammortissement;
            this.RessourceMateriel = ressourceMateriel;
            this.KmClient = kmClient;
            this.KmAlle = kmRetour;
            this.KmRetour = kmRetour;
            this.VolumeMarchandise = volumeMarchandise;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
        }

        public Devis()
        {

        }

        #endregion

 

        #region Fonctions
        public double kmPerdu()
        {
            double kmPerdu;
            kmPerdu = KmAlle + KmRetour;

            return kmPerdu;
        }

        /*public double kmTotal( )
        {
            double kmTotal;
            kmTotal = KmClient + KmAlle + KmRetour;

            return kmTotal;
        }*/

        public double kmTotal(double kmc, double kma, double kmr)
        {
            double kmTotal;
            kmTotal = kmc + kma + kmr;

            return kmTotal;
        }

       /* public double sousTotalPrixVehicule()
        {
            double total;

            total = PrixMaintenance + PrixPeage + prixAuKm();

            return total;

        }*/

        /*public double sousTotalPrixKm()
        {
            double total;

            total = (prixAuKm() * KmClient) + PrixPeage;
            

            return total;

        }*/

        public double sousTotalPrixChauffeur()
        {

            double total;
            double SalaireChauffeur = ;
            total = SalaireChauffeur + FraisEmploye;
            /* salaireEmployé + frai employé */

            return total;

        }

        /*public double TotalCout()
        {
            double total = this.sousTotalPrixChauffeur() + this.sousTotalPrixKm() + this.sousTotalPrixVehicule();
            return total;
        }*/

        /*public double CalculFacturation()
        {
            double Factu = this.TotalCout();
            return Factu;
        }*/


       /* public double prixAuKm()
        {

            double consoCamion = 0;

            // pour chaque tournée prévisionnelle.
            foreach (TourneePrevi tourneeprevi in ListTourneePrevi)
            {

                List<Chauffeur> lc = tourneeprevi.ListeChauffeur;

                foreach (Chauffeur chauffeur in lc)
                {
                    // pour chaque chauffeur des tournées prévisionnelles.

                    List<Camion> lca = chauffeur.ListeCamion;
                    // pour chaque camion que peut conduire un chauffeur .
                    foreach (Camion camion in lca)
                    {
                        // on calcul et additionne la consommation de chaque camion.
                        consoCamion += (camion.Consommation / 100) * PrixCarburant;
                    }


                }

            }

            return consoCamion;
        }*/

        public int getClientId()
        {
            int id = this.Client.Id;

            return id;
        }

        public string[] tourneeprevi()
        {
            string[] tourneesprevi = new string[10];
            
            return tourneesprevi;
        }
        #endregion
    }
}
