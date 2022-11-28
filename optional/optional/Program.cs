using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace optional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            welcome(name);
            Console.WriteLine("Enter your first double number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second double number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = add(num1, num2);
            double sub = Sub(num1, num2);
            double mul = Mul(num1, num2);
            double div =Div(num1, num2);
            Console.WriteLine($"The summation of {num1} and {num2} are equal = {sum}");
            Console.WriteLine($"The Subtraction of {num1} and {num2} are equal = {sub}");
            Console.WriteLine($"The Multipulation of {num1} and {num2} are equal = {mul}");
            Console.WriteLine($"The Divation of {num1} and {num2} are equal = {div}");

            Goodbye(name);


        }

        public static void welcome(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        public static double add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        
        }
        public static double Sub(double num1, double num2)
        {
            double sub = num1 - num2;
            return sub;

        }
        public static double Mul(double num1, double num2)
        {
            double mul = num1 * num2;
            return mul;

        }
        public static double Div(double num1, double num2)
        {
            double div = num1 / num2;
            return div;

        }
        public static void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }

    }
}
