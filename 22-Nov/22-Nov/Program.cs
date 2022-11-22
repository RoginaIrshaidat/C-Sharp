using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _22_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            int[] Arr = { 1, 7, 9, 4, 5 };
            //string[] Arr = { "1", "7", "9", "4", "5" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //Task2
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                {
                    Console.WriteLine($"The Banana index is: {i}");
                }
                else if (fruits[i] == "Tomato")
                {
                    Console.WriteLine($"The Tomato index is: {i}");
                }
            }

            Console.WriteLine("\n");

            //Task3

            string[] favoriteFood = { "Spaghetti", "Burger", "Pizza", "Mansaf", "Mlokheh" };
            Console.WriteLine("My Favorite Food are : ");
            foreach (string food in favoriteFood)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine("\n");
            string[] favoriteSport = { "Football", "Walking", "Tennis" };
            string[] favoriteMovie = { "Spider Man", "Twilight", "Titanic", "Joker" };
            Console.WriteLine("My Favorite Movie  are : ");
            for (int i = 0; i < favoriteMovie.Length; i++)
            {
                Console.WriteLine(favoriteMovie[i]);
            }
            Console.WriteLine("\n");

            //Task4
            Console.WriteLine("Enter your 3 number using , between the num");

            string num = Console.ReadLine();
            string[] number = num.Split(',');

            int summution = 0;
            for (int i = 0; i <number.Length; i++)
            {
                
                summution += Convert.ToInt32(number[i]);
            }
            Console.WriteLine($"The Summuation of 3 numbers =  {summution}");
            Console.WriteLine();


            //Task5
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine($"The Sum of odd Numbers = {sum}");

            Console.WriteLine("\n");
            //Task6


            for (int r = 1; r < 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*" + "  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Task7

 
            int v = 1;
            for (int r = 1; r < 5; r++)
                {
                    for (int c = 1; c <= r; c++)
                    {
                    Console.Write(v + "  ");
                        v += 1;
                    }
                Console.WriteLine();

                }

        }
    }
}
