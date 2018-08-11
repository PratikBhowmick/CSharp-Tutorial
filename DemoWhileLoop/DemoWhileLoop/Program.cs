using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your target");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= UserTarget)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
            Console.ReadLine();
        }
    }
}
