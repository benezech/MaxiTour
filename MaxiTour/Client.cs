using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Client : Personne
    {
        public string RaisonSociale { get; private set; }
        public int Siret { get; private set; }
        public string CodeNaf { get; private set; }
        public Devis DevisClient { get; set; }

        public string detailClient
        {
            get
            {
                return Id + "-" + Nom + " " + Prenom + " " + RaisonSociale;
            }
        }

        #region constructeurs

        public Client ( int id, string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email,string raisonSociale, int siret, string codeNaf)
            : base(id, nom, prenom, numsecu, adresse, codepostal, ville, telephone, email)

        {

            this.RaisonSociale = raisonSociale;
            this.Siret = siret;
            this.CodeNaf = codeNaf;

        }

        public Client (string nom, string prenom)
            : base( nom, prenom)
        {

        }

        public Client()
            : base()
        {

        }



        #endregion
    }
}
