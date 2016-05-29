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
        public Tournee(bool etat, double duree, string intituleLiaison, string typeLiaison, string depart, string destination, double frequence)
           : base  (etat, duree, intituleLiaison, typeLiaison, depart, destination, frequence)
        {
            this.ListeChauffeur = new List<Chauffeur>();
            this.ListeCamion = new List<Camion>();
           
        }


        #endregion
        
    }
}
