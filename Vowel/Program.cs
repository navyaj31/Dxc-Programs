namespace Vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the alphabet");
            String ch = Console.ReadLine();
            if (ch == "a" || ch == "e" || ch == "i" || ch == "o" || ch == "u")
            {
                Console.WriteLine("Character is vowel");
            }
            else
            {
                Console.WriteLine("Character is Consonant");
            }
        }
    }
}