using BeerMaker.Api.Services;

namespace Domain.Services
{
    public class RecipeOldStyleService : IRecipeService
    {
        public RecipeResponse Make(string style, string type)
        {
            var response = new RecipeResponse("German pilsner", "Cerveja leve de cor claro dourado, amargor médio ...");

            response.AddStep("--- Maltes ---");
            response.AddStep("4,7kg malte pilsner");
            response.AddStep("300g malte munich");

            response.AddStep("--- Moagem ---");
            response.AddStep("Media");

            response.AddStep("--- Mostura ---");
            response.AddStep("60 minutos a 64 graus");
            response.AddStep("10 minutos a 76 graus");

            response.AddStep("--- Tempo de fervura ---");
            response.AddStep("60 minutos");

            response.AddStep("--- Lupulagem ---");
            response.AddStep("5g Magnun 60 minutos");
            response.AddStep("20g Mittelfruh");

            response.AddStep("--- Fermentação ---");
            response.AddStep("7 dias a 10 graus");
            response.AddStep("5 dias a 16 graus");

            return response;
        }
    }
}
