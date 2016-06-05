using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Contrat : Devis
    {
        public List<Facture> ListeFacture { get; set; }
        public List<Tournee> ListeTournee { get; set; }

        public Contrat(int id, string etat, double prixPeage, double prixCarburant, double prixMaintenance, double prixAssurance, double salaireEmploye,
                       double fraisEmploye, double taxe, double ammortissement, string ressourceMateriel,
                       double kmClient, double kmAlle, double kmRetour, double volumeMarchandise, string dateDebut, string dateFin)
            : base(id, etat, prixPeage, prixCarburant, prixMaintenance, prixAssurance, salaireEmploye, fraisEmploye, 
                   taxe, ammortissement, ressourceMateriel, kmClient, kmAlle, kmRetour, volumeMarchandise, dateDebut, dateFin)
        {
            this.ListeFacture = new List<Facture>();
            this.ListeTournee = new List<Tournee>();
        }


        public double kmTotalC(double kmc, double kma, double kmr)
        {
            double kmTotal;
            kmTotal = kmc + kma + kmr;

            return kmTotal;
        }
    }
}

