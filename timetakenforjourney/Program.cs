// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Distance:");
int distance= Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Speed:");
int speed = Convert.ToInt16(Console.ReadLine());
int Time= distance/speed;
Console.WriteLine("Time taken in Journey:"+Time);
