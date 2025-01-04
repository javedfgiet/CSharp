using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    /*
     * Implicit Conversion : is done by the compiler--->
     *  (i) When there is no loss of information if conversion is done.
     *  (ii) If there is no possibility of throwing exception dusring Conversion.
     *  
     *  Example : Converting an int to float will not loose any data and no exception will be thown. hence implicit conversion can be done.
     */

    /*
     * Explicit Conversion : when converting a float to int  we loose the fractiona; part and also a possibility of overflow exception.
     *    hence, in this case an explicit conversion is required
     *    For Explicit Conversion we can use Cast operator or the Convert class in C#.
     */
    public class DataTypeConversion
    {
        /*
         * TypeCast operator: doesnt throw an exception, if it fails to conversion, It Just shows minimum number an int can have.
         */
        public void Explicit_CastOperator()
        {
            float f = 123.45f;
            //int i = f; // Will Throw an error

            int i = (int)f; // Will Work fine : Using TypeCast operator.

            Console.WriteLine(i);
        }

        /*
         * Convert Class :  throw exception if fails to convert
         */
        public void Explicit_ConerionClass()
        {
            float f = 123.45f;

            int i = Convert.ToInt32(f);

            Console.WriteLine(i);
        }

        /*
         * Parse() method: throw an exception if it can not parse the value, where as
         * TryParse() method : return boolean indicatinng whether succeed or failed.
         */
        public void Get_Parse()
        {
            string strNumber = "100";

            int i = int.Parse(strNumber);

            Console.WriteLine(i);
        }
        public void Get_TryParse()
        {
            string str = "1000TG";
            int result = 0;
            bool isConversionSucceed=int.TryParse(str, out result);

            if (isConversionSucceed)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Enter  a valid number");
            }
        }

    }
}
