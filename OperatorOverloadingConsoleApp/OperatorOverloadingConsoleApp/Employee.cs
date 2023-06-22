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

        //The first method of bool data type
        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //The overloaded method in pair
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!ReferenceEquals(employee1, employee2))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

    }
}
