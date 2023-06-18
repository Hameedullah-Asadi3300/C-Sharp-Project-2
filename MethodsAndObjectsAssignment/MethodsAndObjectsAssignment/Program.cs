using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Object of class "Employee" istintiated named "employee"
            employee.FirstName = "Sample";      //First Property
            employee.LastName = "Student";      //Second property

            employee.SayName(); //The superclass method of "person" class called on "Employee" class object
            Console.ReadLine(); //Keeps the console open
        }
    }
}
