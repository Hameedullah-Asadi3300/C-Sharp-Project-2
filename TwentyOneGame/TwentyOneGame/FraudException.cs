using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class FraudException : Exception         //  The FraudException inherited from Exception
    {
        //  This class is created specifically for exception handling. We are creating two methods.
        public FraudException()   
            : base () { }
            
        //Second method. These two methods do exact the same job as Exception does.

            public FraudException(string message)
                : base (message) { }
        





    }
}
