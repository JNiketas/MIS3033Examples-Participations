using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon_P_
{
    class PokemonAPI
    {
     public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<AllPokemonResults> results { get; set; }
    }

    public class AllPokemonResults
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }

    }

}
