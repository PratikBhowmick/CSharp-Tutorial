using System;

namespace DemoInterface
{
    public interface IFly:IParent
    {
        string GetName();

        string GetSpeed();

        string GetColour();
    }
}
