namespace curso_design_patterns.Structural.Adapter.Example01
{
    public class AuthService
    {
        private readonly ILogger _logger;

        public AuthService(ILogger logger)
        {
            _logger = logger;
        }

        public void Auth(string username, string password)
        {
            _logger.LogInfo($"Authenticating user {username}");

            // ...

            _logger.LogInfo($"Authenticated user {username}");
        }
    }
}
