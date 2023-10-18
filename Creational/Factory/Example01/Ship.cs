namespace curso_design_patterns.Creational.Factory.Example01
{
    public class Ship : Transport
    {
        public override decimal CalculatePrice(double distance) =>
            (decimal)distance * 54.35m;
    }
}
