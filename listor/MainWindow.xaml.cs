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

namespace listor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> namnLista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs in namnet
            string namn = rutaNamn.Text;

            // Om namnet ej tomt
            if (namn != "")
            {
                rutaLista.Text += namn + "\n";
                rutaFel.Text = "Inga fel...";
                namnLista.Add(namn);        
            }
            else
            {
                rutaFel.Text = "Inget namn matades in, försök igen!";
            }
        }

        private void clickSpara(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines("namnLista.txt", namnLista);
        }
    }
}
