namespace curso_design_patterns.Creational.Factory.Example02
{
    public abstract class DbConnector
    {
        public Connection Connection { get; private set; }

        protected DbConnector(string connectionString)
        {
            Connection = new Connection(connectionString);
        }

        public abstract void Connect();
    }
}
