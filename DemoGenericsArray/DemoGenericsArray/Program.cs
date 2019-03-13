using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenericsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[4] { 2,4,5,6};

            //Insert data in particular index
            //ar[0] = 2;
            //ar[1] = 4;
            //ar[2] = 6;
            //ar[3] = 7;
            //Console.WriteLine(ar[3]);

            //foreach(int i in ar)
            //{
            //    Console.WriteLine("Element are  {0} ", i);
            //}

            for(int i = 0; i<=ar.Length-1; i++)
            {
                Console.WriteLine("Element at position {0} is {1}", i, ar[i]);


                Console.WriteLine("Element at position " + i +" is "+ ar[i]);
            }


            Console.Read();


        }
    }
}
