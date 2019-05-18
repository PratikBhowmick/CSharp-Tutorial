using System;


namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird objBird = new Bird();
            Console.WriteLine(objBird.GetName() + " " + objBird.GetColour() + " " + objBird.IsAlive() + " " + objBird.GetSpeed());

            Console.ReadLine();
        }
    }
}
