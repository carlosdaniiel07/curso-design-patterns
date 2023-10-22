namespace curso_design_patterns.Structural.Facade.Example01
{
    public class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public decimal TotalValue => Products?.Sum(item => item.Quantity * item.Value) ?? 0;
    }
}
