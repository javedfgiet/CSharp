using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>
            {
                new Employee(){EmployeeId=1,FirstName="Ram",LastName="Singh",Email="ram@gmail.com"},
                new Employee(){EmployeeId=2,FirstName="Raja", LastName="Yadav",Email="raja@gmail.com"},
                new Employee(){EmployeeId=3,FirstName="Mary",LastName="Rose",Email="mary@gmail.com" }

            };

        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).FirstName;
            }
            set
            {
                listEmployees.FirstOrDefault(x => x.EmployeeId == employeeId).FirstName = value;
            }

        }
    }

    public class Indexers
    {
        public void Get_Indexers()
        {
            Company company = new Company();
            Console.WriteLine(company[2]);
        }
    }
}
