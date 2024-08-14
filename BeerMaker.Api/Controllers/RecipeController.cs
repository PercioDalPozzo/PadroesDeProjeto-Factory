using BeerMaker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeerMaker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService = null)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public IActionResult Get(string recipe, string location)
        {
            return Ok(_recipeService.Make(recipe, location));
        }
    }
}