using System;

using System.Windows;


namespace uppgift3
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

        private void knappPlusClick(Object sender, RoutedEventArgs e)
        {

            // flagga
            bool korrektInmatning = true;

            // Töm resultat rutan
            resultatRuta.Text = "";

            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal 1, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal 2, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }


            if (korrektInmatning)
            {
                resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            }
        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
            // flagga
            bool korrektInmatning = true;

            // Töm resultat rutan
            resultatRuta.Text = "";

            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal 1, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal 2, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }


            if (korrektInmatning)
            {
                resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            }


        }

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
            // flagga
            bool korrektInmatning = true;

            // Töm resultat rutan
            resultatRuta.Text = "";

            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal 1, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal 2, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }


            if (korrektInmatning)
            {
                resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            }


        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            // flagga
            bool korrektInmatning = true;

            // Töm resultat rutan
            resultatRuta.Text = "";

            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal 1, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal 2, fel inmatning. \n Formatet skall vara följande ex: 2,5");
                korrektInmatning = false;
            }


            if (korrektInmatning)
            {
                resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            }


        }
    }
}