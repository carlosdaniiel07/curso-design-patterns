namespace curso_design_patterns.Creational.Factory.Example01
{
    public class Truck : Transport
    {
        public override decimal CalculatePrice(double distance) =>
            (decimal)distance * 23.23m;
    }
}
