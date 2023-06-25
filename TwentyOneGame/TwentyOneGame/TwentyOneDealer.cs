using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneDealer
    {
        private List<Card> _and = new List<Card>();


        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool stay { get; set; }
        public bool isBusted { get; set; }

    }
}
