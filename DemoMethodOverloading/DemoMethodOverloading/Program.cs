using System;

namespace DemoMethodOverloading
{
    class Program   
    {
        static void Main(string[] args)
        {
            MethodOverload obj = new MethodOverload();
            obj.Add(2, 3);
            obj.Add(2, 2, 2);
            obj.Add(5.5f, 6.7f);

            Console.Read();
        }
    }

    public class MethodOverload
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
}
