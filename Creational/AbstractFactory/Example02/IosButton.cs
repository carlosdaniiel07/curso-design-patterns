namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class IosButton : Button
    {
        public override string Render()
        {
            return "<iOSButton />";
        }
    }
}
