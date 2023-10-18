namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() =>
            new Wolf();

        public override Herbivore CreateHerbivore() =>
            new Bison();
    }
}
