/*Implement an `Employee` base class with a method `CalculateSalary()`.
 * Create a `Manager` class that adds a bonus to salary.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicecsharp
{
    public class Employee
    {
        public int Salary { get; set; }
        public int Bonus { get; set; }
        public virtual void GetSalary(int salary,int bonus)
        {
            Salary = salary;
            Bonus = bonus;
            Console.WriteLine("Salary is: " + Salary);
        }
        
    }
    public class Manager : Employee 
    {

        public override void GetSalary(int salary, int bonus)
        {
            Salary = salary;
            Bonus = bonus;
            Console.WriteLine("The salary of employee is: "+(Salary + Bonus));
        }
        


    }

}
