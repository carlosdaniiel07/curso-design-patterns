namespace curso_design_patterns.Structural.Facade.Example01
{
    public class PayPalGateway : IPayPalGateway
    {
        public string AuthorizeTransaction(string apiKey, string orderId, decimal amount)
        {
            return Guid.NewGuid().ToString();
        }

        public bool CaptureTransaction(string apiKey, string transactionId, decimal amount)
        {
            var rnd = new Random();
            return rnd.Next(2) == 0;
        }
    }
}
