using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndPolymorphism
{
    public abstract class Person        //  Created an abstract class named person
    {
        public string firstName { get; set; }   //  Class member
        public string lastName { get; set; }    //  Class member

        public abstract void SayName();         //  Creted a method called SayName
       
    }
}
