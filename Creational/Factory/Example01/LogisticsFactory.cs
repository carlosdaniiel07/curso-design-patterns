namespace curso_design_patterns.Creational.Factory.Example01
{
    public abstract class LogisticsFactory
    {
        public abstract Transport CreateTransport();

        public static LogisticsFactory Create(TransportType transportType)
        {
            return transportType switch
            {
                TransportType.Road => new RoadLogisticsFactory(),
                TransportType.Sea => new SeaLogisticsFactory(),
                TransportType.Air => new AirLogisticsFactory(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
