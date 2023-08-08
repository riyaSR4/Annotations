using System;

namespace Annotations
{
    class Program
    {
        static void Main(string[] args)
        {
            NewAttribute.AttributeDisplay(typeof(Employer));
            NewAttribute.AttributeDisplay(typeof(Employee));
        }
    }
}