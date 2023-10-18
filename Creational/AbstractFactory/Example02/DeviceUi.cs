namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class DeviceUi
    {
        private readonly Button _button;
        private readonly View _view;
        private readonly Text _text;

        public DeviceUi(PlatformFactory platformFactory)
        {
            _button = platformFactory.CreateButton();
            _view = platformFactory.CreateView();
            _text = platformFactory.CreateText();
        }

        public IEnumerable<IComponent> InitializeUi()
        {
            var components = new IComponent[]
            {
                _button,
                _view,
                _text,
            };

            foreach (var component in components)
                Console.WriteLine(component.Render());

            return components;
        }
    }
}
