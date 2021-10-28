using System.Collections.Generic;
using System;
using System.IO;
using Newtonsoft.Json;

namespace _2021_10_28
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Räkna ut lönekostnad");

            List<PersonInkomst> personLista = new List<PersonInkomst>();

            while (true)
            {
                PersonInkomst person = new PersonInkomst();
                //ange namn
                Console.WriteLine("vad heter den anställde?");
                person.namn = Console.ReadLine();

                // avslulta om namn är tomt
                if (person.namn == "")
                {
                    break;
                }

                //ange timlön
                Console.WriteLine("Hur mycet ör den anställdes timlön");
                person.lön = ReadInt();

                //ange arbete
                Console.WriteLine("Hur mycet ör den anställdes arbetstid");
                person.timmar = ReadInt();

                // lägg till i lista
                personLista.Add(person);
            }

            string jsonText = JsonConvert.SerializeObject(personLista, Formatting.Indented);

            File.WriteAllText(@"fil.json", jsonText);
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
