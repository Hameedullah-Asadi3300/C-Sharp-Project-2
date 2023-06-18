using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Employee : Person  //Employee class in inhereted from "Person" class and has access to all properties of parent class
    {
        public int ID { get; set; }         //This class has only one property named "ID"
    }
}
