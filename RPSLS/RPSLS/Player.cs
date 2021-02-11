using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        int turnWinCounter;
        int RoundWinCounter;
        public string name;

        //ctor

        public Player(string name)
        {
            turnWinCounter = 0;
            RoundWinCounter = 0;
            this.name = name;
        }

        //methods

        public void IncrementTurnWinCounter()
        {
            turnWinCounter += 1;
        }

        public void IncrementRoundWinCounter()
        {
            RoundWinCounter += 1;
        }

        public void ResetTurnWinCounter()
        {
            turnWinCounter = 0;
        }

        public void ResetRoundWinCounter()
        {
            RoundWinCounter = 0;
        }

        public void DisplayRoundWinCount()
        {
            Console.WriteLine(RoundWinCounter);
        }

        public void DisplayTurnWinCount()
        {
            Console.WriteLine(turnWinCounter);
        }
    }
}
