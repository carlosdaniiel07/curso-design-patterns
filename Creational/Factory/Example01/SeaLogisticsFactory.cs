namespace curso_design_patterns.Creational.Factory.Example01
{
    public class SeaLogisticsFactory : LogisticsFactory
    {
        public override Transport CreateTransport() =>
            new Ship();
    }
}
