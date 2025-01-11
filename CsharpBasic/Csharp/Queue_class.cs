using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    /*
     * Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace.
     * The Queue collection class is analogous to a queue at the ATM machine to withdraw money.
     * The order in which people queue up, will be the order in which they will be able to get out of the queue and withdraw money
     * from the ATM. 
     * The Queue collection class operates in a similar fashion. 
     * The first item to be added (enqueued) to the queue, will be the first item to be removed (dequeued) from the Queue.
     */
    public class Queue_class
    {
        public void Get_Queue()
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

            // Create a Queue
            Queue<Customer> queueCustomer = new Queue<Customer>();

            // Add: To add an item to the queue, use Enqueue() method.

            queueCustomer.Enqueue(customer1);
            queueCustomer.Enqueue(customer2);
            queueCustomer.Enqueue(customer3);
            queueCustomer.Enqueue(customer4);
            queueCustomer.Enqueue(customer5);

            // To retrieve an item from the queue, use Dequeue() method. Notice that the 
            // items are dequeued in the same order in which they were enqueued.
            // Dequeue() method removes and returns the item at the beginning of the Queue.

            Console.WriteLine("Total Items in the Queue = " + queueCustomer.Count);
            Customer c1 = queueCustomer.Dequeue();
            Console.WriteLine("Id : {0}, Name : {1}, Salary : {2}", c1.Id, c1.Name, c1.Salary);

            Console.WriteLine("Items left in the Queue = " + queueCustomer.Count);

            foreach (Customer customer in queueCustomer)
            {
                Console.WriteLine(customer.Id + " -  " + customer.Name);
                Console.WriteLine("Items left in the Queue = " + queueCustomer.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            // To retrieve an item that is present at the beginning of the
            // queue, without removing it use Peek() method.
            Console.WriteLine("Toal Items in the Queue = " + queueCustomer.Count);
            Customer c = queueCustomer.Peek();
            Console.WriteLine(c.Id + " -  " + c.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomer.Count);
            Console.WriteLine("-----------------------------------------------------------");
            // To check if an item, exists in the queue, use Contains() method.
            if (queueCustomer.Contains(customer1))
            {
                Console.WriteLine("customer1 is in Queue");
            }
            else
            {
                Console.WriteLine("customer1 is not in Queue");
            }




        }
    }
}
