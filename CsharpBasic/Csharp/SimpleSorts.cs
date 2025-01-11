using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class SimpleSorts
    {
        public void Get_SimpleSorts()
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers After sorting");
            numbers.Sort();
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            // Use Reverse() method to retrieve data in descending order
            Console.WriteLine();
            Console.WriteLine("Numbers in descending order");
            numbers.Reverse();

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            Console.WriteLine();
            Console.WriteLine("Alphabets before sorting");

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }
            alphabets.Sort();
            Console.WriteLine();
            Console.WriteLine("Alphabets after sorting");

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

            alphabets.Reverse();
            Console.WriteLine();
            Console.WriteLine("Alpabets in descending order");

            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet + " ");
            }

        }

        public void Get_CustomerSort()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 4000
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Customers before sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            // Invoking Sort() on list of complex types will
            // throw invalid operation exception, unless 
            // IComparable interface is implemented
            listCustomers.Sort(new sortByName());

            Console.WriteLine("Customers after sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            // Sort using Lambda expesion
            listCustomers.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name);
            });

            var listReadOnly = listCustomers.AsReadOnly();

            

        }
    }

    public class sortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
