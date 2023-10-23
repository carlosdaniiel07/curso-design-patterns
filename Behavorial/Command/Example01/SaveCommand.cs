namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class SaveCommand : ICommand
    {
        private readonly Document _document;

        public SaveCommand(Document document)
        {
            _document = document;
        }

        public void Execute() =>
            _document.Save();
    }
}
