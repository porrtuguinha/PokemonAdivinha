using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokemonAdivinha.models
{
    public class ConectaApi
    {

        
        Pokemon pokemonCarregado = new Pokemon();
        public  Pokemon chamaPokemon(string id)
        {
            try
            {
                string link = $"https://pokeapi.co/api/v2/pokemon/{id}";
                var rest = new RestClient(link);
                var resposta = new RestRequest(link, Method.Get);
                var request = rest.ExecuteGetAsync(resposta);
              pokemonCarregado = JsonSerializer.Deserialize<Pokemon>(request.Result.Content);
            }
            catch (Exception ex)
            {
                pokemonCarregado = null;
            }
            return pokemonCarregado;
        }

        public Pokemon recarregar()
        {
            Random random = new Random();
            ConectaApi conecta = new ConectaApi();
            int numero = random.Next(898);
            Pokemon poke = conecta.chamaPokemon(numero.ToString());
            return poke;
        }
    }
}
