using System;

namespace labb14
{
    class Program
    {
        static void Main(string[] args)
        {
            var bok = new Boken();
            Console.WriteLine("skriv in bokens titel");
            bok.titel = Console.ReadLine();
            Console.WriteLine("skriv in bokens författare");
            bok.författare = Console.ReadLine();
            Console.WriteLine("skriv in antal sidor i boken");
            bok.antalSidor = int.Parse(Console.ReadLine());

            bok.SkrivUt();
        }
    }
    class Boken
    {
        public string författare { get; set; }
        public string titel { get; set; }
        public int antalSidor { get; set; }

        public void SkrivUt()
        {
            Console.WriteLine($"{titel} är skriven av {författare} och är {antalSidor} lång");
        }

    }
}
