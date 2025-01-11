using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    /*
     * Stack is a generic LIFO (Last In First Out) collection class that is present in System.Collections.Generic namespace.
     * The Stack collection class is analogous to a stack of plates. 
     * If you want to add a new plate to the stack of plates, you place it on top of all the already existing plates.
     * If you want to remove a plate from the stack, you will first remove the one that you have last added. 
     * The stack collection class also operates in a similar fashion. 
     * The last item to be added (pushed) to the stack, will be the first item to be removed (popped) from the stack.
     * 
     * To insert an item at the top of the stack, use Push() method.
     * To remove and return the item that is present at the top of the stack, use Pop() method.
     * A foreach loop iterates thru the items in the stack, but will not remove them from the stack. 
     * The items from the stack are retrieved in LIFO (Last In First Out), order. 
     * The last element added to the Stack is the first one to be removed.
     * To check if an item exists in the stack, use Contains() method.
     * 
     * What is the difference between Pop() and Peek() methods?
     * Pop() method removes and returns the item at the top of the stack, 
     * where as Peek() returns the item at the top of the stack, without removing it.
     * 
     */
    public class Stack_Class
    {
        public void Get_StackMethod()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 4500
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Pam",
                Salary = 5000
            };

            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "John",
                Salary = 5500
            };

            Customer customer4 = new Customer()
            {
                Id = 104,
                Name = "Ken",
                Salary = 6000
            };

            Customer customer5 = new Customer()
            {
                Id = 105,
                Name = "Valarie",
                Salary = 6500
            };
            Stack<Customer> stackCustomer = new Stack<Customer>();

            // To add an item to the stack, use Push() method.

            stackCustomer.Push(customer1);
            stackCustomer.Push(customer2);
            stackCustomer.Push(customer3);
            stackCustomer.Push(customer4);
            stackCustomer.Push(customer5);
            Console.WriteLine("Total Item in Stack : {0}", stackCustomer.Count);

            // To retrieve an item from the stack, use Pop() method. This method 
            // removes and returns an object at the top of the stack. Since customer5

            // object is the one that is pushed onto the stack last, this object will be
            // first to be removed and returned from the stack by the Pop() method.
            Customer C1 = stackCustomer.Pop();

            Console.WriteLine("Id : {0}, Name : {1}", C1.Id, C1.Name);

            Console.WriteLine("Item Left in Stack : {0}", stackCustomer.Count);

            // If you need to loop thru items in the stack, foreach loop can be used in the same 
            // way as we use it with other collection classes. The foreach loop will only iterate 
            // thru items in the stack, but will not remove them. Notice that the items from the 
            // stack are retrieved in LIFO (Last In First Out), order. The last element added to 
            // the Stack is the first one to be removed.

            foreach (Customer customer in stackCustomer)
            {
                Console.WriteLine(customer.Id + " -  " + customer.Name);
                Console.WriteLine("Items left in the Stack = " + stackCustomer.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            // To retrieve an item that is present at the top of the 
            // stack, without removing it use Peek() method.
            Customer c = stackCustomer.Peek();
            Console.WriteLine(c.Id + " -  " + c.Name);

            if (stackCustomer.Contains(customer1))
            {
                Console.WriteLine("customer1 is in stack");
            }
            else
            {
                Console.WriteLine("customer1 is not in stack");
            }
        }
    }
}
