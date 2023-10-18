namespace curso_design_patterns.Creational.Factory.Example02
{
    public class App
    {
        public void Run()
        {
            var dbConnectorFactory = DbConnectorFactory.Create(DatabaseType.MySQL);
            var dbConnector = dbConnectorFactory.CreateDbConnector("<connection string>");

            dbConnector.Connect();
        }
    }
}
