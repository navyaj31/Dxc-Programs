using System.ComponentModel.Design;
using System.Xml.Schema;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student ID:");
            int studentID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            String ch = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Mark 1");
            int mark1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Mark 2");
            int mark2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Mark 3");
            int mark3 = Convert.ToInt16(Console.ReadLine());

            int Total = mark1 + mark2 + mark3;
            Console.WriteLine("Your Total Score is" + Total);
            double Percentage = Total / 3;
            Console.WriteLine("Your Total Average is" + Percentage);
            if (Percentage > 50)
            {
                Console.WriteLine("Your Result for the exam is Pass");
                if (Percentage >= 90 && Percentage <= 100)
                    Console.WriteLine("Your Grade is"+"A");
                else if (Percentage >= 80 && Percentage <= 89)
                    Console.WriteLine("Your Grade is"+"B");
                else if (Percentage >= 70 && Percentage <= 89)
                    Console.WriteLine("Your Grade is "+"C");
                else if (Percentage >= 60 && Percentage <= 79)
                    Console.WriteLine("YourGrade is "+"D");
                else if (Percentage >= 50 && Percentage <= 59)
                    Console.WriteLine("Your Grade is"+ "E");
                
            }



            else
            {
                Console.WriteLine("Your Grade is F");
                Console.WriteLine("Your Result for the exam is Fail");
            }

            
        }
    }
}