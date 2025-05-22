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

namespace _20250521
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string kimenet = "";
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Kijelzo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Szam(object sender, RoutedEventArgs e)
        {
           kimenet += ((Button)sender).Content.ToString();
           Kijelzo.Text = kimenet;         
        }

        private void Szazalek(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void CE(object sender, RoutedEventArgs e)
        {
            kimenet = "";
            Kijelzo.Text = kimenet;
        }

        private void C(object sender, RoutedEventArgs e)
        {
            kimenet = "";
            Kijelzo.Text = kimenet;
        }

        private void Torles(object sender, RoutedEventArgs e)
        {
            string szoveg = "";
            for (int i = 0; i < kimenet.Length - 1; i++)
            {
                szoveg += kimenet[i];
            }
            kimenet = szoveg;
            Kijelzo.Text = szoveg;
        }

        private void Reciprok(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Negyzet(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Gyok(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Muvelet(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Szorzas(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Osszeadas(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Egyenlo(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Elojel(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }

        private void Tizedes(object sender, RoutedEventArgs e)
        {
            kimenet += ((Button)sender).Content.ToString();
            Kijelzo.Text = kimenet;
        }
    }
}
