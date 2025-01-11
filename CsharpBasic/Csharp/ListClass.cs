using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp
{
    public class ListClass
    {
        List<Customer> listCustomers = new List<Customer>(2);
        public ListClass()
        {
            Customer C1 = new Customer()
            {
                Id = 1,
                Name = "Mark",
                Salary = 15000
            };

            Customer C2 = new Customer()
            {
                Id = 2,
                Name = "Jack",
                Salary = 25000
            };

            Customer C3 = new Customer()
            {
                Id = 3,
                Name = "Maris",
                Salary = 50000
            };

            // To add an element to the list, use Add() method.
            listCustomers.Add(C1);
            listCustomers.Add(C2);
            listCustomers.Add(C3);
        }

        public void Get_ListMethod()
        {
            //Contain Method. : Use this function to check if an item exist in the lis.
            //This method returns trueif the item exist  else false.
            Customer C4 = new Customer()
            {
                Id = 1,
                Name = "Mark",
                Salary = 15000
            };

            Console.WriteLine("Does Customer C4 exist in the List : {0}", listCustomers.Contains(C4));

            Console.WriteLine("Does Customer C4 exist in the List : {0}",
                listCustomers.Contains(C4, new CustomerComparer()));


            // To check if an item exists in the list based on a condition, then use Exists() function
            // This method returns true if the items exists, else false

            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("Customer with Name M exist is List");
            }
            else
            {
                Console.WriteLine("No Customer with Name M exist is List");
            }

            // Find() method searches for an element that matches the conditions defined by
            // the specified lambda expression and returns the first matching item from the list

            Customer cust = listCustomers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);


            Console.WriteLine("------------------------------------------------------");

            // FindLast() method searches for an element that matches the conditions defined
            // by the specified lambda expression and returns the Last matching item from the list
            Customer lastMatch = listCustomers.FindLast(customer => customer.Salary > 5000);

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", lastMatch.Id, lastMatch.Name, lastMatch.Salary);

            Console.WriteLine("------------------------------------------------------");

            // FindAll() method returns all the items from the list that
            // match the conditions specified by the lambda expression
            List<Customer> filteredCustomers = listCustomers.FindAll(customer => customer.Salary > 5000);
            foreach (Customer cstmr in filteredCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.Id, cstmr.Name, cstmr.Salary);
            }
            Console.WriteLine("------------------------------------------------------");


            // FindIndex() method returns the index of the first item, that matches the 
            // condition specified by the lambda expression. There are 2 other overloads
            // of this method which allows us to specify the range of elements to 
            // search, with in the list.
            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 =" +
                listCustomers.FindIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");

            // FindLastIndex() method returns the index of the last item, 
            // that matches the condition specified by the lambda expression. 
            // There are 2 other overloads of this method which allows us to specify 
            // the range of elements to search, with in the list.
            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = " +
                listCustomers.FindLastIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");



        }
    }

    public class CustomerComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            if (x.Id == y.Id && x.Name == y.Name && x.Salary == y.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Customer obj)
        {
            return obj.GetHashCode();
        }
    }
}
