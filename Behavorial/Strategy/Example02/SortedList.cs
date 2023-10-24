namespace curso_design_patterns.Behavorial.Strategy.Example02
{
    public class SortedList
    {
        private readonly List<string> _names;
        private readonly ISortStrategy _sortStrategy;

        public IReadOnlyCollection<string> Names => _names;

        public SortedList(ISortStrategy sortStrategy)
        {
            _names = new List<string>();
            _sortStrategy = sortStrategy;
        }

        public void AddName(string name) =>
            _names.Add(name);

        public void Sort() =>
            _sortStrategy.Sort(_names);
    }
}
