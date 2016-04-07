using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Client : Personne
    {
        public string RaisonSociale { get; private set; }
        public int Siret { get; private set; }
        public string CodeNaf { get; private set; }
        public Devis DevisClient { get; set; }
        public Dirigeant ContactClient { get; set; }

        #region constructeurs

        public Client ( string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email,string raisonSociale, int siret, string codeNaf)
            : base(nom, prenom, numsecu, adresse, codepostal, ville, telephone, email)

        {

            this.RaisonSociale = raisonSociale;
            this.Siret = siret;
            this.CodeNaf = codeNaf;

        }

        public Client (string nom, string prenom)
            : base( nom, prenom)
        {
        }

        #endregion
    }
}
