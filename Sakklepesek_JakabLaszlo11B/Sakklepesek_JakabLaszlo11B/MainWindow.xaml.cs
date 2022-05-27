using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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


namespace Sakklepesek_JakabLaszlo11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tablaMerete = 8;
        Button[,] mezok;
        
        string[] oszlopJelek = { "A", "B", "C", "D", "E", "F", "G", "H" };

        public MainWindow()
        {
            InitializeComponent();

            ComboBoxFeltoltes();
            FeluletGeneralas();
            
            
        }


        private int[] Holvan(Button gomb)
        {
            int[] koordinatak = { -1, -1 };
            for (int i = tablaMerete - 1; i >= 0; i--)
            {
                for (int j = tablaMerete - 1; j >= 0; j--)
                {
                    if (mezok[i, j].Equals(gomb))
                    {
                        i = 7 - i;
                        koordinatak[0] = i;
                        koordinatak[1] = j;
                        return koordinatak;
                    }
                }
            }
            return koordinatak;
        }

        private void KoordinataValasztas(object sender, RoutedEventArgs e)
        {
            Button aktualis = sender as Button;
            int x = Holvan(aktualis)[0];
            int y = Holvan(aktualis)[1];
            x = 8 - x;
            jelenlegiPozicio.Content = oszlopJelek[y] + x.ToString();
        }

        private void FeluletGeneralas()
        {
            tabla.RowDefinitions.Clear();
            tabla.ColumnDefinitions.Clear();
            for (int i = 0; i < tablaMerete; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            
            tabla.Children.Clear();
            mezok = new Button[tablaMerete, tablaMerete];
            for (int i = 0; i < tablaMerete; i++)
            {
                for (int j = 0; j < tablaMerete; j++)
                {
                    mezok[i, j] = new Button();
                    tabla.Children.Add(mezok[i, j]);
                    
                    Grid.SetRow(mezok[i, j], i);
                    Grid.SetColumn(mezok[i, j], j);
                }
            }

            for (int i = 0; i < tablaMerete; i++)
            {
                for (int j = 0; j < tablaMerete; j++)
                {
                    if (j % 2 == 1 && i % 2 == 1)
                    {
                        mezok[i, j].Background = Brushes.White;
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        mezok[i, j].Background = Brushes.White;
                    }
                    else
                    {
                        mezok[i, j].Background = Brushes.Black;
                    }
                }
            }

        }
        private void ComboBoxFeltoltes()
        {
            babukKivalasztasa.Items.Add("FehérParaszt");
            babukKivalasztasa.Items.Add("FeketeParaszt");
            babukKivalasztasa.Items.Add("bástya");
            babukKivalasztasa.Items.Add("ló");
            babukKivalasztasa.Items.Add("futó");
            babukKivalasztasa.Items.Add("királynő");
            babukKivalasztasa.Items.Add("király");
            
        }
    }
}
