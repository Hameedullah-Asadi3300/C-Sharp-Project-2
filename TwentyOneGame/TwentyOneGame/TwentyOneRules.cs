using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class TwentyOneRules
    {
        //  The naming convenction for private class is to start with _cardValues.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)   //This method returns an integer array of all possible values
        {
            int aceCount = Hand.Count(x => x.Face.Ace == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value = +(i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else
            {
                return false;
            }
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value == 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(list<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        //  This method returns nullable boolean
        public static bool? CompareHands(List<Card> playerHand, List<Card> Dealerhand)
        {
            int[] playerResult = GetAllPossibleHandValues(playerHand);
            int[] dealerResult = GetAllPossibleHandValues(Dealerhand);

            int playerScore = playerResult.Where(x => x < 22).Max();
            int dealerScore = dealerResult.Where(x => x < 22).Max();
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
