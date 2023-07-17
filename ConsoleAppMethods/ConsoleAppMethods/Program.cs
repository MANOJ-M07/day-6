using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    public class OurClass
    {
        //instance of method return type void and no parameters
        public void Display() 
        {
            Console.WriteLine("Welcome to Method!!!");
        }

        //static method
        public static void Welcome ()
        {
            Console.WriteLine( "Static method welcomes you !!!!");
        }
        //methods return void & take two parameters
        public void fullName(string fname, string lname)
        {
            Console.WriteLine("Full Name is "+fname+" "+lname);
        }

        //Methods return double & take two parameters
        public double Add(double x, double y)
        {
            double result;
            result = x + y;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*OurClass obj = new OurClass();
            obj.Display();
            obj.fullName("sam", "Dicosta");
            OurClass.Welcome();
            Console.ReadKey();*/
            OurClass ourClass = new OurClass();
            double num1, num2;
            Console.WriteLine("Enter the first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("result after addition \t"+ourClass.Add(num1,num2));

            Console.ReadKey();  
        }
    }
}
