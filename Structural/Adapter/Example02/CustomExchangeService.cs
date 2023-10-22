namespace curso_design_patterns.Structural.Adapter.Example02
{
    public class CustomExchangeService : ICustomExchangeService
    {
        public decimal ConvertFromBrlToUsd(decimal amount) =>
            Math.Round(ThirdPartyExchangeUtils.Convert(Math.Round(amount, 2)), 2);
    }
}
