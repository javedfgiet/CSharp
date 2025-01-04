using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class SwitchCase
    {
        public void Get_Switch()
        {
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("USer number is 10");
                    break;
                case 20:
                    Console.WriteLine("User number is 20");
                    break;
                case 30:
                    Console.WriteLine("User number is 30");
                    break;

                default:
                    Console.WriteLine("User has entered other number tha 10, 20, 30");
                    break;

            }
        }
    }
}
