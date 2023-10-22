using System.Text;

namespace curso_design_patterns.Structural.Facade.Example01
{
    public class CreditCardPaymentFacade : ICreditCardPaymentFacade
    {
        private readonly IPayPalGateway _payPalGateway;

        public CreditCardPaymentFacade(IPayPalGateway payPalGateway)
        {
            _payPalGateway = payPalGateway;
        }

        public Payment Handle(Order order)
        {
            var apiKey = Convert.ToBase64String(Encoding.UTF8.GetBytes("<PayPal API Key>"));
            var amount = order.TotalValue;
            var transactionId = _payPalGateway.AuthorizeTransaction(apiKey, order.Id.ToString(), amount);
            var capturedTransaction = _payPalGateway.CaptureTransaction(apiKey, transactionId, amount);

            if (!capturedTransaction)
                return new Payment(amount, "Transação não autorizada!");

            return new Payment(amount);
        }
    }
}
