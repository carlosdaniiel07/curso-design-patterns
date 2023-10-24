namespace curso_design_patterns.Behavorial.Strategy.Example02
{
    public class QuickSort : ISortStrategy
    {
        public void Sort<T>(List<T> items)
        {
            items.Sort();
            Console.WriteLine(nameof(QuickSort));
        }
    }
}
