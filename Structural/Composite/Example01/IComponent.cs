namespace curso_design_patterns.Structural.Composite.Example01
{
    public interface IComponent
    {
        public Guid Id { get; }
        public string Name { get; }

        void Render(int depth);
    }
}
