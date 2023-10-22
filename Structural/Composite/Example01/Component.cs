namespace curso_design_patterns.Structural.Composite.Example01
{
    public abstract class Component : IComponent
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        protected Component()
        {
            Id = Guid.NewGuid();
            Name = GetType().Name;
        }

        public virtual void Render(int depth) =>
            Console.WriteLine($"{new string('.', depth * 2)}<{Name} />");
    }
}
