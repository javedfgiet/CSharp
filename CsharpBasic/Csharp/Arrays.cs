using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Arrays
    {
        /*
         * Advantages : Array are stronlgy typed.
         * 
         * Disadvantages : Array can not grow in size once initializd.
         */
        public void GetArray()
        {
            int[] evenNumber=new int[3];
            evenNumber[0] = 0;
            evenNumber[1] = 2;
            evenNumber[2] = 4;

            int[] oddNumber = { 0, 1, 3 };

            Console.WriteLine("......Printing Even here..............");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(evenNumber[i]);
            }

            Console.WriteLine("Printing Odd Numbers");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(oddNumber[i]);
            }
            

           

        }
    }
}
