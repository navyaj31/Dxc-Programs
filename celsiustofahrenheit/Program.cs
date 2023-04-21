// See https://aka.ms/new-console-template for more information
String ch;
do
{


    Console.WriteLine("Enter the Temperature in  Degree Celsius = ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = ((celsius * 9) / 5) + 32;
    Console.WriteLine("Temperature(Celsius) = " + celsius + " Temperature(Fahrenheit) =" + fahrenheit);
    Console.WriteLine("Do you Wish to Continue(y/n)?");
    ch = Console.ReadLine();


} while (ch == "y");


