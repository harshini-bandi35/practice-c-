namespace practicecsharp
{
    internal class Program
    {
        static void Main(string[] args)
        /*{
            Animal ani = new Animal();
            ani.Speak();
            Dog d = new Dog();
            d.Speak();
        }
        {
            Person p = new Person();
            p.GetDetails();
            Student s = new Student();
            s.GetDetails();
        }
        {
            Employee e = new Employee();
            e.GetSalary(1000, 0);
            Manager m = new Manager();
            m.GetSalary(100000, 2000);
            
        }
        {
            Vehicle v = new Car();
            v.StartEngine();
            Vehicle v1 = new MotorCycle();
            v1.StartEngine();
        }
        {
            BankAccount b = new BankAccount();
            b.Deposit(1000);
            b.Withdraw(500);
            SavingsAccount s = new SavingsAccount();
            s.Deposit(10000);
            s.CalculateInterest();
            s.Withdraw(500);
            s.CalculateInterest();
        }
        {
            Device d = new Smartphone();
            d.TurnOn();
            Device d1 = new Tablet();
            d1.TurnOn();
        }*/
        {
            Shape s = new Circle(4.5);
            Console.WriteLine("The area of circle is: "+s.CalculateArea());
            Shape shape = new Rectangle(4, 5);
            Console.WriteLine("The are of rectangle is: "+shape.CalculateArea());
            s.CalculateArea();
        }

    }
}
