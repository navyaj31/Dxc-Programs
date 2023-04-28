using System.Collections;
namespace Collectionsstack
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Stack s = new Stack();
                s.Push(10);
                s.Push(20);
                s.Push(30);
                s.Push(40);

                Console.WriteLine(s.Contains(30));

                foreach (var item in s)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("After Remove with Pop Method");
                Console.WriteLine($"{s.Pop()} is popped out");
                foreach (var item in s)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------------------------------------------------");
            }
            //Queue
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            Console.WriteLine("After removing");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------");

            //SortedList
            SortedList list = new SortedList();
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(3, "Three");
            list.Add(2, "Two");
            list.Add(5, "Five");

            Console.WriteLine(list[3]);
            Console.WriteLine(list.GetKey(4));
            Console.WriteLine(list.ContainsValue("Four"));
            Console.WriteLine(list.ContainsKey(5));
            Console.WriteLine(list.Clone());
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.IndexOfKey(3));

            foreach (var item in list.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list[item]}");
            }
            Console.WriteLine("------------------------------------------------------------");

            //Hashtable
            Hashtable ht = new Hashtable();
            ht.Add(4, "Four");
            ht.Add(1, "one");
            ht.Add(3, "Three");
            ht.Add(2, "Two");// represents values in decreasing way
            ht.Remove(4);
            Console.WriteLine(ht.Contains(6));
            Console.WriteLine(ht.ContainsValue("one"));
            Console.WriteLine(ht.Clone());
            Console.WriteLine(ht.Equals(ht));


            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
             



            
            


        }
    }
}
    
