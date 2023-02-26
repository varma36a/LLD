using Solid.Abstractions;
using Solid.Common;
using Solid.Implementations;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird parrot = new Parrot(10, "Green", "Small", "Sharp", BirdType.Parrot);
            parrot.fly();

            Bird eagle = new Eagle(20, "Brown", "Medium", "Sharp", BirdType.Eagle);
            eagle.fly();
        }
    }
}
