using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGameConsoleApp
{
    public class Card
    {
        //Sometimes it is best practice to assign default value to a class upon creation. To do this, we need to create the constructor inside the class file as follows:
        public Card()
        {
            Suit = "Queens";
            Face = "Two";
        } //Bt creating the constructor, if there is not value to the object in main file, the above value is assigned for.
        public string Suit { get; set; }
        public string Face { get; set; }





        public class car
        {
            string color = "red";
            string Make = "Toyota";
            String Model = "Corolla";

        }



    }
}
