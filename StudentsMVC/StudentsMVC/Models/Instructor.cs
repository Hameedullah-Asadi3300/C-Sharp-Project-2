using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace StudentsMVC.Models
{
    public class Instructor
    {
        //  created a model with three properties and then instantiated an object at "HomeController.cs"
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}