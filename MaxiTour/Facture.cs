using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Facture
    {
        #region GetSet
        public int Numero { get; private set; }
        public DateTime DateFacture { get; private set; }
        public double TotalHT { get; private set; }
        public double TVA { get; private set; }
        public double TotalTTC { get; private set; }
        #endregion

        #region List
        public List<Imprevus> ListeImprevus = new List<Imprevus>();
        #endregion


        #region Constructeur

        public Facture(int numero, DateTime dateFacture, double totalHt, double tva, double totalttc)
        {
            Numero = numero;
            DateFacture = dateFacture;
            TotalHT = totalHt;
            TVA = tva;
            TotalTTC = totalttc;
        }

        public Facture(int numero, DateTime dateFacture)
        {
            Numero = numero;
            DateFacture = dateFacture;
        }

        public Facture()
        {

        }
        #endregion



        public double totalAvecImprevu()
        {
            double total = this.TotalTTC;

            foreach (Imprevus imprevus in ListeImprevus)
            {
                total += imprevus.Cout;
            }

            return total;

        }

        public double calculTVA(double ttc)
        {
            double tva = 0;

            tva = (20 * ttc) / 100;

            return tva;

        }

        public double calculHT(double ttc, double tva)
        {
            double totalHT = 0;

            totalHT = ttc - tva;

            return totalHT;

        }


     }
}
