namespace curso_design_patterns.Structural.Adapter.Example01
{
    public class App
    {
        public void Run()
        {
            var authService = new AuthService(new Logger());
            authService.Auth("john.doe", "123");

            var authService2 = new AuthService(new LoggerAdapter(new CustomLogger()));
            authService2.Auth("john.doe", "123");
        }
    }
}
