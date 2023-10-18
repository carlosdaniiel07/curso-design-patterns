namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public abstract class FurnitureFactory
    {
        public abstract Sofa CreateSofa();
        public abstract Chair CreateChair();
    }
}
