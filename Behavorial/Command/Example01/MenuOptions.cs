namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class MenuOptions
    {
        private readonly ICommand _openCommand;
        private readonly ICommand _saveCommand;
        private readonly ICommand _closeCommand;

        public MenuOptions(ICommand openCommand, ICommand saveCommand, ICommand closeCommand)
        {
            _openCommand = openCommand;
            _saveCommand = saveCommand;
            _closeCommand = closeCommand;
        }

        public void ClickOpen() =>
            _openCommand.Execute();

        public void ClickSave() =>
            _saveCommand.Execute();

        public void ClickClose() =>
            _closeCommand.Execute();
    }
}
