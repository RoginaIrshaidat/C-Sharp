using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Nov
{
    internal class Program
    {
        public class Employee
        {
            int Age;
            string Gender;
            string Name;
            string E_Mail;
            int ID;
            string Phone;



            public Employee(int myAge, string myGender, string myName, string myE_Mail, int myID, string myPhone)
            {
                Age = myAge;
                Gender = myGender;
                Name = myName;
                E_Mail = myE_Mail;
                ID = myID;
                Phone = myPhone;
            }
            public static void print(int myAge, string myGender, string myName, string myE_Mail, int myID, string myPhone)
            {
                Console.WriteLine($" My id {myID} , name is {myName} , age are {myAge} , gender is {myGender}, email {myE_Mail} , phone {myPhone}");
            }
            public static void ageRange(int age)
            {
                if (age == 18 && age < 60)
                {
                    Console.WriteLine("your age in the range of age");
                }
                else
                {
                    Console.WriteLine("your age not in the range");
                }

            }

            public static void phoneStart(string phone)
            {
                string phoNum = phone.Substring(0, 3);
                if (phoNum == "079" || phoNum == "078" || phoNum == "077")
                {
                    Console.WriteLine($" your phone number {phone}");
                }
                else
                {
                    Console.WriteLine("Wrong phone number");
                }
            }
        }



        static void Main(string[] args)
        {
            
            Employee emp = new Employee(24, "Female", "Rogina", "roginaershedat@gmal.com", 32, "0790161860");
            Employee.print(24, "Female", "Rogina", "roginaershedat@gmal.com", 32, "0790161860");
            Employee.ageRange(10);
            Employee.phoneStart("07612500");
        }
    }
}