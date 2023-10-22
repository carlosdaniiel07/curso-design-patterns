namespace curso_design_patterns.Structural.Adapter.Example01
{
    public class CustomLogger : ICustomLogger
    {
        public void LogError(string message) =>
            Console.WriteLine($"[ERROR][{GetDate()}] - {message}");

        public void LogInfo(string message) =>
            Console.WriteLine($"[INFO][{GetDate()}] - {message}");

        public void LogWarning(string message) =>
            Console.WriteLine($"[ERROR][{GetDate()}] - {message}");

        private string GetDate() =>
            DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
