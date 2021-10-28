using System.IO;
using System;
using Newtonsoft.Json;

namespace jsonIntro
{
    class Film
    {
        public string Titel;
        public string Årtal;
        public string Regisör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Film avatar = new Film
            {
                Titel = "avatar",
                Årtal = "2009",
                Regisör = "James Cameron"
            };

            Film legend = new Film
            {
                Titel = "I am legend",
                Årtal = "2008",
                Regisör = "Francis Lawrence"
            };

            Film interstellar = new Film
            {
                Titel = "interstellar",
                Årtal = "2014",
                Regisör = "Christopher Nolan"
            };

            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            Console.WriteLine(jsonText);



        }
    }
}
