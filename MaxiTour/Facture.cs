using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Facture
    {
        #region GetSet
        public int Numero { get; private set; }
        public DateTime DateFacture { get; private set; }
        public DateTime DateTournee { get; private set; }
        public string DepartTournee { get; private set; }
        public string DestinationTournee { get; private set; }
        public double PrixTounee { get; private set; }
        public double TotalHT { get; private set; }
        public double TVA { get; private set; }
        public double TotalTTC { get; private set; }
        #endregion

        public Contrat Contrat { get; private set; }


        #region List
        public List<Imprevus> ListeImprevus { get; private set; }
        #endregion


        #region Constructeur
        public Facture(int numero, DateTime dateFacture, DateTime dateTournee, string departTournee, string destinationTournee, double prixTournee, double totalHt, double tva, double totalttc)
        {
            Numero = numero;
            DateFacture = dateFacture;
            DateTournee = dateTournee;
            DepartTournee = departTournee;
            DestinationTournee = destinationTournee;
            PrixTounee = prixTournee;
            TotalHT = totalHt;
            TVA = tva;
            TotalTTC = totalttc;
        }

        public Facture(int numero, DateTime dateFacture)
        {
            Numero = numero;
            DateFacture = dateFacture;
        }
        #endregion



        

        #region fonction
        public double totalImprevu()
        {
            double totalImp = 0;
            foreach (Imprevus Imp in ListeImprevus)
            {
                totalImp += Imp.Cout;
            }
            return totalImp;
        }
            #endregion


        }
}
