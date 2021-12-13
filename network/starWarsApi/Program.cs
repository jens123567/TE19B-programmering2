using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace starWarsApi
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "https://swapi.dev/api/ ";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            // Skapa objektet som skall lagra json-data
            AllData lista = new AllData();

            // Stoppa in svaret i Joke-objektet
            lista = JsonSerializer.Deserialize<AllData>(response.Content);

            foreach (var item in lista.results)
            {
                Console.WriteLine(item.name);
            }
        }
    }
    class Person
    {
        public string name { get; set; }
    }
    class AllData
    {
        public List<Person> results { get; set; }
    }

}
