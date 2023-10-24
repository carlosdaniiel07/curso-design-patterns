namespace curso_design_patterns.Behavorial.Observer.Example01
{
    public class App
    {
        public void Run()
        {
            var microsoft = new NasdaqCompany("Microsoft", "MSFT", RandomPrice());
            var person01 = new InvestmentObserver("Fulano");
            var person02 = new InvestmentObserver("Ciclano");

            microsoft.Subscribe(person01);
            microsoft.Subscribe(person02);

            for (int i = 1; i <= 5; i++)
            {
                microsoft.Price = RandomPrice();
                Thread.Sleep(2_000);

                if (i == 2)
                    microsoft.Unsubscribe(person01);
            }
        }

        private decimal RandomPrice()
        {
            var rnd = new Random();
            return rnd.Next(100, 400);
        }
    }
}
