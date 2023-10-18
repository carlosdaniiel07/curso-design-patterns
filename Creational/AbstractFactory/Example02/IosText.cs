namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class IosText : Text
    {
        public override string Render()
        {
            return "<iOSText />";
        }
    }
}
