using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            //EvenNumbers[3] = 6; ArrayIndexOutOfBound Exceptiom

            //int[] EvenNumbers = {0,2,4};

            Console.WriteLine(EvenNumbers[1]);
        }
    }
}
