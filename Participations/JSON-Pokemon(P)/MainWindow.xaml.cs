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

namespace JSON_Pokemon_P_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string path = "https://pokeapi.co/api/v2/pokemon?offset=20&limit=20";
            PokemonAPI pokeAPI;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;

                pokeAPI = JsonConvert.DeserializeObject<PokemonAPI>(json);

            }
            foreach (var pokemon in pokeAPI.results)
            {
                lstPokemonAll.Items.Add(pokemon);
            }

           
           
        }


        private void lstPokemonAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Sprites selectedCharacter = (Sprites)lstPokemonAll.SelectedItem;

            string url = Sprites.url;
            imgPokemonImage.Source = new BitmapImage(new System.Uri(selectedCharacter));

        }
    }
}
