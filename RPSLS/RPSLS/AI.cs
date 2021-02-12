using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        //member variables
        public int computerChoice;
        public List<int> oneThruFive;
        int ourRandomNumber;
        



        //ctor
        public AI(string playerName)
            :base(playerName)
        {
            this.playerName = playerName;
            computerChoice = 1;
            oneThruFive = new List<int>() { 1, 2, 3, 4, 5 };

        }


        //methods

        // choses 1-5 randomly
        //-- int list
        public void ChooseInteger()
        {
            Random number = new Random();
            ourRandomNumber = number.Next(1, 5);
            computerChoice = ourRandomNumber;

                

        }

        





    }
}
