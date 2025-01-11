using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate bool isPromotable(Student student);
    public class DelegateExample
    {
        public void Print()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ram", Salary = 50000, Experience = 5 });
            students.Add(new Student() { Id = 2, Name = "Man", Salary = 60000, Experience = 4 });
            students.Add(new Student() { Id = 3, Name = "Mike", Salary = 65000, Experience = 6 });
            students.Add(new Student() { Id = 4, Name = "Jack", Salary = 75000, Experience = 7 });

            isPromotable promote = new isPromotable(Promote);

            Student obj = new Student();
            obj.PromoteStudent(students, promote);

        }

        public bool Promote(Student student)
        {
            if (student.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PromoteStudent(IList<Student> students, isPromotable isEligibleToPromote)
        {
            foreach (Student student in students)
            {
                if (isEligibleToPromote(student))
                {
                    Console.WriteLine(student.Name + "  - Promoted");
                }
            }
        }
    }
}
