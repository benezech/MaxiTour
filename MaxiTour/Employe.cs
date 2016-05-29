using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public abstract class Employe : Personne
    {
        public DateTime DateEmbauche { get; private set; }
        public string TypeContrat { get; set; }
        public double Salaire { get; set; }
        public double NbrHeures { get; set; }

        #region constructeurs

        public Employe ( string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email, DateTime dateEmbauche, string typeContrat, double salaire, double nbrHeures)
            : base(nom, prenom, numsecu, adresse, codepostal, ville, telephone, email)
        {
            this.DateEmbauche = dateEmbauche;
            this.TypeContrat = typeContrat;
            this.Salaire = salaire;
            this.NbrHeures = nbrHeures;
        }

        public Employe(string nom, string prenom,  string typeContrat, double salaire, double nbrHeures)
            : base(nom, prenom)
        {
            this.TypeContrat = typeContrat;
            this.Salaire = salaire;
            this.NbrHeures = nbrHeures;
        }

        #endregion
    }
}
