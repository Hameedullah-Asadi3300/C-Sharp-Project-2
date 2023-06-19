using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiated an object of class "Employee"
            employee.firstName = "Sample";      //First Property of the employee object
            employee.lastName = "Student";      //Second property of the employee object 
            employee.SayName();         //Calling the "SayName" method on object of class "Employee"
            Console.ReadLine();

            IQuittable quittable = new Employee();  //Here the Employee object morphed to Iquittable

        }
    }
}
