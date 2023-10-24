namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class BoletoPaymentService : IPayment
    {
        private readonly IBoletoPaymentFacade _boletoPaymentFacade;

        public BoletoPaymentService(IBoletoPaymentFacade boletoPaymentFacade)
        {
            _boletoPaymentFacade = boletoPaymentFacade;
        }

        public void Pay(Bill bill)
        {
            Console.WriteLine("Iniciando pagamento via Boleto");
            _boletoPaymentFacade.Pay(bill);
        }
    }
}
