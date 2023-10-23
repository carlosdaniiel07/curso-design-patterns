namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class CloseCommand : ICommand
    {
        private readonly Document _document;

        public CloseCommand(Document document)
        {
            _document = document;
        }

        public void Execute() =>
            _document.Close();
    }
}
