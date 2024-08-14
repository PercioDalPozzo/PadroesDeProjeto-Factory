namespace Domain.Interfaces
{
    public interface IRecipe
    {
        string Name { get; }
        string Description { get; }

        IEnumerable<string> Maltes();
        string Moagem();
        IEnumerable<string> Mostura();
        string TempoFervura();
        IEnumerable<string> Lupulagem();
        IEnumerable<string> Fermentacao();
    }
}
