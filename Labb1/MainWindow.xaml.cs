using System;
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

namespace Labb1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textRuta.Text = "....";

        }
        private void Skicka_Click(object sender, RoutedEventArgs e)
        {
            // Skriv ut en dialogruta
            //MessageBox.Show(inputruta.Text);

            string inTexten = "";

            // Läs in från formuläret
            inTexten = inputRuta.Text;

            // Skriv ut i formuläret
            textRuta.Text = inTexten;
        }
    }
}

