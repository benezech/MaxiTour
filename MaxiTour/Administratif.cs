using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Administratif : Employe
    {

        public enum Poste { Comptable, Secretaire};
        private Poste _poste;

        #region constructeurs

        public Administratif( string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email, DateTime dateEmbauche, string typeContrat, double salaire, double nbrHeures, Poste poste)
            : base(nom, prenom, numsecu, adresse, codepostal, ville, telephone, email, dateEmbauche, typeContrat, salaire, nbrHeures)
        {
            this._poste = poste;
        }

        public Administratif (string nom, string prenom, string typeContrat, double salaire, double nbrHeures, Poste poste)
            : base(nom, prenom, typeContrat, salaire, nbrHeures)
        {
            this._poste = poste;
        }

        #endregion
    }
}
