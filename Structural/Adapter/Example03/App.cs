namespace curso_design_patterns.Structural.Adapter.Example03
{
    public class App
    {
        public void Run()
        {
            ITarget target = new EmployeeAdapter(new HrSystem());

            foreach (var item in target.GetEmployees())
                Console.WriteLine(item);
        }
    }
}
