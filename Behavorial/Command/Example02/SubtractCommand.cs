namespace curso_design_patterns.Behavorial.Command.Example02
{
    public class SubtractCommand : ICommand
    {
        private readonly double _valueToSubtract;

        public SubtractCommand(double valueToSubtract)
        {
            _valueToSubtract = valueToSubtract;
        }

        public double Execute(double value) =>
            value - _valueToSubtract;

        public double Undo(double value) =>
            value + _valueToSubtract;
    }
}
