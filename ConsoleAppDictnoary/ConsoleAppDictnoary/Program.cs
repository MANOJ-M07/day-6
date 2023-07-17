using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDictnoary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary<int, string> dict = new Dictionary<int, string>()
             {
                 {1, "Sam" },
                 {12, "Amit" },
                 {53, "Raj" }
             };
             Console.WriteLine("NUmber of students :"+dict.Count);
             Console.WriteLine("Roll \t Name");
             foreach (var k in dict.Keys) 
             {
                 Console.WriteLine(k + "\t" + dict[k]);
             }
             dict.Add(32,"Deep");
             Console.WriteLine("updated students list");
             Console.WriteLine("roll \t Name");
             foreach(var k in dict.Keys)
             {
                 Console.WriteLine(k + "\t" + dict[k]);
             }
             Console.ReadKey();  */

            /* SortedList<int, string> dict = new SortedList<int, string>()
             {
                 {1, "Sam" },
                 {12, "Amit" },
                 {53, "Raj" }
             };
             Console.WriteLine("NUmber of students :" + dict.Count);
             Console.WriteLine("Roll \t Name");
             foreach (var k in dict.Keys)
             {
                 Console.WriteLine(k + "\t" + dict[k]);
             }
             dict.Add(32, "Deep");
             Console.WriteLine("updated students list");
             Console.WriteLine("roll \t Name");
             foreach (var k in dict.Keys)
             {
                 Console.WriteLine(k + "\t" + dict[k]);
             }
             Console.ReadKey();*/

            /*SortedList<string,string> hardwareList = new SortedList<string,string>()
            {
                {"CD","Compact Disc" },
                {"FDD", "Floppy Disc" },
                {"HDD", "Hard Disc" },
                {"RAM", "Random Acess Memory" }
            };
            Console.WriteLine("Short Form \t Full Form");
            foreach (var k in hardwareList.Keys)
            {
                Console.WriteLine(k + "\t" + hardwareList[k]);
            }
            Console.ReadKey();*/

            SortedList<string, int> hardwareList = new SortedList<string, int>()
            {
                {"CD",200 },
                {"FDD", 5000 },
                {"HDD", 2000 },
                {"RAM", 100 }
            };
            Console.WriteLine("Short Form \t Full Form");
            foreach (var k in hardwareList.Keys)
            {
                Console.WriteLine(k + "\t" + hardwareList[k]);
            }
            Console.ReadKey();

        }
    }
}
