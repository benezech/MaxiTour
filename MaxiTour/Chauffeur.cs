using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Chauffeur : Personne
    {
        public string DateEmbauche { get; private set; }
        public string TypeContrat { get; set; }
        public double Salaire { get; set; }
        public double NombreHeure { get; set; }

        public List<Tournee> ListeTournee { get; set; }
        public List<Camion> ListeCamion { get; set; }
        public List<TourneePrevi> ListeTourneePrevi { get; set; }
        #region constructeurs

        public Chauffeur (int id, string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email, string dateEmbauche, string typeContrat, double salaire, double nombreHeure)
            : base ( id, nom,  prenom,  numsecu,  adresse,  codepostal,  ville,  telephone,  email)
        {
            this.ListeTournee = new List<Tournee>();
            this.ListeCamion = new List<Camion>();
            this.ListeTourneePrevi = new List<TourneePrevi>();
        }


        public Chauffeur()
        {

        }

        #endregion

        #region fonction
        /*fonction à faire : saisirHeure()*/
        #endregion
    }
}
