namespace curso_design_patterns.Behavorial.Command.Example02
{
    public interface ICommand
    {
        double Execute(double value);
        double Undo(double value);
    }
}
