using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName="FN";
        public string LastName="LN";        

        public virtual void PrintFullName()
        {
            Console.WriteLine("Full name is : " + FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full name is : " + FirstName + " " + LastName+"-Full time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full name is : " + FirstName + " " + LastName+ "-Part time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full name is : " + FirstName + " " + LastName + "-Temporary");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees= new Employee[4];
            employees[0] = new FullTimeEmployee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new TemporaryEmployee();

            foreach(Employee emp in employees)
            {
                emp.PrintFullName();
            }
        }
    }
}
