namespace curso_design_patterns.Creational.Factory.Example01
{
    public class AirLogisticsFactory : LogisticsFactory
    {
        public override Transport CreateTransport() =>
            new Airplane();
    }
}
