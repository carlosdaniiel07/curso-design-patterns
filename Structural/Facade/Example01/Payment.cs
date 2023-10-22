namespace curso_design_patterns.Structural.Facade.Example01
{
    public class Payment
    {
        public decimal Value { get; private set; }
        public string ErrorMessage { get; private set; }
        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage);

        public Payment(decimal value, string errorMessage = null)
        {
            Value = value;
            ErrorMessage = errorMessage;
        }
    }
}
