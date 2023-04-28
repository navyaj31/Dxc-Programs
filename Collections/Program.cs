using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(178);
            list.Add(35);
            list.Add("Hello");
            list.Add(2.5f);
            list.Add(true);
            Console.WriteLine(list[2]);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            list.Insert(2, "World");

            Console.WriteLine("After Insert");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Count);
        }
    }
}
        