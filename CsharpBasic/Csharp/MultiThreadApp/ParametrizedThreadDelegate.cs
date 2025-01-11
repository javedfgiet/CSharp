using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public class ParametrizedThreadDelegate
    {
        public void Get_ParametrizedThread()
        {
            Console.WriteLine("Enter target number");
            object number = Console.ReadLine();

            NumbersTest obj = new NumbersTest();

            //ParameterizedThreadStart parameterizedThreadStart =
            //       new ParameterizedThreadStart(obj.PrintNumers);

            //Thread T1 = new Thread(parameterizedThreadStart);
            Thread T1=new Thread(obj.PrintNumers);
            T1.Start(number);

        }
    }

    public class NumbersTest
    {
        public void PrintNumers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
