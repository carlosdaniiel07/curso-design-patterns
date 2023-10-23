namespace curso_design_patterns.Behavorial.Command.Example02
{
    public class App
    {
        public void Run()
        {
            var calculator = new Calculator(initialValue: 0);

            calculator.ExecuteCommand(new AddCommand(20));
            calculator.ExecuteCommand(new SubtractCommand(10));
            calculator.ExecuteCommand(new MultiplyCommand(5));
            calculator.ExecuteCommand(new DivideCommand(2));

            Console.WriteLine($"Valor atual: {calculator.CurrentValue}");

            calculator.Undo();

            Console.WriteLine($"Valor atual: {calculator.CurrentValue}");
        }
    }
}
