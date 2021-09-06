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

namespace calculator
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

        private void addNumbers(Object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(number1.Text) + int.Parse(number2.Text);
            result.Text = temp.ToString();
        }
        private void subtract(Object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(number1.Text) - int.Parse(number2.Text);
            result.Text = temp.ToString();
        }
        private void multiply(Object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(number1.Text) * int.Parse(number2.Text);
            result.Text = temp.ToString();
        }
        private void divide(Object sender, RoutedEventArgs e)
        {
            int temp = int.Parse(number1.Text) / int.Parse(number2.Text);
            result.Text = temp.ToString();
        }
    }
}
