using System;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Förnamn Efternamn");
                String[] input = Console.ReadLine().Split(" ");

                if (input.Length == 2)
                {

                }
                else
                {
                    Console.WriteLine("fel inmatning");
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
    public class Person
    {
        private string förnamn;
        private string efternamn;
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
        }

        public virtual string Sammanfattning()
        {
            return "";
        }
    }

    public class Arbetare : Person
    {
        private int lön;
        private int antalTimmar;
        public int Lön { get; set; }
        public int AntalTimmar { get; set; }

        public Arbetare(string förnamn, string efternamn, string lön, string antalTimmar) : base(förnamn, efternamn)
        {

            int result = 0;
            if (!int.TryParse(lön, out result))
            {
                throw new ArgumentException("error")
            }
            else
            {
                Lön = result;
            }

            result = 0;
            if (!int.TryParse(antalTimmar, out result))
            {
                Console.WriteLine("error");
            }
            else
            {
                AntalTimmar = result;
            }



        }

        public float RäknaTimlön()
        {
            return 0f;
        }

        public override string Sammanfattning()
        {
            return "";
        }

    }
}
