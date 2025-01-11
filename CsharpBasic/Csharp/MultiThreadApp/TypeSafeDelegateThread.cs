using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public class TypeSafeDelegateThread
    {
        public void TypeDafeFunction()
        {
            Console.WriteLine("Enter Target Number");
            int number=Convert.ToInt32(Console.ReadLine());

            TypeSafe_Number obj=new TypeSafe_Number(number);

            Thread T1=new Thread(obj.PrintNumber);
            T1.Start();


        }
    }
   public class TypeSafe_Number
    {
        int _number;
        public TypeSafe_Number(int number)
        {
            _number = number;
        }

        public void PrintNumber()
        {
            for(int i = 0; i < _number; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
