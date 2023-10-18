namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public class ClassicFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() =>
            new ClassicChair();

        public override Sofa CreateSofa() =>
            new ClassicSofa();
    }
}
