using Domain.Ingredients;
using Domain.Interfaces;

namespace Domain.Factories
{
    internal class GrainFactory : IGrainFactory
    {
        public Malt BuildMalt(string location)
        {
            switch (location)
            {
                case "GERMAN": return new ClassicPils();
                case "US": return new ExtractPils();
                default:
                    return new CommonPils();
            }
        }
    }
}
