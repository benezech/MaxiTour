using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class TourneePrevi
    {
        #region GetSet
        public int Id { get; private set; }
        public string Etat { get; private set; }
        public double Duree { get; private set; }
        public string IntituleLiaison { get; private set; }
        public string Depart { get; private set; }
        public string Arrivee { get; private set; }
        public int Frequence { get; private set; }
        public int Periodicite { get; private set; }
        public int NparJour { get; private set; }
        #endregion

        #region List
        public List<Devis> ListeDevis = new List<Devis>();
        public List<Chauffeur> ListeChauffeur = new List<Chauffeur>();
        #endregion

        #region Constructeur
        public TourneePrevi(int id, string etat, double duree, string intituleLiaison,  string depart, string arrivee, int frequence, int periodicite, int nparjour)
        {
            Id = id;
            Etat = etat;
            Duree = duree;
            IntituleLiaison = intituleLiaison;
            Depart = depart;
            Arrivee = arrivee;
            Frequence = frequence;
            Periodicite = periodicite;
            NparJour = nparjour;
        }

         public TourneePrevi()
        {

        }


        public TourneePrevi(double duree, string intituleLiaison)
        {
            Duree = duree;
            IntituleLiaison = intituleLiaison;
        }
        #endregion
    }
}
