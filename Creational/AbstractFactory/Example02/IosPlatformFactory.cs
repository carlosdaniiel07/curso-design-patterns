namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class IosPlatformFactory : PlatformFactory
    {
        public override Button CreateButton() =>
            new IosButton();

        public override Text CreateText() =>
            new IosText();

        public override View CreateView() =>
            new IosView();
    }
}
