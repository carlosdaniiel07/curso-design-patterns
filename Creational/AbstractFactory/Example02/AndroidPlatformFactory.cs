namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class AndroidPlatformFactory : PlatformFactory
    {
        public override Button CreateButton() =>
            new AndroidButton();

        public override Text CreateText() =>
            new AndroidText();

        public override View CreateView() =>
            new AndroidView();
    }
}
