namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public class App
    {
        public void Run()
        {
            var africaAnimalWorld = new AnimalWorld(new AfricaFactory());
            africaAnimalWorld.RunFoodChain();

            var americaAnimalWorld = new AnimalWorld(new AmericaFactory());
            americaAnimalWorld.RunFoodChain();
        }
    }
}
