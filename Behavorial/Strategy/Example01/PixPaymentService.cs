namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public class PixPaymentService : IPayment
    {
        private readonly IPixPaymentFacade _pixPaymentFacade;

        public PixPaymentService(IPixPaymentFacade pixPaymentFacade)
        {
            _pixPaymentFacade = pixPaymentFacade;
        }

        public void Pay(Bill bill)
        {
            Console.WriteLine("Iniciando pagamento via PIX");
            _pixPaymentFacade.Pay(bill);
        }
    }
}
