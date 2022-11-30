using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Nov
{
    class Employee
    {
        public string employeeName { get; set; }
        public DateTime birth { get; set; }
        public int employeeId { get; set; }

        public  void age()
        {
            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(birth);

            Console.WriteLine((int)value.TotalDays / 365);
        }

        

        public Employee(string emplName, int day, int month, int year, int emplId)
        {
            this.employeeName = emplName;
            birth = new DateTime(year, month, day); ;
            this.employeeId = emplId;
        }

        public virtual void print()
        {
            Console.WriteLine($"The Employee Name {employeeName}");
        }
    }
    class Manager : Employee
    {
        public Manager(string emplName, int day, int month, int year, int emplId) : base(emplName, day, month, year, emplId)
        {

        }
        public override void print()
        {
            Console.WriteLine($"The Id of employee {employeeId},The Employee Name {employeeName} , the birth date  {birth} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter day of birthday date ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month of birthday date ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter day of year date ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the id");
            int ID = Convert.ToInt32(Console.ReadLine());

            //Employee emp = new Employee(empName, day,month, year, ID);
            //emp.print();
            //emp.age(day,month,year);

            Manager manager = new Manager("Rami",11,11,1996,50);
            manager.print();
            manager.age();
        }
    }
}
