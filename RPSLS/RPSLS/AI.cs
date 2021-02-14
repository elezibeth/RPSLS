using System;
using System.Collections.Generic;

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
        public override void MakeGesture()
        {
            ChooseRandomNumber();
            if(ourRandomNumber == 1)
            {
                turnChoice.Add(spok);
                Console.WriteLine(playerName + " has chosen spok.");

            }
            else if (ourRandomNumber == 2)
            {
                turnChoice.Add(rock);
                Console.WriteLine(playerName + " has chosen rock.");

            }
            else if (ourRandomNumber == 3)
            {
                turnChoice.Add(paper);
                Console.WriteLine(playerName + " has chosen paper.");

            }
            else if (ourRandomNumber == 4)
            {
                turnChoice.Add(scisors);
                Console.WriteLine(playerName + " has chosen scisors.");

            }
            else if (ourRandomNumber == 5)
            {
                turnChoice.Add(lizard);
                Console.WriteLine(playerName + " has chosen lizard.");

            }
            Console.WriteLine(turnChoice[0].name + "is the choice of the computer.");



        }

        public void ChooseRandomNumber()
        {
            Random number = new Random();
            ourRandomNumber = number.Next(1, 5);
            computerChoice = ourRandomNumber;


        }







    }
}
