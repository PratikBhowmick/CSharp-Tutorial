using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class Program : Customer
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print();
        }

        public override void Print()
        {
            Console.WriteLine("Print method");
        }
    }
}
