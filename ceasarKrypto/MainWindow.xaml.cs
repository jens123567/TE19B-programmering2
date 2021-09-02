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

namespace Labb2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }
        private void clickText(Object sender, RoutedEventArgs e)
        {
            reverseText.Text = krypto(inputText.Text);

            string krypto(string text)
            {
            int nyckel = int.Parse(keyString.Text);

                string kryptoText = "";
                for (int i = 0; i < text.Length; i++){
                char bokstav = text[i];

                int ascii = (int)bokstav;

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);

                kryptoText += kryptadBokstav.ToString();
            }
                return kryptoText;
            }
        }

    }
}
