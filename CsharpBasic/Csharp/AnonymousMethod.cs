using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class AnonymousMethod
    {
        public void GetAnonymousMethod()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{EmployeeId=101,FirstName="Raja",LastName="Mohan",Email="Raja@gmail.com"},
                new Employee{EmployeeId=102,FirstName="Manoj",LastName="Singh",Email="manoj@gmail.com"},
                new Employee{EmployeeId=103,FirstName="Hari",LastName="Ram",Email="hari@gmail.com"}

            };

            Predicate<Employee> predicateEmp = new Predicate<Employee>(FindEmployee);
            //Employee employee= employees.Find(emp => FindEmployee(emp));

            //Employee employee = employees.Find(predicateEmp);

            Employee employee = employees.Find(delegate (Employee emp)
            {
                return emp.EmployeeId == 102;
            });
            Console.WriteLine("Id : {0}, Name : {1}",
                employee.EmployeeId,employee.FirstName+employee.LastName);


        }
        public bool FindEmployee(Employee employee)
        {
            return employee.EmployeeId == 102;
            
        }
    }
}
