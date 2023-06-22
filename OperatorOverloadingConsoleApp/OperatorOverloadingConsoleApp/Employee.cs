using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingConsoleApp
{
    public class Employee
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
                Console.WriteLine("Employee 1 is equal to employee 2.");
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!ReferenceEquals(employee1, employee2))
                Console.WriteLine("Employee1 is not equal to employee2.");
        }

    }
}
