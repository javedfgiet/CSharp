using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public class ProtectShareResource
    {
        static int Total = 0;
        public void GetShareResource()
        {
            Thread T1 = new Thread(AddOneMillion);
            Thread T2 = new Thread(AddOneMillion);
            Thread T3 = new Thread(AddOneMillion);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total = " + Total);

        }
        object _lock = new object();
        public void AddOneMillion()
        {
            for (int i =0; i <= 1000000; i++)
            {
                //Interlocked.Increment(ref Total);
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }
}
