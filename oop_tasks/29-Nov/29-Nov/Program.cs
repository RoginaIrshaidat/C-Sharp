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
        public int birth { get; set; }
        public int employeeId { get; set; }

        public virtual void age(int year)
        {
            int age = 2022 - year;
            Console.WriteLine($"The employee age = {age}");
        }

        public Employee(string emplName, int birth, int emplId)
        {
            this.employeeName = emplName;
            this.birth = birth;
            this.employeeId = emplId;
        }

        
        
        public void print()
        {
            Console.WriteLine($"The Id of employee {employeeId},The Employee Name {employeeName} , the birth date  {birth} ");
        }
    }
    class Manager : Employee
    {
        public Manager(string emplName, int birth, int emplId ): base ( emplName,  birth,  emplId)
        {

        }
        public override void age(int year)
        {
            int age = 2022 - year;
            Console.WriteLine($"The manager age = {age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter birth date ");
            int birth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the id");
            int ID = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee(empName, birth, ID);
            emp.print();
            emp.age(birth);

            Manager manager = new Manager("Rami",1996,50);
            manager.print();
            manager.age(1996);
        }
    }
}
