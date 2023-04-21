namespace Simple_interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principle amount:");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter the Rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter Time period");
            double time = Convert.ToDouble(Console.ReadLine());
            double SimpleInterest = (principle * rate * time) / 100;
            Console.WriteLine(SimpleInterest);
        }
    }
}