using BeerMaker.Api.Entitys;
using Domain.Interfaces;

namespace BeerMaker.Api.Factories
{
    internal class RecipeFactory
    {
        public IRecipe BuildRecipe(string style, string type)
        {
            switch (style)
            {
                case "GERMAN_PILSEN": return new GermanPilsner(type);
                case "APA": return new Apa();
                default:
                    return new DummyRecipe();
            }
        }
    }
}