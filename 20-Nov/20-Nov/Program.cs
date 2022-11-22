using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter Your Name :");
            string Name = Console.ReadLine();
            Console.WriteLine(Name);
            Console.WriteLine("\n");

            //Task2

            double salary = 550.50;
            Console.WriteLine("Your Salary :" + salary);
            string position = "Full Stack Developer";
            Console.WriteLine("Your Position is :" + position);
            bool status = true;
            Console.WriteLine("Your Status is :" + status);
            int age = 24;
            Console.WriteLine("Your age are :" + age);
            char firstChar = 'R';
            Console.WriteLine("Your first char :" + firstChar);
            const int month = 10;
            Console.WriteLine("The month you join to academy:" + month);
            Console.WriteLine("\n");

            //Task3

            string[] car = { "Mazda", "Tsla", "G-Class" };
            Console.WriteLine("The Array elements :");
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine("The length of array :" + car.Length);
            Console.WriteLine("\n");

            //Task4

            Console.WriteLine("Enter Your First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Year of birthday :");
            string yearBirthday = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName + " " + yearBirthday);
            Console.WriteLine("\n");

            //Task5

            int[] num = new int[10];
            Console.WriteLine("Enter The array elements");
            num[0] = 1;
            Console.WriteLine("element-0 : "+num[0]);
            num[1] = 1;
            Console.WriteLine("element-1 : " + num[1]);
            num[2] = 2;
            Console.WriteLine("element-2 : " + num[2]);
            num[3] = 3;
            Console.WriteLine("element-3 : "+ num[3]);
            num[4] = 4;
            Console.WriteLine("element-4 : " + num[4]);
            num[5] = 5;
            Console.WriteLine("element-5 : " + num[5]);
            num[6] = 6;
            Console.WriteLine("element-6 : " + num[6]);
            num[7] = 7;
            Console.WriteLine("element-7 : " + num[7]);
            num[8] = 8;
            Console.WriteLine("element-8 : " + num[8]);
            num[9] = 9;
            Console.WriteLine("element-9 : " + num[9]);
            Console.WriteLine("\n");


            //Task6

            int sum = num[0] + num[1] + num[2] + num[3] + num[4] +
                num[5] + num[6] + num[7] + num[8] + num[9];

            Console.WriteLine("The Sum of element array =" + sum);
          

        }
    }
}
