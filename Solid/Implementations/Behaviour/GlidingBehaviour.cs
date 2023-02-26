using Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Implementations.Behaviour
{
    class FlappingBehaviour : FlyingBehaviour
    {
        public void makeFly()
        {
            Console.WriteLine("Flapping");
        }
    }
}
