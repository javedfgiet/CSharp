using Csharp.MultiThreadApp;
using System;


namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnonymousMethod obj =new AnonymousMethod();
            obj.GetAnonymousMethod();
            //Console.WriteLine("No Of Processor : {0}",Environment.ProcessorCount);

            Console.ReadLine();
        }
    }
}
