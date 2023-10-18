namespace curso_design_patterns.Creational.Factory.Example02
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {

        }

        public override void Connect()
        {
            Console.WriteLine("Conectando-se ao banco de dados SQL Server...");
            Connection.Open();
        }
    }
}
