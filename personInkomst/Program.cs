using System;
using System.Collections.Generic;

namespace personInkomst
{
    class PersonInkomst
    {
        public string Namn { get; set; }
        public int Lön { get; set; }
        public int Timmar { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            List<PersonInkomst> lista = new List<PersonInkomst>();

            // Upprepa tills användaren skriver tomt i namn
            while (true)
            {
                // Lagra uppgifter i ett objekt
                PersonInkomst objekt = new PersonInkomst();

                // Ange namn och lön
                Console.Write("Ange ditt namn (Enter avslutar): ");
                objekt.Namn = Console.ReadLine();
                Console.Write("Ange ditt timmar (Enter avslutar): ");
                objekt.Timmar = ReadInt();

                // Avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }

                Console.Write("Ange din månadslön: ");
                objekt.Lön = ReadInt();

                // Lägg in i listan
                lista.Add(objekt);

                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}