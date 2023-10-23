namespace curso_design_patterns.Behavorial.Command.Example01
{
    public class Document
    {
        public void Open() =>
            Console.WriteLine("Document opened");

        public void Save() =>
            Console.WriteLine("Document saved");

        public void Close() =>
            Console.WriteLine("Document closed");
    }
}
