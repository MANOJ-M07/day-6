using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList List = new ArrayList();
            Hashtable ht = new Hashtable();
            SortedList sortedList = new SortedList();
            Stack stack = new Stack();
            Queue queue = new Queue();*/


            //stack example

            /* Stack stack = new Stack();
             stack.Push("Aman");
             stack.Push("Vijay");
             stack.Push("Zoya");
             stack.Push("Raj");
             stack.Push("Kiran");
             Console.WriteLine("Number of items in stack are \t " + stack.Count);
             foreach (var item in stack)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("After removing"+stack.Pop());
             Console.WriteLine("Number of items in stack are \t " + stack.Count);
             foreach (var item in stack)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("peek Example"+stack.Peek());
             Console.WriteLine("After peek");
             Console.WriteLine("Number of items in stack are \t " + stack.Count);
             foreach (var item in stack)
             {
                 Console.WriteLine(item);
             }
             stack.Clear();
             Console.WriteLine("after clear number of items \t"+stack.Count);
             Console.ReadKey();*/

            //Queue Example

            /* Queue queue = new Queue();
             queue.Enqueue("Aman");
             queue.Enqueue("Vijay");
             queue.Enqueue("Zoya");
             queue.Enqueue("Raj");
             queue.Enqueue("Kiran");
             Console.WriteLine("Number of items in queue are \t " + queue.Count);
             foreach (var item in queue)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("After removing" + queue.Dequeue());
             Console.WriteLine("Number of items in queue are \t " + queue.Count);
             foreach (var item in queue)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("peek Example" + queue.Peek());
             Console.WriteLine("After peek");
             Console.WriteLine("Number of items in queue are \t " + queue.Count);
             foreach (var item in queue)
             {
                 Console.WriteLine(item);
             }
             queue.Clear();
             Console.WriteLine("Number of items in queue are \t " + queue.Count);
             Console.ReadKey();*/

            /* ArrayList arrayList = new ArrayList()
             { 1,"Sam",'A',DateTime.Now};
             Console.WriteLine("item \t DataTypes");
             foreach (var item in arrayList)
             {
                 Console.WriteLine(item+"\t"+item.GetType());
             }
             ArrayList nameList = new ArrayList() { "raj", "ravi", "Amit"};
             Console.WriteLine("Name list as follows");
             foreach (var item in nameList)
             {
                 Console.WriteLine(item);
             }
             nameList.Add(12);
             nameList.Add(DateTime.Now);
             Console.WriteLine("name list as follows");
             foreach(var item in nameList)
             {
                 Console.WriteLine(item);
             }
             Console.ReadKey();*/


            List<string> list = new List<string>()
            { "Sam", "Ravi", "Amit"};
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Add("Renu");
            Console.WriteLine("****Name list after adding****");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            List<int> listNumbers = new List<int>()
            { 12,23,45,56};
            Console.WriteLine("NUmber list");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            listNumbers.Add(143);
            Console.WriteLine("****after adding****");
            foreach(var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
