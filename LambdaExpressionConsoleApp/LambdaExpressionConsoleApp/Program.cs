using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Folowing is liat of 10 employees
                //Two of them with the same first name "Joe"
            List<Employee> campus = new List<Employee>();
            {
                new Employee() { ID = 500, FirstName = "Hameedullah", LastName = "Asadi" };
                new Employee() { ID = 501, FirstName = "Carig", LastName = "Bryant" };
                new Employee() { ID = 502, FirstName = "Joe", LastName = "Dong" };
                new Employee() { ID = 503, FirstName = "Justin", LastName = "Dong" };
                new Employee() { ID = 504, FirstName = "Sarah", LastName = "Stofer" };
                new Employee() { ID = 505, FirstName = "Elizabeth", LastName = "Barbara" };
                new Employee() { ID = 506, FirstName = "Joe", LastName = "Adam" };
                new Employee() { ID = 507, FirstName = "Jamil", LastName = "Ahmed" };
                new Employee() { ID = 508, FirstName = "Jamal", LastName = "Abid" };
                new Employee() { ID = 509, FirstName = "Dost", LastName = "Safi" };
            };

            //Using a foreach loop, create a new list of employee with the first name Joe
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }    
        //Do the same thing again, but this time with lambda expression
        List<Employee> joes2 = campus.Where(x => x.FirstName == "Joe").ToList();

        //Using a lambda expression, make a list of all employees with an ID number greater than 5.
        List<Employee> bigID = campus.Where(x => x.ID > 5).ToList();
        Console.ReadLine();
        }
    }
}
