namespace curso_design_patterns.Creational.Singleton.Example01
{
    public class ConnectionPool
    {
        private static ConnectionPool? instance;

        private readonly List<Connection> _connections;
        private readonly int _maxSize;

        public IReadOnlyList<Connection> Connections => _connections;

        private ConnectionPool(int maxSize)
        {
            _connections = new List<Connection>();
            _maxSize = maxSize;
        }

        public static ConnectionPool CreateInstance(int maxSize)
        {
            instance ??= new ConnectionPool(maxSize);
            return instance;
        }

        public Connection GetConnection()
        {
            var isFull = _connections.Count == _maxSize;

            if (isFull)
                throw new InvalidOperationException("Connection pool reached its limit!");

            var connection = new Connection();
            _connections.Add(connection);

            return connection;
        }
    }
}
