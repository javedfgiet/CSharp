using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class For_ForEach
    {
        public void Get_ForLoop()
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            Console.WriteLine("--------- For Loop ----------");

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void Get_ForEachLoop()
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            Console.WriteLine("--------- For Each Loop ----");
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }

        }
    }
}
