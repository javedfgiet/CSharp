using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{

    /*
     * Why a delegate need to be passed as a parameter to the Thread class constructor?
     * The purpose of creating a Thread is to execute a function.
     * A delegate is a type safe function pointer, meaning it points to a function that the thread 
     * has to execute. 
     * In short, all threads require an entry point to start execution. 
     * Any thread you create will need an explicitly defined entry point i.e a pointer to the function 
     * where they should begin execution. So threads always require a delegate.
     */
    /*
     * In the code below, we are not explicitly creating the ThreadStart delegate, 
     * then how is it working here? 
     * Thread T1 = new Thread(Number.PrintNumbers);
     * It's working in spite of not creating the ThreadStart delegate explicitly because 
     * the framework is doing it automatically for us.
     */
    public class ThreadDelegateClass
    {
        public void GetThreadDelegate()
        {
            Numbers obj=new Numbers();
            //Thread T1 = new Thread(delegate () { obj.PrintNumers(); });
            //Thread T1 = new Thread(obj.PrintNumers);
            Thread T1=new Thread(() => { obj.PrintNumers(); });
            T1.Start();
        }
    }

    public class Numbers
    {
        public void PrintNumers()
        {
            for(int i = 0;i< 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
