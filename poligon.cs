using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace poligon20263_10A
{
    internal class poligon
    {
        public int br_temena;
        tacka[] teme;
        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
            for (int i=0;i<n; i++)
            {
                teme[i] = new tacka();
            }
        }
        public void unos()
        {
            for (int i=0;i<br_temena;i++)
            {
                Console.WriteLine("Ax({0})=", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ay({0})=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                teme[i].x = x;
                teme[i].y= y;
            }
        }
        
    }
}
