using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund dog = new Hund();

            dog.Name = "Coco";
            dog.Bellen();
            dog.Geschlecht = "Rüde";
            dog.Bewegen();

            Console.ReadKey();
        }
    }

    class Tier
    {
        //Eigenschaften
        public string Geschlecht { get; set; }

        //Methoden
        public void Bewegen()
        {
            Console.WriteLine("Bewegen...");
        }
    }

    class Hund : Tier
    {
        //Eigenchaften
        public string Name { get; set; }

        //Methoden
        public void Schnüffeln()
        {
            Console.WriteLine("Schnüfflen...");
        }
        public void Bellen()
        {
            Console.WriteLine("Bellen...");
        }
    }
}
