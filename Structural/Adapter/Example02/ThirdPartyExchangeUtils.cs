namespace curso_design_patterns.Structural.Adapter.Example02
{
    public static class ThirdPartyExchangeUtils
    {
        public static decimal Convert(decimal amount)
        {
            var tax = 5.03m;
            return amount / tax;
        }
    }
}
