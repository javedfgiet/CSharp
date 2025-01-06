using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Methods
    {
        /*Value Parameter*/
        public void Get_ValueParameter()
        {
            int i = 10;
            SampleMethod(i);
            Console.WriteLine(i);
        }
        public void SampleMethod(int j)
        {
            j = 101;
            Console.WriteLine(j);

        }


        /*-----------      Reference Method          ----------------*/

        public void Get_ReferenceParameter()
        {
            int i = 10;
            SampleMethod_Ref(ref i);
            Console.WriteLine("Caller Method : {0}",i);

        }

        public void SampleMethod_Ref(ref int j)
        {
            Console.WriteLine(j);
            j = 101;
            Console.WriteLine("Refrence Method : {0}",j);
        }

        /*------------ Out Paramater       ---------------*/
        public void Get_OutParameter()
        {
            int Total = 10;
            int Product = 10;
            Console.WriteLine("Before Calling method , Toatal : {0} , Product : {1}",Total,Product);
            Calculate(10,20,out Total,out Product);
            Console.WriteLine("Before Calling method , Toatal : {0} , Product : {1}", Total, Product);
        }
        public void Calculate(int Fn,int Sn, out int Sum, out int product)
        {
            Sum = Fn + Sn;
            product = Fn * Sn;
            Console.WriteLine("In Called method , Sum : {0} , Product : {1}", Sum, product);

        }

        /*---------------------------  Parameter Array --------------------------*/

        public void GetParameterArrat()
        {
            int[] numbers=new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            ParamsMethod(numbers);
        }
        public void ParamsMethod(params int[] nums)
        {

            Console.WriteLine("Length : {0}",nums.Length);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
