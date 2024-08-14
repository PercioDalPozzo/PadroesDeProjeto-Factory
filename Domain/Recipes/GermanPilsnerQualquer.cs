using Domain.Interfaces;

namespace BeerMaker.Api.Entitys
{
    internal class GermanPilsnerQualquer : IRecipe
    {
        public string Name => "German pilsner";
        public string Description => "Cerveja leve de cor claro dourado, amargor médio ...";

        public IEnumerable<string> Maltes()
        {
            return new List<string>()
            {
                "4,7kg malte pilsner",
                "300g malte munich",
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
                "5g Magnun 60 minutos",
                "20g Mittelfruh",
            };
        }
        public IEnumerable<string> Fermentacao()
        {
            return new List<string>()
            {
                "7 dias a 10 graus",
                "5 dias a 16 graus",
            };
        }
    }
}