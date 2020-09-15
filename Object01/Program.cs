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
        public int a;
        public int b;

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
            
            //Teglalap t = new Teglalap();

            //t.a = 5;
            //t.b = 10;
            //Console.WriteLine("kerület ",t.Kerulet());
            //Console.WriteLine("terület ",t.Terulet());
            
            Console.ReadKey();
        }
    }
}
