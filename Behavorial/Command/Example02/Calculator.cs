namespace curso_design_patterns.Behavorial.Command.Example02
{
    public class Calculator
    {
        public double CurrentValue { get; private set; }
        private readonly Stack<ICommand> _commands = new();

        public Calculator(double initialValue = 0)
        {
            CurrentValue = initialValue;
        }

        public void ExecuteCommand(ICommand command)
        {
            CurrentValue = command.Execute(CurrentValue);
            _commands.Push(command);
        }

        public void Undo()
        {
            var lastCommand = _commands.Pop();
            CurrentValue = lastCommand.Undo(CurrentValue);
        }
    }
}
