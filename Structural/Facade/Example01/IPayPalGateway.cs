namespace curso_design_patterns.Structural.Facade.Example01
{
    public interface IPayPalGateway
    {
        string AuthorizeTransaction(string apiKey, string orderId, decimal amount);
        bool CaptureTransaction(string apiKey, string transactionId, decimal amount);
    }
}
