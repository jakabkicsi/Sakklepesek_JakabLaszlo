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
        
        

        public MainWindow()
        {
            InitializeComponent();

            ComboBoxFeltoltes();
            FeluletGeneralas();
            
            
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
