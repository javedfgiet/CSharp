using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public interface IA
    {
        void PrintA();
    }
    public class A : IA
    {
        public void PrintA()
        {
            Console.WriteLine("Print A method is called");
        }
    }

    public interface IB
    {
        void PrintB();
    }
    public class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("Print B method is called");
        }
    }

    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void PrintA()
        {
            a.PrintA();
        }

        public void PrintB()
        {
            b.PrintB();
        }
    }
}
