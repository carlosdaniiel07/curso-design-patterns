namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class App
    {
        public void Run()
        {
            var bill = new Bill("Conta de Luz", 50, PaymentMethod.Pix);
            var payment = PaymentFactory.CreatePayment(bill.PaymentMethod);
            var billingService = new BillingService(payment);

            billingService.Pay(bill);
        }
    }
}
