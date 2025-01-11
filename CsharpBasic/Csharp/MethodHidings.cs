using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class EmployeeM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployeeM : EmployeeM
    {
        public new void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }

    }

    public class FullTimeEmployeeM : EmployeeM
    {

    }

    public class GetEmp
    {
        public void MethodHide()
        {
            FullTimeEmployeeM fullTime=new FullTimeEmployeeM();
            fullTime.FirstName = "FullTime";
            fullTime.LastName = "Employee";
            fullTime.Print(); // This will call base class method Print


            PartTimeEmployeeM partTime = new PartTimeEmployeeM();
            partTime.FirstName = "PartTime";
            partTime.LastName = "Employee";
            partTime.Print(); // This will call derived class method.

            ((EmployeeM)partTime).Print(); // This Will call base class method

            EmployeeM obj = new PartTimeEmployeeM();
            obj.FirstName = "FullTime";
            obj.LastName = "Employee";
            obj.Print(); // This will call base class methos

        
        }




    }
}
