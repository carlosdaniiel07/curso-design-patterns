namespace curso_design_patterns.Structural.Adapter.Example02
{
    public class ExchangeService : IExchangeService
    {
        public decimal ConvertFromBrlToUsd(decimal amount) =>
            ThirdPartyExchangeUtils.Convert(amount);
    }
}
