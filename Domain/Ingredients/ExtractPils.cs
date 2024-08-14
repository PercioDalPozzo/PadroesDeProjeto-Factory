namespace Domain.Ingredients
{
    internal class ExtractPils : Malt
    {
        public override string Description => "extrato de malte pilsen";

        public override decimal EfficiencyFactor => 1.1m;
    }
}
