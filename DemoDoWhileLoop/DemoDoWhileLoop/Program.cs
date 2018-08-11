using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;

            do
            {
                Console.WriteLine("Please eneter the target");
                int target = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= target)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }                

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No ?");
                    UserChoice = Console.ReadLine();

                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("Invalid choice");
                    }
                } while (UserChoice != "Yes" && UserChoice != "No"); 
            } while (UserChoice == "Yes");


        }
    }
}
