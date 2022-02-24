﻿using System;
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

namespace labb19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Bok> bokSamling = new List<Bok>();
        static List<Film> filmSamling = new List<Film>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            Bok boken = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaSidor.Text);
            bokSamling.Add(boken);
            rutaResultat.Items.Add(boken.TillText());
        }
        private void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            Film filmen = new Film(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängd.Text);
            filmSamling.Add(filmen);
            rutaResultat.Items.Add(filmen.TillText());
        }

    }
    class Media
    {
        public string Titel { get; set; }

        public virtual string TillText()
        {
            return ("");
        }
    }

    class Film : Media
    {
        public string Regissör { get; set; }
        public string Längd { get; set; }

        public Film(string titel, string regissör, string längd)
        {
            Regissör = regissör;
            Titel = titel;
            Längd = längd;
        }
        public override string TillText()
        {
            return ($"{Titel}({Regissör}{Längd})");

        }
    }
    class Bok : Media
    {
        public string Författare { get; set; }
        public string AntalSidor { get; set; }

        public Bok(string titel, string författare, string antalSidor)
        {
            Författare = författare;
            Titel = titel;
            AntalSidor = antalSidor;
        }
        public override string TillText()
        {
            return ($"{Titel} ({Författare}, {AntalSidor})");
        }
    }
}
