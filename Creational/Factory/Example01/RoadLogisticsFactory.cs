namespace curso_design_patterns.Creational.Factory.Example01
{
    public class RoadLogisticsFactory : LogisticsFactory
    {
        public override Transport CreateTransport() =>
            new Truck();
    }
}
