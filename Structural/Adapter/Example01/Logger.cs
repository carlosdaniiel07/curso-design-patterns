namespace curso_design_patterns.Structural.Adapter.Example01
{
    public class Logger : ILogger
    {
        public void LogError(string message) =>
            Console.WriteLine($"[ERROR] {message}");

        public void LogInfo(string message) =>
            Console.WriteLine($"[INFO] {message}");

        public void LogWarning(string message) =>
            Console.WriteLine($"[WARN] {message}");
    }
}
