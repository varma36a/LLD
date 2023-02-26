using Solid.Abstractions;
using Solid.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations
{
    public class Eagle : Bird
    {
        public Eagle(int weight, String colour, String size, String beakType, BirdType type):base(weight, colour, size, beakType, type)
        {
        }
        public override void fly()
        {
            Console.WriteLine("\n Eagle is flying");
        }
    }
}
