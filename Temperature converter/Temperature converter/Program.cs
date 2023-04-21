namespace Temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of celsius");
            double Celsius= Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((Celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is:" + fahrenheit);

        }
    }
}