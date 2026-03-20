using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        public void stampaj()
        {
            Console.WriteLine($"Poligon od {br_temena} temena: ");
            int i = 1;
            foreach (tacka tacka in teme)
            {
                Console.WriteLine($"A{i} ({tacka.x}, {tacka.y})");
                i++;
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            
            for (int i=0;i<br_temena;i++)
            {              
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            poligon novi = new poligon(n);
            for (int i=0;i<n;i++)
            {
                novi.teme[i].x= Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i].y = Convert.ToDouble(ulaz.ReadLine());
            }
            ulaz.Close();
            return novi;
        }
    }
}
