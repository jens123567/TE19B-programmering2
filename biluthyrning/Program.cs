using System;
using System.Collections.Generic;

namespace biluthyrning
{
    // bilkostnad 
    //volvo  ABC123 500 kr/d
    //saab DEF456 400 kr/d
    //fiat GHI789 199 kr/d
    //extra kilometer = 2 kr/km
    // Arrray? [["ABC123", "500"], ["DEF456", "400"], ["GHI789", "199"]]

    class Program
    {
        static List<Avtal> avtalsLista = new List<Avtal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommer till biluthyrningen!");

            string körIgen = "y";
            while (körIgen == "y")
            {
                Avtal avtal1 = new Avtal();

                Console.WriteLine("Ange personnummer på kunden:");
                avtal1.Personnr = Console.ReadLine();

                Console.WriteLine("Ange bilens regnummer:");
                avtal1.RegNr = Console.ReadLine().ToUpper();

                Console.WriteLine("Ange bilens extra körsträcka (km):");
                avtal1.Km = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange antal hela dygn:");
                avtal1.Tidsram = int.Parse(Console.ReadLine());

                avtal1.Datum = DateTime.Today;

                // räkna ut total kostnad 
                while (avtal1.RäknaKostnad() == null)
                {
                    Console.WriteLine("Bilen finns inte, ange nytt regnummer");
                    avtal1.RegNr = Console.ReadLine().ToUpper();

                }
                Console.WriteLine($"Hyran kommer att kosta: {avtal1.RäknaKostnad()}kr");
                Console.WriteLine($"Bilen ska lämnas in {avtal1.RäknaInlämningsdatum()}");

                Console.WriteLine("vill du mata in en till kund?(Y/N)");
                avtalsLista.Add(avtal1);
                körIgen = Console.ReadLine().ToLower();
            }

        }
    }

    public class Avtal
    {

        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }

        private IDictionary<string, int> bilar = new Dictionary<string, int>
        {
            {"ABC123", 500},
            {"DEF456", 400},
            {"GHI789", 199}
        };

        public int? RäknaKostnad()
        {

            if (bilar.ContainsKey(RegNr))
            {
                Kostnad = bilar[RegNr] * Tidsram + Km * 2;
                return Kostnad;
            }
            else
            {
                return null;
            }


        }

        public DateTime RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram);
        }
    }

}