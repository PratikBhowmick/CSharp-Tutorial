using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Aeroplane : IFly,IParent
    {
        public string GetColour()
        {
            return "RED";
        }

        public string GetName()
        {
            return "BOEING 500D";
        }

        public string GetSpeed()
        {
            return "1000 km per hour";
        }

        public bool IsAlive()
        {
            return false;
        }
    }
}
