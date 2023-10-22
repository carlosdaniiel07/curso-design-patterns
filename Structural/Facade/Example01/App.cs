namespace curso_design_patterns.Structural.Facade.Example01
{
    public class App
    {
        public void Run()
        {
            var rnd = new Random();
            var creditCardPaymentFacade = new CreditCardPaymentFacade(new PayPalGateway());
            var paymentService = new PaymentService(creditCardPaymentFacade);

            paymentService.CreditCardPayment(new Order
            {
                Id = Guid.NewGuid(),
                Products = new Product[]
                {
                    new Product
                    {
                        Name = "Camisa",
                        Quantity = rnd.Next(1, 6),
                        Value = rnd.Next(5000),
                    },
                    new Product
                    {
                        Name = "Terno",
                        Quantity = rnd.Next(1, 6),
                        Value = rnd.Next(5000),
                    },
                    new Product
                    {
                        Name = "Tênis",
                        Quantity = rnd.Next(1, 6),
                        Value = rnd.Next(5000),
                    },
                },
            });
        }
    }
}
