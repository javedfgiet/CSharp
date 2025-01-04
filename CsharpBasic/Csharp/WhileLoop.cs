using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class WhileLoop
    {
        public void Get_WhileLoop()
        {
            Console.WriteLine("Enter the target number");
            int targetNo = int.Parse(Console.ReadLine());
            int startNumber = 0;

            while (startNumber <= targetNo)
            {
                Console.WriteLine(startNumber);
                startNumber = startNumber + 2;
            }
        }

        public void Get_DoWhileLoop()
        {
            string userChoice = string.Empty;
            
            int startNumber = 0;
            do
            {
                Console.WriteLine("Do you want to continue.. Pls Enete Yes Or No");
                userChoice = Console.ReadLine();
                if (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no")
                {
                    Console.WriteLine("Please enter Yes or No");
                }
                else
                {
                    if(userChoice.ToLower() == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the target number");
                        int targetNo = int.Parse(Console.ReadLine());
                        while (startNumber <= targetNo)
                        {
                            Console.WriteLine(startNumber);
                            startNumber = startNumber + 2;
                        }
                    }
                }
                
            }
            while (userChoice.ToLower() == "yes");
        }
    }
}
