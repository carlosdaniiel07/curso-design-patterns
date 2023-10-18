namespace curso_design_patterns.Creational.Factory.Example02
{
    public class MySqlConnectorFactory : DbConnectorFactory
    {
        public override DbConnector CreateDbConnector(string connectionString) =>
            new MySqlConnector(connectionString);
    }
}
