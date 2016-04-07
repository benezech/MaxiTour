using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTour
{
    class Imprevus
    {
        public string Type { get; private set; }
        public double Cout { get; private set; }

        #region Constructeur
        public Imprevus(string type, double cout)
        {
            Type = type;
            Cout = cout;
        }
        #endregion
    }
}
