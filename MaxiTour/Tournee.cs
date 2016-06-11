using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Tournee : TourneePrevi
    {



        #region List
        
        public List<Camion> ListeCamion { get; private set; }

        #endregion

        #region Constructeur
        public Tournee(int id, string etat, double duree, string intituleLiaison, string depart, string arrivee, int frequence, int periodicite, int nparjour)
           : base  (id, etat, duree, intituleLiaison,  depart, arrivee, frequence, periodicite, nparjour)
        {
            this.ListeChauffeur = new List<Chauffeur>();
            this.ListeCamion = new List<Camion>();
           
        }

        public Tournee()
        {

        }


        #endregion
        
    }
}
