/*1. Create a simple base class `Animal` with a method `Speak()`.
 * Derive a `Dog` class that overrides it.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("parent class animal");
        }

    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("child class Dog");
        }
    }
}
