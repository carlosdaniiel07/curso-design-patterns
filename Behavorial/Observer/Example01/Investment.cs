namespace curso_design_patterns.Behavorial.Observer.Example01
{
    public abstract class Investment
    {
        public string Name { get; set; }
        public string Code { get; set; }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value == price)
                    return;

                price = value;
                Notify();
            }
        }

        private readonly ICollection<IObserver<Investment>> _observers = new List<IObserver<Investment>>();

        protected Investment(string name, string code, decimal price)
        {
            Name = name;
            Code = code.ToUpper();
            Price = price;
        }

        public void Subscribe(IObserver<Investment> observer) =>
            _observers.Add(observer);

        public void Unsubscribe(IObserver<Investment> observer) =>
            _observers.Remove(observer);

        private void Notify()
        {
            foreach (var observer in _observers)
                observer.Notify(this);
        }
    }
}
