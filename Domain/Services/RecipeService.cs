using BeerMaker.Api.Factories;
using BeerMaker.Api.Services;

namespace Domain.Services
{
    public class RecipeService : IRecipeService
    {
        public RecipeResponse Make(string style, string type)
        {
            var recipe = new RecipeFactory().BuildRecipe(style, type);

            var response = new RecipeResponse(recipe.Name, recipe.Description);

            response.AddStep("--- Maltes ---");
            response.AddStep(recipe.Maltes());

            response.AddStep("--- Moagem ---");
            response.AddStep(recipe.Moagem());

            response.AddStep("--- Mostura ---");
            response.AddStep(recipe.Mostura());

            response.AddStep("--- Tempo de fervura ---");
            response.AddStep(recipe.TempoFervura());

            response.AddStep("--- Lupulagem ---");
            response.AddStep(recipe.Lupulagem());

            response.AddStep("--- Fermentação ---");
            response.AddStep(recipe.Fermentacao());

            return response;
        }
    }
}
