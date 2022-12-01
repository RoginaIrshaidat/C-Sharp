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
            DateTime now = DateTime.Now;
            TimeSpan value = now.Subtract(birth);
            Console.WriteLine($"The employee age :{(int)value.TotalDays / 365}");
        }

        

        public Employee(string emplName, DateTime birth, int emplId)
        {
            this.employeeName = emplName;
            this.birth = birth;
            this.employeeId = emplId;
        }

        public virtual void print()
        {
            Console.WriteLine($"The Employee Name {employeeName}");
        }
    }
    class Manager : Employee
    {
        private int v;

        public Manager(string emplName, DateTime birth, int emplId) : base(emplName,  birth, emplId)
        {

        }

        public override void print()
        {
            Console.WriteLine($"The Id of employee {employeeId},The Employee Name {employeeName}  ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter the id");
            int ID = Convert.ToInt32(Console.ReadLine());

            DateTime date= new DateTime();

            Console.WriteLine("Enter your birthday as yyyy/mm/dd");
            date = Convert.ToDateTime(Console.ReadLine());
            Employee emp = new Employee(empName, date, ID);
            emp.print();
            emp.age();

            Manager manager = new Manager("Rami",date,50);
            manager.print();
            manager.age();
        }
    }
}
