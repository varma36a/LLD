using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations.Behaviour
{
    class GlidingBehaviour : FlyingBehaviour
    {
        public void makeFly()
        {
            Console.WriteLine("Gliding");
        }
    }
}
