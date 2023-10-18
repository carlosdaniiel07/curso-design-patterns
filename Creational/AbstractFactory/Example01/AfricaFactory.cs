namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() =>
            new Lion();

        public override Herbivore CreateHerbivore() =>
            new Wildebeest();
    }
}
