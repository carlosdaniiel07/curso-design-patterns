namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class BillingService
    {
        private readonly IPayment _payment;

        public BillingService(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay(Bill bill)
        {
            Console.WriteLine($"Iniciando pagamento da conta {bill}");

            _payment.Pay(bill);

            Console.WriteLine($"Conta {bill} paga com sucesso!");
        }
    }
}
