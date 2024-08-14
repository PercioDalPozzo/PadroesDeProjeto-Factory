namespace BeerMaker.Api.Services
{
    public class RecipeResponse
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public RecipeResponse(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public List<string> Steps { get; private set; } = new List<string>();

        public void AddStep(string step)
        {
            Steps.Add(step);
        }
        public void AddStep(IEnumerable<string> step)
        {
            Steps.AddRange(step);
        }
    }
}