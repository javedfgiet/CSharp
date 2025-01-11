using System;

namespace Csharp.Polymorphism
{
    public interface IEmployee
    {
        void Print();
    }
    public interface IEmployee2
    {
        void Print();
    }

    public class Employee : IEmployee, IEmployee2
    {
        void IEmployee.Print()
        {
            Console.WriteLine("Hello from inteface method1");
        }

        void IEmployee2.Print()
        {
            Console.WriteLine("Hello from inteface method2");
        }
    }

}
