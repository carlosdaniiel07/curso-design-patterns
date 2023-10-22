namespace curso_design_patterns.Structural.Composite.Example01
{
    public class Div : Component, IComponent
    {
        private readonly List<IComponent> _components = new();
        public IReadOnlyCollection<IComponent> Components => _components;

        public void AddComponent(IComponent component) =>
            _components.Add(component);

        public void RemoveComponent(IComponent component) =>
            _components.Remove(component);

        public override void Render(int depth)
        {
            base.Render(depth);
            _components.ForEach(component => component.Render(depth + 1));
        }
    }
}
