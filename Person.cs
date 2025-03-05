/*Create a `Person` class with a method `GetDetails()`. 
 * Derive a `Student` class that overrides it.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Person
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("this is parent class person");
        }
    }
    public class Student:Person{
        public override void GetDetails()
        {
            //base.GetDetails();
            Console.WriteLine("this is child class student");
        }

    }
    }
