namespace curso_design_patterns.Creational.Factory.Example02
{
    public class MySqlConnector : DbConnector
    {
        public MySqlConnector(string connectionString) : base(connectionString)
        {

        }

        public override void Connect()
        {
            Console.WriteLine("Conectando-se ao banco de dados MySQL...");
            Connection.Open();
        }
    }
}
