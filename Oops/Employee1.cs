using System;

namespace Oops
{
    internal class Employee1
    {
        public int Id = 101;
        public string Name = "Rani";
        public decimal Salary = 90000;

        public decimal IncrementSalary(double per)
        {
            Salary = Salary + (Salary * (decimal)(per / 100));
            return Salary;
        }

        public void DisplayEmployee1Details()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("-----------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee1 emp1 = new Employee1();

            emp1.DisplayEmployee1Details();
            emp1.IncrementSalary(10);
            emp1.DisplayEmployee1Details();
        }
    }
}

