using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class TourneePrevi
    {
        #region GetSet
        public double Duree { get; private set; }
        public string IntituleLiaison { get; private set; }
        public string Depart { get; private set; }
        public string Destination { get; private set; }
        public double Frequence { get; private set; }
        #endregion

        #region List
        public List<Devis> ListeDevis = new List<Devis>();
        public List<Chauffeur> ListeChauffeur = new List<Chauffeur>();
        #endregion

        #region Constructeur
        public TourneePrevi(double duree, string intituleLiaison, string depart, string destination, double frequence)
        {
            Duree = duree;
            IntituleLiaison = intituleLiaison;
            Depart = depart;
            Destination = destination;
            Frequence = frequence;
        }


        public TourneePrevi(double duree, string intituleLiaison)
        {
            Duree = duree;
            IntituleLiaison = intituleLiaison;
        }
        #endregion
    }
}
