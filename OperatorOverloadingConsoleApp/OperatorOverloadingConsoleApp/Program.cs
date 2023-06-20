using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  First object of Employee type
            Employee employee1 = new Employee();    //  Object Instantiation 
            employee1.id = 5578;
            employee1.FirstName = "Hameedullah";
            employee1.LastName = "Asadi";


            //  Second Object of Employee type
            Employee employee2 = new Employee();    //  Object Instantiation 
            employee2.id = 6678;
            employee2.FirstName = "Mike";
            employee2.LastName = "Smith";


            Employee employeeResult = employee1 == employee2;
            Console.ReadLine();
        }
    }
}
