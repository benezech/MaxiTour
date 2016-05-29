using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    public class Imprevus
    {
        public int IdImprevus { get; private set; }
        public string Type { get; private set; }
        public double Cout { get; private set; }

        #region Constructeur
        public Imprevus(int idImprevus, string type, double cout)
        {
            IdImprevus = idImprevus;
            Type = type;
            Cout = cout;
        }

        public Imprevus()
        {
          
        }
        #endregion
    }
}
