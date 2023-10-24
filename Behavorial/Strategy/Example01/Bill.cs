namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class Bill
    {
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public Bill(string description, decimal value, PaymentMethod paymentMethod)
        {
            Description = description;
            Value = value;
            PaymentMethod = paymentMethod;
        }

        public override string ToString() =>
            $"Description = {Description}, Value = {Value}, PaymentMethod = {PaymentMethod}";
    }
}
