using Domain.Ingredients;

namespace Domain.Interfaces
{
    internal interface IGrainFactory
    {
        Malt BuildMalt(string location);
    }
}
