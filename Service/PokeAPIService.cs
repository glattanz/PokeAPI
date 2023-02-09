using Newtonsoft.Json;
using PokeAPI.Models;

public class PokeAPIService
{
    private readonly HttpClient _client;

    public PokeAPIService(){

        _client = new HttpClient();
    }

    public async Task<Pokemon> GetPokemonByName(string pokemonName)
    {
        var uri = "https://pokeapi.co/api/v2/pokemon/" + pokemonName;

        var response = await _client.GetAsync(uri);
        var pokemonJSON = await response.Content.ReadAsStringAsync();
        var pokemon = JsonConvert.DeserializeObject<Pokemon>(pokemonJSON);

        return pokemon;
    }
}