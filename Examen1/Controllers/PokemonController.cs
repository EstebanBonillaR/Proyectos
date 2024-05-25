﻿using Examen1.Services;
using Microsoft.AspNetCore.Mvc;
using Examen1.Services;

namespace Examen1.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFavoritePokemon()
        {
            var pokemon = await _pokemonService.GetFavoritePokemonAsync();
            return Ok(pokemon);
        }
    }
}