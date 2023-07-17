
/*//call by Value
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameters
{
    public class Calc
    {
        public void Increment(int num)
        {
            Console.WriteLine("Value of num inside method befor increment \t" + num);
            num += 5;
            Console.WriteLine("Value of num inside method after increment \t" + num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("enter the number");
            myNum = int.Parse(Console.ReadLine());
            Console.WriteLine("myNum in main before method call \t" +myNum);
            Calc calc = new Calc();
            calc.Increment(myNum);
            Console.WriteLine("myNUm in main after method call \t"+myNum);
            Console.ReadKey();  
        }
    }
}*/

//call by reference 
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameters
{
    public class Calc
    {
        public void Increment(ref int num)
        {
            Console.WriteLine("Value of num inside method befor increment \t" + num);
            num += 5;
            Console.WriteLine("Value of num inside method after increment \t" + num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("enter the number");
            myNum = int.Parse(Console.ReadLine());
            Console.WriteLine("myNum in main before method call \t" + myNum);
            Calc calc = new Calc();
            calc.Increment(ref myNum);
            Console.WriteLine("myNUm in main after method call \t" + myNum);
            Console.ReadKey();
        }
    }
}*/

/*using System;
namespace ConAppParameters
{
    public class Calc
    {
        public void BonusCalc(double salary, ref double bounus)
        {
            bounus = salary * 0.2;
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            double bonus = 500;
            Calc calc = new Calc();
            calc.BonusCalc(salary, ref bonus);
            Console.WriteLine($"salary\t{salary}and Bonus: {bonus}");
            Console.ReadKey();
        }
    }
}
*/

/*
using System;
namespace ConAppParameters
{
    public class Calc
    {
        public void BonusCalc(double salary, out double bounus)
        {
            bounus = salary * 0.2;
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            Calc calc = new Calc();
            calc.BonusCalc(salary, out double bonus);
            Console.WriteLine($"salary\t{salary}and Bonus: {bonus}");
            Console.ReadKey();
        }
    }
}
*/


using System;
namespace ConAppParameters
{
    public class Calc
    {
        public double Add(params double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            return total;
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {

            Calc calc = new Calc();
            Console.WriteLine("Result after adding 1,12,23,5 is \t" + calc.Add(1, 12, 23, 5));
            Console.ReadKey();
        }
    }
}
