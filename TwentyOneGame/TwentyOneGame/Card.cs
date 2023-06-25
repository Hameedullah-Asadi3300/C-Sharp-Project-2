using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public struct Card
    {
        public Suit Suit {  get; set; }
        public Face Face { get; set; }
        

        public override string ToString ()
        {
            return string.Format("{0} of {1}," Face, Suit);
        }


    }
}
