using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;

                //case 5:
                default:
                    Console.WriteLine("Number is not 1 or 2 or 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}
