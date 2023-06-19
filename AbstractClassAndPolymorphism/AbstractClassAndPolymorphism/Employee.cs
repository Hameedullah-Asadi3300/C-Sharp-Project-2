using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndPolymorphism
{
    public class Employee : Person, IQuittable          //Person class inherited from Employee and and interface named Iquittable too
    {
        public int ID { get; set; }     //Employee class member

        public override void SayName()  //Called the method SayName
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);   //Prints
        }

        public void Quit()  //Calling the Quit method
        {
            Console.WriteLine("The Id od student is " + ID);
        }

    }
}
