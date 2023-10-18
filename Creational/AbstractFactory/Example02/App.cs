namespace curso_design_patterns.Creational.AbstractFactory.Example02
{
    public class App
    {
        public void Run()
        {
            var androidDevice = new DeviceUi(new AndroidPlatformFactory());
            var components = androidDevice.InitializeUi();
        }
    }
}
