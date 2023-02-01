using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    public class Collection
    {
        public static void List()
        {
            Console.WriteLine("\n ListDemo....");
            List<string> list = new List<string>();
            list.Add("Pranay");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine(list[2]);

        }
        public static void Set()
        {
            Console.WriteLine("\n Set Demo....");
            var set = new HashSet<string>();
            set.Add("Shubham");
            set.Add("arya");
            set.Add("vicky");
            set.Add("lucky");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        public static void Stack()
        {

            Console.WriteLine("\n Stack Demo....");
            Stack<string> stack = new Stack<string>();
            stack.Push("Sarang");
            stack.Push("Sita");
            stack.Push("Laxman");
            stack.Push("Devki");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }

        public static void Queue()
        {
            Console.WriteLine("\n Queue Demo.....");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sham");
            queue.Enqueue("vish");
            queue.Enqueue("sayu");
            queue.Enqueue("Sima");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeu one element:");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void Dictionary()
        {
            Console.WriteLine("\n Dictionary Demo....");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "ram");
            dictionary.Add(200, "rahul");
            dictionary.Add(300, "Mani");
            dictionary.Add(400, "Vrutik");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary: ");
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }
        }
    }
}
