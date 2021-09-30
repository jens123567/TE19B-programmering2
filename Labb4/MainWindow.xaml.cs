using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static string[] rader = new string[194];
        public MainWindow()
        {
            InitializeComponent();


            rader = File.ReadAllLines("./countries.csv");
        }

        /// <summary>
        /// kollar klick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSök(object sender, RoutedEventArgs e)
        {

            rutaResultat.Text = "";


            // Variabler
            int antal = 1;

            string sökterm = rutaSökterm.Text;

            // Loopa igenom alla rader
            //foreach (var rad in rader)
            for (var i = 1; i < rader.Length; i++)
            {
                // Dela upp raden
                string[] delar = rader[i].Split(',');

                // Plocka ut land
                string land = delar[1];

                // Plocka ut landskod
                string landskod = delar[2];

                // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                if (land.ToLower().Contains(sökterm.ToLower()))
                {
                    // Skriv ut matchande land och dess landskod
                    rutaResultat.Text += $"{antal} {land}: {landskod}\n";

                    antal++;
                }


            }

            rutaStatus.Text = $"Hittade {antal - 1} länder.";


            // Summering


        }
    }
}
