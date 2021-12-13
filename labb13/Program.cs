using System;

namespace labb13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime idag = DateTime.Now;

            var objekt = new Person();

            Console.WriteLine("skriv förnamn");
            objekt.förnamn = Console.ReadLine();
            Console.WriteLine("skriv efternamn");
            objekt.efternamn = Console.ReadLine();

            objekt.visaNamn();


        }
    }

    class Person
    {
        public string förnamn { get; set; }
        public string efternamn { get; set; }
        public DateTime födelsedag { get; set; }
        public int ålder { get; set; }
        public bool myndig;

        public void visaNamn()
        {
            Console.WriteLine($"ditt namn är {förnamn} {efternamn}");
        }

        /* public void visaÅlder()
         {
             Console.WriteLine($"din ålder är {ålder}");
         }*/
    }
}

