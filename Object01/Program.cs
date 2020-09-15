using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            return (nev + " vagyok " + eletkor + " eves ");
        //    string valasz = $"{nev} vagyok {eletkor} éves";
        //    return valasz;
        }
    }

    class Teglalap
    {
        private int a;
        private int b;

        public Teglalap(int oldala, int oldalb)
        {
            a = oldala;
            b = oldalb;
        }


        public int Kerulet()
        {
            int kerulet = 2 * a + 2 * b;
            return kerulet;
        }

        public int Terulet()
        {
            int terulet = a * b;
            return terulet;
        }
    }

    class Kor
    {
        private int r;

        public Kor(int sugar)
        {
            if (sugar < 1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
            
        }

        public double Terulet()
        {
            double t = r * r * Math.PI;
            return t;
        }

        public double Kerulet()
        {
            double k = 2 * r * Math.PI;
            return k;
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine("sugár: {0}",r);
            Console.WriteLine("terület: {0}",Terulet());
            Console.WriteLine("kerlet: {0}",Kerulet());
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Ember Pisti = new Ember();

            //Pisti.nev = "Nagy Pisti";
            //Pisti.eletkor = 20;

            //Pisti.eletkor++;
            //Ember Eva = new Ember();

            //Eva.nev = "Nagy Éva";
            //Eva.eletkor = 18;
            //Console.WriteLine(Pisti.Bemutatkozas());
            //Console.WriteLine(Eva.Bemutatkozas());

            Console.WriteLine("KÖR**********************");
            Console.WriteLine("Kör sugara");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);
            k.AdatokKiirasa();
            //k.r = int.Parse(Console.ReadLine());

            //Console.WriteLine("kerület {0}",k.Kerulet());
            //Console.WriteLine("terület {0}",k.Terulet());
            
            Console.WriteLine("TÉGLALAP*****************");
            Console.WriteLine("Téglalap a oldala");
            int oldala = int.Parse(Console.ReadLine());
            Console.WriteLine("Téglalap b oldala");
            int oldalb = int.Parse(Console.ReadLine());
            Teglalap t = new Teglalap(oldala, oldalb);

            Console.WriteLine("kerület {0}",t.Kerulet());
            Console.WriteLine("terület {0}",t.Terulet());



            Console.ReadKey();
        }
    }
}
