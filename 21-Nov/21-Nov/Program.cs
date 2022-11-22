using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter your first integer number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer number");
            int num2=Convert.ToInt32(Console.ReadLine());
            if(num1<num2)
            {
                Console.WriteLine("The smaller number is :" + num1);
            }
            else
            {
                Console.WriteLine("The smaller number is :" + num2);
            }
            Console.WriteLine("\n");
            //Task2
            Console.WriteLine("Enter your  number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <0)
            {
                Console.WriteLine("The sign is  -");
            }
            else
            {
                Console.WriteLine("The sign is  +");
            }
            Console.WriteLine("\n");

            //Task3
            int x = 0, y = -1,z=4;

            if (x<y && x<z && y<z)
            {
                Console.WriteLine(x + " " + y + " " + z);
            }
            else if (y<x && y<z && z<x)
            {
                Console.WriteLine(y + " "+z+" " + x);
            }
            else
            {
                Console.WriteLine(z + " "+x+" "+y);
            }
            Console.WriteLine("\n");

            //Task4

            int y0= -5,y1= -2,y2= -6,y3= 0,y4= -1 ;
            if (y0 > y1 && y0 > y2 && y0 > y3 && y0 > y4)
            {
                Console.WriteLine(" The max number = " + y0);
            }
            else if (y1 > y0 && y1 > y2 && y1 >y3 && y1 > y4)
            {
                Console.WriteLine(" The max number = " +y1);
            }
            else if (y2 > y0 && y2 > y1 && y2 > y3 && y2 > y4)
            {
                Console.WriteLine(" The max number = " + y2);
            }
            else if (y3 > y0 &&y3 > y1 && y3 > y2 && y3 > y4)
            {
                Console.WriteLine(" The max number = " + y3);
            }
            else 
            {
                Console.WriteLine(" The max number = " + y4);
            }
            Console.WriteLine("\n");
            //Task5

            Console.WriteLine("Enter kilometers per hour:  ");
            double kiloPerHour=Convert.ToDouble(Console.ReadLine());

            double milePerHour = kiloPerHour * 0.6213712;
            Console.WriteLine("The miles per hour =  "+milePerHour);

            Console.WriteLine("\n");
            //Task6
            Console.WriteLine("Enter number of hour : ");
            int hours=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int hourToMinute=hours * 60;
            int total = hourToMinute + minutes;
            Console.WriteLine("The total hour and minutes in a minutes = " + total);

            Console.WriteLine("\n");
            //Task7

            Console.WriteLine("Enter number of minutes : ");
            int min = Convert.ToInt32(Console.ReadLine());

            int minutesToHours = min / 60;
            int minu = min % 60;
            
            Console.WriteLine($"The total hour and minutes in a hour and minute = {minutesToHours} Hours {minu} Minutes");
            Console.WriteLine("\n");

            //Task8

            string[] myArray = { "Rogina", "Rand", "Georgina", "Rami", "Mohammed" };

            Console.WriteLine(myArray[0].Substring(0,4));
            Console.WriteLine(myArray[1].Substring(0, 4));
            Console.WriteLine(myArray[2].Substring(0, 4));
            Console.WriteLine(myArray[3].Substring(0, 4));
            Console.WriteLine(myArray[4].Substring(0, 4));

        }
    }
}
