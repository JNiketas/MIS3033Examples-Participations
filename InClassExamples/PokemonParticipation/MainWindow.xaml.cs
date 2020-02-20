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

namespace PokemonParticipation
{
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private PokemonAPI PokemonInfo;
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1000";

            AllPokemonAPI pokemonStuff;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                pokemonStuff = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }

            foreach (var pokemon in pokemonStuff.results)
            {
                lstPokemon.Items.Add(pokemon);
            }
            
        }

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AllPokemonResult selectedPokemon = (AllPokemonResult)lstPokemon.SelectedItem; //cast it to the data type


            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedPokemon.url).Result;

                PokemonInfo = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            lblDescription.Content = $"{PokemonInfo.name}";
            imgPokemonImage.Source = new BitmapImage(new System.Uri(PokemonInfo.sprites.front_default));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            imgPokemonImage.Source = new BitmapImage(new System.Uri(PokemonInfo.sprites.back_default));
        }

        private void btnFront_Click(object sender, RoutedEventArgs e)
        {
            imgPokemonImage.Source = new BitmapImage(new System.Uri(PokemonInfo.sprites.front_default));
        }
    }
}
