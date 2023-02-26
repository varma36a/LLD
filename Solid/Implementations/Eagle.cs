using Solid.Abstractions;
using Solid.Common;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations
{
    public class Eagle : Bird, Flyable
    {
        public Eagle(int weight, String colour, String size, String beakType, BirdType type) : base(weight, colour, size, beakType, type)
        {
        }
        public void fly()
        {
            Console.WriteLine("\n Eagle is flying");
        }

        public override void makeSound()
        {
            throw new NotImplementedException();
        }
    }
}
