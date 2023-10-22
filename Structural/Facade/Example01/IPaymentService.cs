namespace curso_design_patterns.Structural.Facade.Example01
{
    public interface IPaymentService
    {
        Payment CreditCardPayment(Order order);
    }
}
