using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Bird : IFly
    {
        public string GetColour()
        {
            return "WHITE";
        }

        public string GetName()
        {
            return "PIGEON";
        }

        public string GetSpeed()
        {
            return "10 km per hour";
        }

        public string IndependentMethod()
        {
            return "I am independent";
        }

        public bool IsAlive()
        {
            return true;
        }        
    }
}
