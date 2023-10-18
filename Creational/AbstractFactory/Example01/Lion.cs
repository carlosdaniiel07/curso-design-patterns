namespace curso_design_patterns.Creational.AbstractFactory.Example01
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore) =>
            Console.WriteLine($"Lion is eating a {herbivore.GetType().Name} animal!");
    }
}
