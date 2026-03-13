using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace poligon20263_10A
{
    internal class ravan
    {
        public static int SIS(vektor AB, tacka C, tacka D)
        {
            vektor AC = new vektor(AB.pocetak, C);
            vektor AD = new vektor(AB.pocetak, D);
            double ABAC = vektor.VP(AB, AC);
            double ABAD = vektor.VP(AB, AD);
            if (ABAC*ABAD==0)
            {
                return 1;
            }
            if (ABAC*ABAD > 0)
            {
                return 0;
            }
            if (ABAC*ABAD < 0)
            {
                return -1;
            }
            return 5;
        }
    }
}
