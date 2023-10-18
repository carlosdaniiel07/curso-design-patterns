namespace curso_design_patterns.Creational.Factory.Example02
{
    public abstract class DbConnectorFactory
    {
        public abstract DbConnector CreateDbConnector(string connectionString);

        public static DbConnectorFactory Create(DatabaseType databaseType)
        {
            return databaseType switch
            {
                DatabaseType.SqlServer => new SqlServerConnectorFactory(),
                DatabaseType.MySQL => new MySqlConnectorFactory(),
                _ => throw new ArgumentException($"Type {databaseType} is invalid"),
            };
        }
    }
}
