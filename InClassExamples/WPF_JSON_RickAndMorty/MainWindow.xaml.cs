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

namespace WPF_JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RickAndMortyAPIResult apiInfo;
            string apiURL = "https://rickandmortyapi.com/api/character/";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(apiURL).Result;

                 apiInfo = JsonConvert.DeserializeObject<RickAndMortyAPIResult>(json);
            }

            foreach (var character in apiInfo.results)
            {
                lstCharacters.Items.Add(character);
            }

           
            
        }

        private void lstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultObject selectedCharacter = (ResultObject)lstCharacters.SelectedItem;
            imgCharacter.Source = new BitmapImage(new System.Uri(selectedCharacter.image));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultObject selectedCharacter = (ResultObject)lstCharacters.SelectedItem;
            string googlesearch = $"https://www.google.com/search?q={selectedCharacter.name} rick and morty";

            wbCharacterInfo.Source = new System.Uri(googlesearch);
        }
    }
}
