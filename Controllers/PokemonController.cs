using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokeAPI.Models;

namespace PokeAPI.Controllers;

[ApiController]
[Route ("pokemon")]
public class PokemonController : Controller
{
    private readonly HttpClient _client;
    private readonly ILogger<PokemonController> _logger;
    private readonly PokeAPIService service;

    public PokemonController(ILogger<PokemonController> logger)
    {
        _logger = logger;
        service = new PokeAPIService();
    }

    public IActionResult Index()
    {
        return View();
    
    }
    
    [HttpGet ("name/{PokemonName}")]
    public async Task<IActionResult> GetPokemonByName(string PokemonName)
    {
        return View(await service.GetPokemonByName(PokemonName));
    }
}
