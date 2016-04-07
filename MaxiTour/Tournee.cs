using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Tournee
    {

        #region GetSet
        public double DurreTournee { get; private set; }
        public string IntituleLiaison { get; private set; }
        public string TypeLiaison { get; private set; }
        public string Depart { get; private set; }
        public string Destination { get; private set; }
        public double Frequence { get; private set; }
        #endregion

        #region List
        public List<Chauffeur> ListeChauffeur { get; private set; }
        public List<Camion> ListeCamion { get; private set; }
        #endregion

        #region Constructeur
        public Tournee(double durreTournee, string intituleLiaison, string typeLiaison, string depart, string destination, double frequence)
        {
            DurreTournee = durreTournee;
            IntituleLiaison = intituleLiaison;
            TypeLiaison = typeLiaison;
            Depart = depart;
            Destination = destination;
            Frequence = frequence;
        }


        public Tournee(double durreTournee, string intituleLiaison)
        {
            DurreTournee = durreTournee;
            IntituleLiaison = intituleLiaison;
        }
        #endregion
        
    }
}
