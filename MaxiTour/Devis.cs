using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Devis
    {
        public int Id { get; private set; }
        public bool Etat { get; set; }
        public double PrixPeage { get; set; }
        public double PrixCarburant { get; set; }
        public double PrixMaintenance { get; set; }

        public double FraisEmploye { get; set; }
        public double PrixAssurance { get; set; }
        public double Taxe { get; set; }
        public double Ammortissement { get; set; }
        public string RessourceMateriel { get; set; }
        public double KmClient { get; set; }
        public double KmAlle { get; set; }
        public double KmRetour { get; set; }
        public double Benef { get; set; }
        public double VolumeMarchandise { get; set; }
        List<TourneePrevi> ListTourneePrevi = new List<TourneePrevi>();
        const int ConsoCamion = 10;


        #region constructeurs

        public Devis ( int id, bool etat, double prixPeage, double prixCarburant, double prixMaintenance, double salaireEmploye, 
                       double fraisEmploye,double prixAssurance, double taxe, double ammortissement, string ressourceMateriel,
                       double kmClient, double kmAlle, double kmRetour,  double benef, double volumeMarchandise) 
        {
            this.Id = id;
            this.Etat = etat;
            this.PrixPeage = prixPeage;
            this.PrixCarburant = prixCarburant;
            this.PrixMaintenance = prixMaintenance;

            this.FraisEmploye = fraisEmploye;
            this.PrixAssurance = prixAssurance;
            this.Taxe = taxe;
            this.Ammortissement = ammortissement;
            this.RessourceMateriel = ressourceMateriel;
            this.KmClient = kmClient;
            this.KmAlle = kmRetour;
            this.KmRetour = kmRetour;
            this.Benef = benef;
            this.VolumeMarchandise = volumeMarchandise;
        }

        #endregion

        /*fonctions à faire : */

        #region Fonctions
        public double kmPerdu()
        {
            double kmPerdu;
            kmPerdu = KmAlle + KmRetour;

            return kmPerdu;
        }

        public double kmTotal()
        {
            double kmTotal;
            kmTotal = KmClient + KmAlle + KmRetour;

            return kmTotal;
        }

        public double sousTotalPrixVehicule()
        {
            double total;

            total = PrixMaintenance + PrixPeage + PrixCarburant;
            /* total = PrixMaintenance + PrixPeage + consoCamion();*/
            return total;

        }

        public double sousTotalPrixKm()
        {
            double total;

            total = (prixAuKm() * KmClient) + PrixPeage;
            /* (( consoCamion  / 100 ) * prixCarburant ) * KmClient ) + péage */

            return total;

        }
        public double sousTotalPrixChauffeur()
        {
            double total;
            double SalaireChauffeur = 0;
            total = SalaireChauffeur + FraisEmploye;
            /* salaireEmployé + frai employé */

            return total;

        }

        public double TotalCout()
        {
            double total = this.sousTotalPrixChauffeur() + this.sousTotalPrixKm() + this.sousTotalPrixVehicule();
            return total;
        }

        public double CalculFacturation()
        {
            double Factu = this.TotalCout() + this.Benef;
            return Factu;
        }


        public double prixAuKm()
        {
            double total;

            total = (ConsoCamion / 100) * PrixCarburant;

            return total;

        }

        public double prixAuKmV2()
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
        }
        #endregion
    }
}
