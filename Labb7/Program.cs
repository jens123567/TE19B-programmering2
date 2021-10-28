using System;

namespace Labb7
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonInkomst objekt = new PersonInkomst();

            while (true)
            {
                Console.WriteLine("ange ditt namn");
                objekt.Namn = Console.ReadLine();

                if (objekt.Namn == "")
                {
                    break;


                }
            }



            Console.WriteLine("ange din månadslön");
            objekt.Lön = ReadInt();


        }

        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("du skrev inte in heltal");
            }
            return heltal;
        }
    }
}
