namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
