using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon20263_10A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Balsa Andjic
            //tacka a = new tacka(-1, -1);
            //Console.WriteLine(a.ugao());
            //Console.WriteLine(a.d());
            //tacka A = new tacka(3, 1);
            //tacka B = new tacka(-1, 3);
            //tacka C = new tacka(3, 3);
            //vektor OA = new vektor(A);
            //vektor OB = new vektor(B);
            //vektor AC = new vektor(A,C);
            //Console.WriteLine(vektor.SP(OA, OB));
            //Console.WriteLine(vektor.VP(OA, AC));
            //Console.WriteLine("Koliko temena?");
            //int n=Convert.ToInt32(Console.ReadLine());
            //poligon prvi = new poligon(n);
            //prvi.unos();
            //prvi.stampaj();
            //prvi.snimi();
            poligon drugi = poligon.ucitaj();
            drugi.stampaj();
        }
    }
}
