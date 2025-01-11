using Csharp.MultiThreadApp;
using System;


namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallBackNumber obj =new CallBackNumber();
            obj.CallBackFirst();

            Console.ReadLine();
        }
    }
}
