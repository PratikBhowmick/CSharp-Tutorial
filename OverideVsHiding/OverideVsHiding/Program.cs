using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideVsHiding
{
    public class BaseClass
    {
        public  virtual void Print()
        {
            Console.WriteLine("I am a base class print method");
        }
    }
    public class DerivedClass:BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a derived class print method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();

            
            //BaseClass B = new BaseClass();
            //B.Print();

            Console.Read();
        }
    }
}
