using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);

        }

    }
    public class FullTimeEmployee : Employee
    {
        public float YearlyFullName;
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    public class GetEmployee
    {
        public void GetEmployeeDetails()
        {
            FullTimeEmployee obj = new FullTimeEmployee();
            obj.FirstName = "Jaya";
            obj.LastName = "Kishori";
            obj.Email = "Lucknow";
            obj.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "PartTime";
            partTimeEmployee.LastName = "Employee";
            partTimeEmployee.HourlyRate = 50;
            partTimeEmployee.PrintFullName();
        }


    }

}
