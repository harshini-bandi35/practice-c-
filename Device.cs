/*Create a `Device` class and derive `Smartphone` and `Tablet`.
 * Override `TurnOn()` differently in each class.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("This is the parent class Device");
        }
    }
    public class Smartphone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("This is the child class Smartphone");
        }
    }
    public class Tablet : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("This is the child class Tablet");
        }
    }

}
