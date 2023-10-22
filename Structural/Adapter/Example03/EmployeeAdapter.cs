namespace curso_design_patterns.Structural.Adapter.Example03
{
    public class EmployeeAdapter : ITarget
    {
        private readonly HrSystem _hrSystem;

        public EmployeeAdapter(HrSystem hrSystem)
        {
            _hrSystem = hrSystem;
        }

        public IEnumerable<string> GetEmployees()
        {
            var result = new List<string>();
            var employees = _hrSystem.SearchAllEmployees();

            foreach (string[] employee in employees)
                result.Add(string.Join(",", employee[0], employee[1], employee[2]));

            return result;
        }
    }
}
