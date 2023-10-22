namespace curso_design_patterns.Structural.Composite.Example01
{
    public class App
    {
        public void Run()
        {
            var screen = new Div();

            screen.AddComponent(new Button());
            screen.AddComponent(new Button());
            screen.AddComponent(new Button());
            screen.AddComponent(new Image());

            var div = new Div();
            
            div.AddComponent(new Button());
            div.AddComponent(new Image());

            screen.AddComponent(div);
            screen.Render(1);
        }
    }
}
