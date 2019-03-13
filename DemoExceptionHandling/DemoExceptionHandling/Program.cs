using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string name = "Kaushal";
                //int i = int.Parse(name);

                int a = 5;
                int b = 0;
                int result = a / b;
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Tried dividing by zero");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Some exception occured. Please try again. Exeption was : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I am in finally");
                Console.Read();
            }

        }
    }
}
