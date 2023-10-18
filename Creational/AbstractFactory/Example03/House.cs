namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public class House
    {
        private readonly Sofa _sofa;
        private readonly Chair _chair;

        public House(FurnitureFactory furnitureFactory)
        {
            _sofa = furnitureFactory.CreateSofa();
            _chair = furnitureFactory.CreateChair();
        }

        public void Build()
        {
            Console.WriteLine($"Sofa: {_sofa.GetType().Name}");
            Console.WriteLine($"Chair: {_chair.GetType().Name}");
        }
    }
}
