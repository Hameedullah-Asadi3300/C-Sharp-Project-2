using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpMVC.Models
{
    public class User
    {
        //  Created a class/Model to be passed to the view
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public int age { get; set; }

    }
}