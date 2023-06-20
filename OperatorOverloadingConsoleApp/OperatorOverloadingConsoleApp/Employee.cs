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


        public static Employee operator ==(Employee employee1, Employee employee2)
        {
            Employee employeeResult = new Employee(employee1.id == employee2.id);
            return employeeResult;
        }

    }
}
