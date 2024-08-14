using Domain.Interfaces;

namespace BeerMaker.Api.Entitys
{
    internal class DummyRecipe : IRecipe
    {
        public string Name => "";
        public string Description => "";

        public IEnumerable<string> Maltes() => new List<string>();
        public string Moagem() => "";
        public IEnumerable<string> Mostura() => new List<string>();
        public string TempoFervura() => "";
        public IEnumerable<string> Lupulagem() => new List<string>();
        public IEnumerable<string> Fermentacao() => new List<string>();
    }
}