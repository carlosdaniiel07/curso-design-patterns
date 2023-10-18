namespace curso_design_patterns.Creational.Singleton.Example01
{
    public class Connection
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
    }
}
