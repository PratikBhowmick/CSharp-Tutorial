using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.BaseClasses;

namespace Inheritance
{
    class Program
    {     
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Rajiv";
            FTE.LastName = "Meheta";
            FTE.Email = "abc@gmail.com";
            FTE.YearlySalary = 20000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Rohan";
            PTE.LastName = "Singh";
            PTE.Email = "xyz@gmail.com";
            PTE.HourlyRate = 5000;
            PTE.PrintFullName();

            Console.Read();
        }
    }
}
