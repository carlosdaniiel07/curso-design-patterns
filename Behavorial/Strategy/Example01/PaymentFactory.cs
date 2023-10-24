namespace curso_design_patterns.Behavorial.Strategy.Example01
{
    public static class PaymentFactory
    {
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.CreditCard => new CreditCardPaymentService(new CreditCardPaymentFacade()),
                PaymentMethod.Pix => new PixPaymentService(new PixPaymentFacade()),
                PaymentMethod.Boleto => new BoletoPaymentService(new BoletoPaymentFacade()),
                _ => throw new NotSupportedException()
            };
        }
    }
}
