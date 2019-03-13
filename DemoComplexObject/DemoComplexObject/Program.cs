using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComplexObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfstudents = new List<Student>();
            
            Student st1 = new Student()
            {
                Name = "Akshay",
                Marks = 200,
                Age = 23
            };

            Student st2 = new Student();
            st2.Name = "Ravi";
            st2.Age = 24;
            st2.Marks = 230;

            Student st3 = new Student()
            {
                Name = "Rishav",
                Marks = 100,
                Age = 25
            };

            listOfstudents.Add(st1);
            listOfstudents.Add(st2);
            listOfstudents.Add(st3);


            foreach(var item in listOfstudents)
            {
                Console.WriteLine("Name is {0}, Marks is {1}, Age is {2}", item.Name, item.Marks, item.Age);
            }

            Console.Read();
        }
    }
}
