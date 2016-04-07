using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Chauffeur : Employe
    {
        public List<Tournee> ListeTournee { get; set; }
        public List<Camion> ListeCamion { get; set; }
        public List<TourneePrevi> ListeTourneePrevi { get; set; }
        #region constructeurs

        public Chauffeur (string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email, DateTime dateEmbauche, string typeContrat, double salaire, double nbrHeures)
            : base ( nom,  prenom,  numsecu,  adresse,  codepostal,  ville,  telephone,  email,  dateEmbauche,  typeContrat,  salaire, nbrHeures)
        {
            this.ListeTournee = new List<Tournee>();
            this.ListeCamion = new List<Camion>();
            this.ListeTourneePrevi = new List<TourneePrevi>();
        }

        public Chauffeur(string nom, string prenom,  string typeContrat, double salaire, double nbrHeures)
            : base(nom, prenom,  typeContrat, salaire, nbrHeures)
        {

        }

        #endregion

        #region fonction
        /*fonction à faire : saisirHeure()*/
        #endregion
    }
}
