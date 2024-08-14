namespace BeerMaker.Api.Services
{
    public interface IRecipeService
    {
        RecipeResponse Make(string recipe);
    }
}
