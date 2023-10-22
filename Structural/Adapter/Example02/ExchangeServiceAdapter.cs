namespace curso_design_patterns.Structural.Adapter.Example02
{
    public class ExchangeServiceAdapter : IExchangeService
    {
        private readonly ICustomExchangeService _customExchangeService;

        public ExchangeServiceAdapter(ICustomExchangeService customExchangeService)
        {
            _customExchangeService = customExchangeService;
        }

        public decimal ConvertFromBrlToUsd(decimal amount) =>
            _customExchangeService.ConvertFromBrlToUsd(amount);
    }
}
