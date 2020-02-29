using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPF_JSON_GOTQuote_P_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GOTAPI GotStuff;
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://got-quotes.herokuapp.com/quotes";


            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                GotStuff = JsonConvert.DeserializeObject<GOTAPI>(json);
            }

            lblQuote.Content = $"'{GotStuff.quote}' - {GotStuff.character}";

            string googleimage = $"https://www.google.com/search?q={GotStuff.character}&rlz=1C1GCEU_enUS863US863&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiTofiH6eDnAhUC26wKHZLlD7kQ_AUoAXoECBoQAw&biw=1920&bih=969";

            wbGotImage.Source = (new System.Uri(googleimage));
            imgGotImage.Source = new BitmapImage(new System.Uri(googleimage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://got-quotes.herokuapp.com/quotes";

            string googleimage = $"https://www.google.com/search?q={GotStuff.character}&rlz=1C1GCEU_enUS863US863&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiTofiH6eDnAhUC26wKHZLlD7kQ_AUoAXoECBoQAw&biw=1920&bih=969";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                GotStuff = JsonConvert.DeserializeObject<GOTAPI>(json);
            }

            lblQuote.Content = $"'{GotStuff.quote}' - {GotStuff.character}";

           

            wbGotImage.Source = (new System.Uri(googleimage));
            imgGotImage.Source = new BitmapImage(new System.Uri(googleimage));

        }
    }
}
