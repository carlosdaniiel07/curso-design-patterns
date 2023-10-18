namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public class ClassicChair : Chair
    {
        public override bool HasLegs() =>
            false;
    }
}
