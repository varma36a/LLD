using Solid.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Abstractions
{
    public abstract class Bird
    {
        private int weight;
        private string colour;
        private string size;
        private string beakType;
        private BirdType type;

        protected Bird(int weight, string colour, string size, string beakType, BirdType type)
        {
            this.weight = weight;
            this.colour = colour;
            this.size = size;
            this.beakType = beakType;
            this.type = type;
        }

        public abstract void fly();
    }
}
