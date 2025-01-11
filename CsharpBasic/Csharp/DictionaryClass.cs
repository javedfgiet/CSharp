using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class DictionaryClass
    {
        Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();
        public DictionaryClass()
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

            dictionary.Add(C1.Id, C1);
            dictionary.Add(C2.Id, C2);
            dictionary.Add(C3.Id, C3);

        }

        public void Print_Dictionary()
        {
            //Console.WriteLine("Customer 1 in customer dictionary");
            //Customer C1 = dictionary[1];
            //Console.WriteLine("ID : {0} , Name : {1}, Salary : {2}", C1.Id, C1.Name, C1.Salary);

            Console.WriteLine("All Customers Keys and Values in Customer dictionary");

            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                //Console.WriteLine(kvp.Key.ToString());

                Customer cust=kvp.Value;
                Console.WriteLine("ID : {0} , Name : {1}, Salary : {2}", cust.Id, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");
            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the values in the dictionary
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (Customer customer in dictionary.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.Id, customer.Name, customer.Salary);
            }

            // If you try to add a key that already exists in the dictionary you 
            // will get an exception - An item with same key has already been 
            // added. So, check if the key already exists
            Customer c2 = new Customer() { Id = 4, Name = "Java", Salary = 6000 };

            if(!dictionary.ContainsKey(1))
            {
                dictionary.Add(c2.Id, c2);

            }

            // When accessing a dictionary value by key, make sure the dictionary 
            // contains the key, otherwise you will get KeyNotFound exception.
            if (dictionary.ContainsKey(110))
            {
                Customer cus = dictionary[110];
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }

        }

        public void Get_DictionaryMethod()
        {
            // If you are not sure if a key is present or not, you can use 
            // TryGetValue() method to get the value from a dictionary.

            Customer customer999;
            if (dictionary.TryGetValue(1, out customer999))
            {

                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", 
                    customer999.Id, customer999.Name, customer999.Salary);
            }
            else
            {
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary");
                Console.WriteLine("-------------------------------------------------------------------");
            }

            // To find the total number of items in a dictionary use Count() method
            Console.WriteLine("Total items in Dictionary = {0}", dictionary.Count());

            Console.WriteLine("-------------------------------------------------------------------");

            // LINQ extension methods can be used with Dictionary. For example, to find the 
            // total employees whose salary is greater than 5000.
            Console.WriteLine("Items in dictionary where Salary is greater than 5000 = {0}",
                dictionary.Count(x => x.Value.Salary > 5000));

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

