namespace curso_design_patterns.Behavorial.Strategy.Example02
{
    public class MergeSort : ISortStrategy
    {
        public void Sort<T>(List<T> items)
        {
            Console.WriteLine(nameof(MergeSort));
        }
    }
}
