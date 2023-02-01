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

        }

        public static void Stack()
        {

            Console.WriteLine("\n Stack Demo....");
            Stack<string> stack = new Stack<string>();
            stack.Push("Sarang");
            stack.Push("Sita");
            stack.Push("Laxman");
            stack.Push("Devki");

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
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
        }

        public static void Dictionary()
        {
            Console.WriteLine("\n Dictionary Demo....");

            Dictionary<int, string> dictionory = new Dictionary<int, string>();
            dictionory.Add(100, "ram");
            dictionory.Add(200, "rahul");
            dictionory.Add(300, "Mani");
            dictionory.Add(400, "Vrutik");

            foreach (var element in dictionory)
            {
                Console.WriteLine(element);
            }
        }
    }
}
