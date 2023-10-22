namespace curso_design_patterns.Structural.Adapter.Example02
{
    public class App
    {
        public void Run()
        {
            var value = 1241.42m;

            IExchangeService exchangeService = new ExchangeService();
            Console.WriteLine(exchangeService.ConvertFromBrlToUsd(value));

            IExchangeService exchangeService2 = new ExchangeServiceAdapter(new CustomExchangeService());
            Console.WriteLine(exchangeService2.ConvertFromBrlToUsd(value));
        }
    }
}
