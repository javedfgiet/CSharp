using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.MultiThreadApp
{
    public delegate void PrintSumOfNumberCallBack(int number);
    public class CallBackNumber
    {
        public void CallBackFirst()
        {
            Console.WriteLine("Eneter Target Number");
            int number = Convert.ToInt32(Console.ReadLine());

            PrintSumOfNumberCallBack callBack = new PrintSumOfNumberCallBack(PrintSumOfNumber);
            SumOfNumberClass obj = new SumOfNumberClass(number, callBack);

            Thread T1=new Thread(obj.ComputeSumOfNumber);
            T1.Start();


        }

        public void PrintSumOfNumber(int sum)
        {
            Console.WriteLine("Sum Of Number : {0}", sum);

        }
    }

    public class SumOfNumberClass
    {
        public int _target;
        public PrintSumOfNumberCallBack _callBack;
        public SumOfNumberClass(int target, PrintSumOfNumberCallBack callBack)
        {
            this._target = target;
            this._callBack = callBack;

        }
        public void ComputeSumOfNumber()
        {
            int sum = 0;
            for (int i = 0; i < _target; i++)
            {
                sum = sum + i;

            }

            if (_callBack != null)
            {
                _callBack(sum);
            }

        }
    }
}
