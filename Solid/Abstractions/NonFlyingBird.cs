using Solid.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Abstractions
{
    public abstract class NonFlyingBird:Bird
    {
        private int weight;
        private string colour;
        private string size;
        private string beakType;
        private BirdType type;

        protected NonFlyingBird(int weight, string colour, string size, string beakType, BirdType type):base(weight, colour, size, beakType, type)
        {
            this.weight = weight;
            this.colour = colour;
            this.size = size;
            this.beakType = beakType;
            this.type = type;
        }

    }
}
