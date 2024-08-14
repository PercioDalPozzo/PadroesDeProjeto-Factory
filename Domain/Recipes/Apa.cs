using Domain.Interfaces;

namespace BeerMaker.Api.Entitys
{
    internal class Apa : IRecipe
    {
        public string Name => "Apa - American Pale Ale";
        public string Description => "Cerveja muito aromática remetendo notas frutadas ...";

        public IEnumerable<string> Maltes()
        {
            return new List<string>()
            {
                "4,5kg malte pilsen",
                "300g malte vienna"
            };
        }
        public string Moagem() => "Media";
        public IEnumerable<string> Mostura()
        {
            return new List<string>()
            {
                "60 minutos a 64 graus",
                "10 minutos a 76 graus",
            };
        }
        public string TempoFervura() => "60 minutos";
        public IEnumerable<string> Lupulagem()
        {
            return new List<string>()
            {
                "20g Mosaic 15 minutos",
                "20g Mosaic 10 minutos",
                "50g Mosaic 5 minutos",
                "50g Mosaic 0 minutos",
            };
        }
        public IEnumerable<string> Fermentacao()
        {
            return new List<string>()
            {
                "5 dias a 17 graus",
                "3 dias a 22 graus",
            };
        }
    }
}