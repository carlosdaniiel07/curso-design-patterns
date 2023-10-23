namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class OpenCommand : ICommand
    {
        private readonly Document _document;

        public OpenCommand(Document document)
        {
            _document = document;
        }

        public void Execute() =>
            _document.Open();
    }
}
