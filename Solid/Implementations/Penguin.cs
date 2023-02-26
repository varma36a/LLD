using Solid.Abstractions;
using Solid.Common;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations
{
    public class Penguin : Bird, Swimmable
    {
        public Penguin(int weight, String colour, String size, String beakType, BirdType type):base(weight, colour, size, beakType, type)
        {
        }
        public override void makeSound()
        {

        }

        public void swim()
        {

        }
    }
}
