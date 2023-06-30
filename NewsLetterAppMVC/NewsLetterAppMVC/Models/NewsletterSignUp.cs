using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsLetterAppMVC.Models
{
    public class NewsletterSignUp
    {
        //  This is a model so that we pull iformation from the database and we can map it and then use that as a business object to perform business logic on
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SocialInsuranceNumber { get; set; }
    }
}