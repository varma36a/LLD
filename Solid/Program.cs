﻿using Solid.Abstractions;
using Solid.Common;
using Solid.Implementations;
using Solid.Interfaces;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyable parrot = new Parrot(10, "Green", "Small", "Sharp", BirdType.Parrot);
            parrot.fly();

            Flyable eagle = new Eagle(20, "Brown", "Medium", "Sharp", BirdType.Eagle);
            eagle.fly();

            Bird penguin = new Penguin(30, "Black", "Large", "Sharp", BirdType.Penguin);
            penguin.makeSound();

            // Make a pengiun swim
            ((Swimmable)penguin).swim();
        }
    }
}
