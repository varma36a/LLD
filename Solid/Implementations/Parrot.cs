using Solid.Abstractions;
using Solid.Common;
using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations
{
    public class Parrot : Bird, Flyable
    {
        private FlyingBehaviour flyingBehaviour;
        public Parrot(int weight, String colour, String size, String beakType, BirdType type, FlyingBehaviour flyingBehaviour) :base(weight, colour, size, beakType, type)
        {
            this.flyingBehaviour = flyingBehaviour;
        }
        public  void fly()
        {
            flyingBehaviour.makeFly();
        }

        public override void makeSound()
        {
            throw new NotImplementedException();
        }
    }
}
