namespace curso_design_patterns.Creational.Factory.Example02
{
    public class SqlServerConnectorFactory : DbConnectorFactory
    {
        public override DbConnector CreateDbConnector(string connectionString) =>
            new SqlServerConnector(connectionString);
    }
}
