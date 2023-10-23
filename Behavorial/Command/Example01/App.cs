namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class App
    {
        public void Run()
        {
            var document = new Document();
            var openCommand = new OpenCommand(document);
            var saveCommand = new SaveCommand(document);
            var closeCommand = new CloseCommand(document);
            var menu = new MenuOptions(openCommand, saveCommand, closeCommand);

            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();
        }
    }
}
