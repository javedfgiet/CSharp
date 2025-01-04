using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    /*
     * In C# types are divided into two broad categories
     * ValueType : int, float, double, struct, enum etc.
     * ReferenceType : Class , interface, delegate array, string etc.
     * By default vaueType are non nullable. To make them nullable use " ? ".
     * 
     * 
     * ValueType : ValueType varibales can be assigned a value directly. They are derived from the class Stystem.ValueType
     *             The valueType directly contain data. When you declare an int type. The system allocates memory to store 
     *             the value. Value type varibales are stored in stack.
     *             
     * ReferenceType : It refers to a memory  location. Reference types variales are stored in Heap. Object, dynamic and string
     * 
     */
    internal class Nullable_NonNullable
    {
        public void Get_Nullable()
        {
            int AvailableTicket;
            int? TicketOnSale = null;
            if (TicketOnSale == null)
            {
                AvailableTicket = 0;
            }
            else
            {
                AvailableTicket=(int)TicketOnSale;
            }
            Console.WriteLine("Available Tickets : {0}",AvailableTicket);
        }
    }
}
