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

namespace WPF_FileProcessing
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

        private void btnPride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();

            var bookContents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            r.Text = bookContents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.BurlyWood;
            r.FontWeight = FontWeights.Bold;

            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;

        }

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            //string path = @"C:\Users\Nike0000\Downloads\SalesJan2009.csv";
            //var contents = File.ReadAllLines(path);

            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv";
            var contents = File.ReadAllLines(path);

            double sumOfPrices = 0;
            for (int i = 1; i < contents.Length; i++)
            {
                string row = contents[i];
                var pieces = row.Split(',');
                double price;
                double.TryParse(pieces[2], out price);
                sumOfPrices = sumOfPrices + price;

                lstSales.Items.Add(pieces[1] + " - " + pieces[2]);
                
            }

            lstSales.Items.Add($"The total is {sumOfPrices.ToString("C2")}");
        }
    }
}
