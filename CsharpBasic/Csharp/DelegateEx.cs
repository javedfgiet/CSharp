using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate void HelloFunctionDelegate(string message);
    public class Delegate
    {
        public void DelegateEx()
        {
            HelloFunctionDelegate obj = new HelloFunctionDelegate(Hello);
            obj("Javed Ahmad");
        }
        public void Hello(string message)
        {
            Console.WriteLine("Hello "+message);
        }

    }
}
