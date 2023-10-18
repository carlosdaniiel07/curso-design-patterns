namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public abstract class PlatformFactory
    {
        public abstract Button CreateButton();
        public abstract View CreateView();
        public abstract Text CreateText();
    }
}
