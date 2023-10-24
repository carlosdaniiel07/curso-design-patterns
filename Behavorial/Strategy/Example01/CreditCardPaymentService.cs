namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public void Pay(Bill bill)
        {
            Console.WriteLine("Iniciando pagamento via Cartão de Crédito");
            _creditCardPaymentFacade.Pay(bill);
        }
    }
}
