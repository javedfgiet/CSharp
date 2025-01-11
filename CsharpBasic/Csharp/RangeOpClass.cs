using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class RangeOpClass
    {
        List<Customer> listCustomers = new List<Customer>();
        public RangeOpClass()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 4000,
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Pam",
                Salary = 7000,
            };

            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Rob",
                Salary = 5500,
            };




            // Add() method allows you to add one at a time to the end of the list
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
        }

        public void Get_RangeOps()
        {
            Customer customer4 = new Customer()
            {
                Id = 104,
                Name = "John",
                Salary = 6500,
            };

            Customer customer5 = new Customer()
            {
                Id = 105,
                Name = "Sam",
                Salary = 3500,
            };

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);
            // AddRange() allows you to add another list of items, to the end of the list

            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // GetRange() function returns a list of items from the list.

            var getRangeOperator = listCustomers.GetRange(3, 2);

            foreach (Customer customer in getRangeOperator)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // RemoveAt() function, removes the item at the specified index in the list.
            listCustomers.RemoveAt(3);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // Remove() function removes only the first matching item from the list.
            listCustomers.Remove(customer4);

            // RemoveAt() function, removes the item at the specified index in the list.
            listCustomers.RemoveAt(0);

            //RemoveAll() function removes all the items that matches the specified condition.
            listCustomers.RemoveAll(x => x.Salary > 5000);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // RemoveRange() method removes a range of elements from the list.
            // This function expects 2 parameters, i.e the start index in the 
            // list and the number of elements to remove.
            //listCustomers.RemoveRange(0, 2);

            // Insert() method allows you to insert a single item at a time into 
            // the list at a specificed index
            listCustomers.Insert(0, customer4);
            listCustomers.Insert(1, customer5);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            // InsertRange() allows you, to insert another list of items to your list at the specified index
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                    customer.Id, customer.Name, customer.Salary);
            }
            Console.WriteLine("------------------------------------------------------");
            
            // If you want to remove all the elements from the list without specifying 
            // any condition, then use Clear() function.
            listCustomers.Clear();
            Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
        }
    }
}
