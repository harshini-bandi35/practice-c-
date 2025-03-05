/*Create a `Vehicle` class with `StartEngine()`.
 *Extend it to `Car` and `Motorcycle` with different behaviors.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("This is the parent class vehicle");
        }
    }
    public class Car : Vehicle
    {
       
        public override void StartEngine()
        {
            Console.WriteLine("This is the child class car");
        }
    }
    public class MotorCycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("This is the child class motorcycle");
        }
    }
}
