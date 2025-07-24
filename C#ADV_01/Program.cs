namespace C_ADV_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Range<int> range = new Range<int>(1, 5);
            Console.WriteLine(range.IsInRange(1));
            Console.WriteLine(range.IsInRange(0));
            Console.WriteLine(range.IsInRange(5));
            Console.WriteLine(range.Length());

            Range<double> rng = new Range<double>(1.2, 5.7);
            Console.WriteLine(rng.Length());

        }
    }
}
