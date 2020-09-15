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

    class Program
    {
        static void Main(string[] args)
        {
            Ember Pisti = new Ember();

            Pisti.nev = "Nagy Pisti";
            Pisti.eletkor = 20;

            Pisti.eletkor++;
            Ember Eva = new Ember();

            Eva.nev = "Nagy Éva";
            Eva.eletkor = 18;
            Console.WriteLine(Pisti.Bemutatkozas());
            Console.WriteLine(Eva.Bemutatkozas());

            Console.ReadKey();
        }
    }
}
