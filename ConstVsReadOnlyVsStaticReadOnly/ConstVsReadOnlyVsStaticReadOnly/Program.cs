using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVsReadOnlyVsStaticReadOnly
{
    public class Program
    {
        //variable declaration and initialization
        const string co = "Constant";
        readonly string re;
        readonly static string Rse;

        //Default Constructor
        public Program()
        {
            //co = "";  //Cannot be changed
            re = "ReadOnly value Changed in default constructor";
            //Rse = "ReadOnly value Changed in default constructor"; //Cannot be changed            
        }

        //Default Constructor
        static Program()
        {
            //co = ""; //Cannot be changed
            //re = "ReadOnly value Changed in default constructor"; //Cannot be changed
            Rse = "ReadOnly static value Changed in static constructor";
        }

        //Parameterized Constructor
        public Program(string var)
        {
            //co = ""; //Cannot be changed
            re = var + "ReadOnly value Changed in parameterized constructor";
            //Rse = "ReadOnly value Changed in parameterized constructor"; //Cannot be changed
        }

        //Normal method
        public void Method()
        {
            //co = ""; //Cannot be changed
            //re = "ReadOnly value Changed in method"; //Cannot be changed
            //Rse = "ReadOnly value Changed in method"; //Cannot be changed
        }

        static void Main(string[] args)
        {
            //Program obj = new Program();
            Program obj = new Program("Hello ");
            Console.WriteLine(co);
            Console.WriteLine(obj.re);
            Console.WriteLine(Rse);

            Console.ReadKey();
        }
    }
}
