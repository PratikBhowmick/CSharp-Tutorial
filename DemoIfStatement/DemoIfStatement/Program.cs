using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter a number");

            int i = int.Parse(Console.ReadLine());

            if(i == 1)
            {
                Console.WriteLine("entered number is 1");
            }
            else if (i == 2)
            {
                Console.WriteLine("entered number is 2");
            }
            else if (i == 3)
            {
                Console.WriteLine("entered number is 3");
            }
            else
            {
                Console.WriteLine("Enetered numer is not between 1 and 3");
            }

            Console.ReadLine();
        }
    }
}
