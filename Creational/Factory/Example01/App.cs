namespace curso_design_patterns.Creational.Factory.Example01
{
    public class App
    {
        public void Run()
        {
            var logisticsFactory = LogisticsFactory.Create(TransportType.Air);
            var transport = logisticsFactory.CreateTransport();
            var distance = 24.22;

            Console.WriteLine($"Price: {transport.CalculatePrice(distance)}");
        }
    }
}
