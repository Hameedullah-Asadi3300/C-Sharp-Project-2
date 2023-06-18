using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceConsoleApp
{
    public class TwentyOneGame : Game //Here the TwentyOneGame inhereted from Gamr class. To Inherit write the class name followed by ":" and then child class
    {                                   //And this inhereted class has access to all the properties in parent class.
                                        //With inheritence we do not need to repeat and repeat the code in related class
        public void play()   //This is the method which is specific only to the "TwentyOneGame" class not the "Game" class
        {
            throw new NotImplementedException();  //This statement makes sure that this method is not called
                                                    //This is a precaution measure so it is not accidently called 

        }

    }
}
