namespace curso_design_patterns.Behavorial.Observer.Example01
{
    public interface IObserver<T>
    {
        public string Name { get; }
        void Notify(T item);
    }
}
