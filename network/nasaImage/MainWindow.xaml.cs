using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using RestSharp;
using System.Text.Json;

namespace nasaImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            string url = "https://swapi.dev/api/ ";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            // Skapa objektet som skall lagra json-data
            Img lista = new AllData();

            // Stoppa in svaret i Joke-objektet
            lista = JsonSerializer.Deserialize<AllData>(response.Content);



            image1.Source = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/2111/LLPegasi_HubbleLodge_960.jpg"));
        }
    }


    class Img
    {
        public string url { get; set; }
    }
}
