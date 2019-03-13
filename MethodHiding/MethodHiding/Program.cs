using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Full name is : " + FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
       
    }

    public class PartTimeEmployee : Employee
    {        
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine("Full name is : " + FirstName + " " + LastName +"-Contactor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.Email = "abc@gmail.com";            
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmployee();
            //PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.Email = "xyz@gmail.com";
            //((Employee)PTE).PrintFullName();
            PTE.PrintFullName();

            Console.Read();
        }
    }
}
