namespace Domain.Ingredients
{
    internal abstract class Malt
    {
        public abstract string Description { get; }
        public abstract decimal EfficiencyFactor { get; }

        internal decimal QuantityConverted(decimal quantityInKg)
        {
            return quantityInKg * EfficiencyFactor;
        }
    }
}
