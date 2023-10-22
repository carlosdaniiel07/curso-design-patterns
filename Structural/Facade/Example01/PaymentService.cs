namespace curso_design_patterns.Structural.Facade.Example01
{
    public class PaymentService : IPaymentService
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public PaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment CreditCardPayment(Order order)
        {
            Console.WriteLine($"Iniciando pagamento via Cartão de Crédito - Valor R$ {order.TotalValue}");

            var payment = _creditCardPaymentFacade.Handle(order);

            Console.WriteLine(payment.Success ? "Pagamento processado com sucesso!" : $"Erro ao processar pagamento: {payment.ErrorMessage}");

            return payment;
        }
    }
}
