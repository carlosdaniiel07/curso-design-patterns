namespace curso_design_patterns.Structural.Adapter.Example01
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
