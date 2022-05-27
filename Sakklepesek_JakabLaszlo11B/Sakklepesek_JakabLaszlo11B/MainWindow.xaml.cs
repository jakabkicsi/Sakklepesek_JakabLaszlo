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

namespace Sakklepesek_JakabLaszlo11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBoxFeltoltes();
            FeluletGeneralas();
        }

        private void FeluletGeneralas()
        {
            
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
