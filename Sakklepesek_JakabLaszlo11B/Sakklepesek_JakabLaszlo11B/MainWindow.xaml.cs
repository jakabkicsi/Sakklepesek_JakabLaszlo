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
        Rectangle[,] tablaMezoi;
        Grid tabla;
        public MainWindow()
        {
            InitializeComponent();

            ComboBoxFeltoltes();
            FeluletGeneralas();
        }

        private void FeluletGeneralas()
        {
            tablaMezoi = new Rectangle[10, 10];
            char betuJel = 'A';
            for (int i = 1; i < 9; i++)
            {
                Label betu = new Label();
                betu.HorizontalAlignment = HorizontalAlignment.Center;
                betu.VerticalAlignment = VerticalAlignment.Bottom;
                betu.Content = betuJel++;
                tabla.Children.Add(betu);
                Grid.SetRow(betu, 0);
                Grid.SetColumn(betu, i);

                betu = new Label();
                betu.HorizontalAlignment = HorizontalAlignment.Right;
                betu.VerticalAlignment = VerticalAlignment.Center;
                betu.Content = betuJel++;
                tabla.Children.Add(betu);
                Grid.SetRow(betu, 9);
                Grid.SetColumn(betu, i);

                betu = new Label();
                betu.HorizontalAlignment = HorizontalAlignment.Right;
                betu.VerticalAlignment = VerticalAlignment.Center;
                betu.Content = 9 - i;
                tabla.Children.Add(betu);
                Grid.SetRow(betu, i);
                Grid.SetColumn(betu, 9);

                betu = new Label();
                betu.HorizontalAlignment = HorizontalAlignment.Left;
                betu.VerticalAlignment = VerticalAlignment.Center;
                betu.Content = 9 - i;
                tabla.Children.Add(betu);
                Grid.SetRow(betu, i);
                Grid.SetColumn(betu, 9);
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tablaMezoi[i, j] = new Rectangle();
                    tablaMezoi[i, j].Stroke = Brushes.Black;
                    tablaMezoi[i, j].Fill = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black;
                    
                    tabla.Children.Add(tablaMezoi[i, j]);
                    Grid.SetColumn(tablaMezoi[i, j], j);
                    Grid.SetRow(tablaMezoi[i, j], i);


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
