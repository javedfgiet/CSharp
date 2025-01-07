using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp
{
    public class Constructors
    {
    }


    /*
     * Default Constructor : A Constructor without having any parameter called default constructor. In this constructor every instance 
     * of the class will be initilaized with any parameter value.
     */
    public class EmployeeCtor
    {
        public EmployeeCtor()
        {

        }

    }


    /*
     * Parametrized Constructor : A Constructor with at least one parameter is called a parametrized constructor.
     * Use : The advantage of a parametrized constructor is that we can initialized the value at the time of creation of object
     * of class.
     * constructor overloading : The Constructor with Diffrent Parameter is known as constructor overloading.
     */

    public class Department
    {
        public Department()
        {
        }
        int _a, _b, _c;
        public Department(int a, int b)
        {
            _a = a;
            _b = b;

        }
        public Department(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public void Print()
        {
            Console.WriteLine("Value of a : {0} & b : {1}", _a, _b);
        }
    }
    public class Get_Department
    {
        public void InitDepartment()
        {
            Department obj = new Department(10, 20);
            obj.Print();

        }

    }

    /*
     * Copy Constructor :   A parameterized constructor that contain parameter of same class type is called as copy ctor.
     */

    public class EmployeeConstructor
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public EmployeeConstructor()
        {

        }
        public EmployeeConstructor(string Name)
        {

        }

        public EmployeeConstructor(EmployeeConstructor emp)
        {

        }
    }

    public class EmployeeMain
    {
        public void GetEmp()
        {
            EmployeeConstructor emp = new EmployeeConstructor();
            emp.fName = "Javed";
            emp.lName = "Ahmad";
            emp.Address = "Lucknow";
            emp.Gender = "Male";
            EmployeeConstructor obj = new EmployeeConstructor(emp);
        }

    }


    /*
     * Private Constructor : A Private constructor is with private access modifier is known as private constructor.
     * 
     * Use / Purpose : It is generally used in classes that contain static member only. it is alo used in Singleton design pattern.
     *  Q: Can we have Private and Default both ctor in Class: NO .
     *  Q: Can we create object of class if we have only private constructor in class: No , Due to Protection label.
     *  Q: Can we inerit the class if we have only Private constructor. : No, Due to Protection label.
     *  
     *  Use and Purpose of private constructor: We use when we have only static member in class, Because when we call the static member
     *  we dont need to create the object of class. we can directly access class member using class.static member.
     */
    public class EmployeePrivate
    {
        private EmployeePrivate()
        {

        }
    }

    /*
     * Static Constructor : A constructor with static keyword is known as static constructor.
     * Use Purpose : Static constructor is used to initialize static data members as soon as the class is referenced the first time, 
     *  whereas an instance constructor is used to create an instance of that class with the <new> keyword. 
     *  A static constructor does not take access modifiers or have parameters and can't access any non-static data member of a class.
     *  
     *        Q: Can we have access modifier in static constructor ?
     *        A : No
     *        
     *        Q: Can we pass parameter in static class ?
     *        A: No, it must be parameter less constructor.
     *        
     *        Q: Howto Or When Static ctor is called ?
     *        A : When we crate first instance of class, static constructor is automatically called.
     *        
     *        Q: How many time static ctor is called :
     *        A: Only once.
     *        
     *        Q: When we create instance of class , which is first constructor called ?
     *        A: FistStatic ctor is called
     */

    class Test
    {
        private static int id;
    //Static constructor, value of data member id is set conditionally here.
    //This type of initialization is not possible at the time of declaration.
    static Test()
    {
        if (Test.id < 10)
        {
            id = 20;
        }
        else
        {
            id = 100;
        }
        Console.WriteLine("Static<Class> Constructor for Class Test1 Called..");
    }
    public static void print()
    {
        Console.WriteLine("Test1.id = " + id);
    }
    //static void Main(string[] args)
    //{
    //    //Print the value of id
    //    Test.print();
    //}
}


    /*
     * Primary Constructor : A Primary Constructor is a new feature in C# 12 that allows you to define and initialize properties 
     * directly within the constructor parameter list.
     * This feature eliminates the need for repeated code and makes your code more concise and readable.
     */
    //public class Employee(string firstName, string lastName, DateTime hireDate, decimal salary)
    //{
    //    public string FirstName { get; init; } = firstName;
    //    public string LastName { get; init; } = lastName;
    //    public DateTime HireDate { get; init; } = hireDate;
    //    public decimal Salary { get; init; } = salary;
    //}
    //var employee = new Employee("John", "Doe", new DateTime(2020, 1, 1), 50000);
}
