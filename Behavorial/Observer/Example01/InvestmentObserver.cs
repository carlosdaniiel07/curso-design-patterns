namespace curso_design_patterns.Behavorial.Observer.Example01
{
    public class InvestmentObserver : IObserver<Investment>
    {
        public string Name { get; private set; }

        public InvestmentObserver(string name)
        {
            Name = name;
        }

        public void Notify(Investment item)
        {
            Console.WriteLine($"[{Name}] Novo valor do ativo {item.Name.ToUpper()} ({item.Code}): {item.Price}");
        }
    }
}
