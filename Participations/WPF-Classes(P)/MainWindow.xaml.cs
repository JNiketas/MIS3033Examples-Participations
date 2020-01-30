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

namespace WPF_Classes_P_
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            string Name, Address, ZipCodeString;
            int ZipCode;

            Name = txtName.Text;
            Address = txtAddress.Text;
            ZipCodeString = txtZipcode.Text;

            ZipCode = Convert.ToInt32(ZipCodeString);

            EntryForm EF = new EntryForm();
            EF.Address = Address;
            EF.Name = Name;
            EF.ZipCode = ZipCode;

            lstForm.Items.Add(EF);
        }
    }
}
