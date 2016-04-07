using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Contrat : Devis
    {
        public List<Facture> ListeFacture { get; set; }
        public List<Tournee> ListeTournee { get; set; }

        public Contrat(int id, bool etat, double prixPeage, double prixCarburant, double prixMaintenance, double salaireEmploye,
                       double fraisEmploye, double prixAssurance, double taxe, double ammortissement, string ressourceMateriel,
                       double kmClient, double kmAlle, double kmRetour,double benef, double volumeMarchandise)
            : base(id, etat,  prixPeage,  prixCarburant,  prixMaintenance,  salaireEmploye, fraisEmploye, prixAssurance, taxe,  ammortissement,  ressourceMateriel, kmClient, kmAlle, kmRetour, benef, volumeMarchandise)
        {
            this.ListeFacture = new List<Facture>();
            this.ListeTournee = new List<Tournee>();
        }
    }
}

