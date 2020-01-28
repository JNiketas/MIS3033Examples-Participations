//John Niketas
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

namespace WPFexample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.Text = "";
            txtLastName.Text = string.Empty;
            txtBirthdate.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            lstLetters.Items.Clear();

            string firstName, lastName, birthDate;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            birthDate = txtBirthdate.Text;

            string fullName = firstName + " " + lastName;
            DateTime dob = Convert.ToDateTime(birthDate);

            foreach (var letter in fullName)
            {
                lstLetters.Items.Add(letter);

            }

            lstLetters.Items.Add($"You were born on a {dob.DayOfWeek}");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you for using our application =)");

            Close();
        }
    }
}
