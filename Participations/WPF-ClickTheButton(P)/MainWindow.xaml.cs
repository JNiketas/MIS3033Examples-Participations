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

namespace WPF_ClickTheButton_P_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
        }
       

        private void btnSubmit_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            double randomX = rand.Next(0, 650);
            double randomY = rand.Next(0, 350);

            btnSubmit.Margin = new Thickness(randomX, randomY, 0, 0);
        }
        
    }
}
