namespace curso_design_patterns.Creational.AbstractFactory.Example03
{
    public class App
    {
        public void Run()
        {
            var house = new House(new ClassicFurnitureFactory());
            house.Build();
        }
    }
}
