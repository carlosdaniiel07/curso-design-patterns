namespace curso_design_patterns.Behavorial.Strategy.Example02
{
    public class App
    {
        public void Run()
        {
            var sortedList = new SortedList(new QuickSort());

            sortedList.AddName("John");
            sortedList.AddName("Doe");

            sortedList.Sort();
        }
    }
}
