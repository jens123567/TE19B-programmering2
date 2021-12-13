using System;
using RestSharp;
using System.Text.Json;

namespace chuckNorrisApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            // Skapa objektet som skall lagra json-data
            Joke skämtet = new Joke();

            // Stoppa in svaret i Joke-objektet
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);
            Console.WriteLine(skämtet.value);

        }
    }
    class Joke
    {
        public string icon_url { get; set; }
        public string id { get; set; }
        public string value { get; set; }
    }
}
