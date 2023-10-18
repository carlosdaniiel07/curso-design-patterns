namespace curso_design_patterns.Creational.Factory.Example02
{
    public class Connection : IDisposable
    {
        public bool Opened { get; private set; }
        public string ConnectionString { get; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta!");
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão fechada!");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // ...
            Close();
        }
    }
}
