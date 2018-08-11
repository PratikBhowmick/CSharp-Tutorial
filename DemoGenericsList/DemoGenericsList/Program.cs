using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenericsList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listname = new List<int>();

            listname.Add(2);
            listname.Add(4);
            listname.Add(6);
            listname.Add(8);

            listname.Remove(4);
            listname.RemoveAt(0);
            

            Console.WriteLine("Count is = " + listname.Count);

            foreach(int i in listname)
            {
                Console.WriteLine(i);
            }

            Console.Read();

        }
    }
}
