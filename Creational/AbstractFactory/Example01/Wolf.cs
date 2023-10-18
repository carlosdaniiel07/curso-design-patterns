namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore) =>
            Console.WriteLine($"Wolf is eating a {herbivore.GetType().Name} animal!");
    }
}
