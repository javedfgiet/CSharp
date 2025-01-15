using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public class MonitorNlock
    {
        static int Total = 0;
        static object _lock=new Object();

        public void GetMonitor()
        {
            AddOneMillion_4();
            AddOneMillion_4();
            AddOneMillion_4();
            Console.WriteLine(Total);

        }
        public void AddOneMillion()
        {
            for (int i = 1;i<=1000000;i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        // For C# 4 is little diffrent
        public void AddOneMillion_4()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                bool islocaktaken = false;
                Monitor.Enter(_lock,ref islocaktaken);
                try
                {
                    Total++;
                }
                finally
                {
                    if (islocaktaken)
                    {
                        Monitor.Exit(_lock);
                    }
                
                }
            }
        }
    }
}
