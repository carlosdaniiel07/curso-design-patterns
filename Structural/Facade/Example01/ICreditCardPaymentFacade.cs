namespace curso_design_patterns.Structural.Facade.Example01
{
    public interface ICreditCardPaymentFacade
    {
        Payment Handle(Order order);
    }
}
