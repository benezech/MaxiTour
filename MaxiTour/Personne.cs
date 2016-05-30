using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public abstract class Personne
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public int NumSecu { get; private set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        #region constructeurs

        public Personne(int id, string nom, string prenom, int numsecu, string adresse, int codepostal, string ville, int telephone, string email)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumSecu = numsecu;
            this.Adresse = adresse;
            this.CodePostal = codepostal;
            this.Ville = ville;
            this.Telephone = telephone;
            this.Email = email;
        }

        public Personne(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public Personne()
        {

        }

        #endregion
    }
}
