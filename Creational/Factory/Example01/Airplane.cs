namespace curso_design_patterns.Creational.Factory.Example01
{
    public class Airplane : Transport
    {
        public override decimal CalculatePrice(double distance) =>
            (decimal)distance * 84.92m;
    }
}
