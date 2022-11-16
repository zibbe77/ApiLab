using RestSharp;
using System.Text.Json;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new RestRequest("pokemon/charmander");
RestResponse response = pokeClient.GetAsync(request).Result;

Console.WriteLine(response.StatusCode);
Console.ReadLine();

if (response.IsSuccessful)
{
    Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);
    Console.WriteLine(p.weight);
    Console.WriteLine(p.name);
    Console.ReadLine();
}

