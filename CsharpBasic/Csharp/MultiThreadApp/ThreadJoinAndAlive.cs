using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public class ThreadJoinAndAlive
    {
        public void Get_MainThreadFunction()
        {
            Console.WriteLine("Main Thread Started");

            Thread T1 = new Thread(Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Thread2Function);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Thread1 Function Completed");
            }
            else
            {
                Console.WriteLine("Thread1 Function not completed in 1 sec.");
            }

            T2.Join();
            Console.WriteLine("Thread2 Function Completed");

            for (int i = 0; i < 10; i++)
            {

                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1 Funcrion is still doing its work");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1 fucntion is completed");
                    break;
                }
            }

            Console.WriteLine("Main Completed");
        }

        public void Thread1Function()
        {
            Console.WriteLine("Thread1 Function Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 Function is about to return");
        }
        public void Thread2Function()
        {
            Console.WriteLine("Thread2 Function Started");
        }
    }
}
