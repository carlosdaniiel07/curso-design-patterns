namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() =>
            new ModernChair();

        public override Sofa CreateSofa() =>
            new ModernSofa();
    }
}
