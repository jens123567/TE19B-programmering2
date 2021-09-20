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

namespace uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float summa;
        public int antalTal;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void knappAdderaClick(Object sender, RoutedEventArgs e)
        {
            float tal;
            if (!float.TryParse(talRuta.Text, out tal))
            {
                MessageBox.Show("Fel inmatning, försök igen");
            }
            else
            {
                antalTal++;
                summaRuta.Text = $"{tal} + {summa} = {tal + summa}";
                summa = tal + summa;

                medelRuta.Text = $"{summa}/{antalTal} = {summa / antalTal}";
            }

            talRuta.Text = "";
        }
    }
}
