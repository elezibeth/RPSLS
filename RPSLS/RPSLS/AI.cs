﻿using System;
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
            
            turnChoice.Add(playerListOfItems[ourRandomNumber - 1]);
            Console.WriteLine($"{playerName} has chosen {playerListOfItems[ourRandomNumber - 1].name}.");

            //if (ourRandomNumber == 1)
            //{
            //    turnChoice.Add(spok);
            //    Console.WriteLine(playerName + " has chosen spok.");

            //}
            //else if (ourRandomNumber == 2)
            //{
            //    turnChoice.Add(rock);
            //    Console.WriteLine(playerName + " has chosen rock.");

            //}
            //else if (ourRandomNumber == 3)
            //{
            //    turnChoice.Add(paper);
            //    Console.WriteLine(playerName + " has chosen paper.");

            //}
            //else if (ourRandomNumber == 4)
            //{
            //    turnChoice.Add(scisors);
            //    Console.WriteLine(playerName + " has chosen rock.");

            //}
            //else if (ourRandomNumber == 5)
            //{
            //    turnChoice.Add(lizard);
            //    Console.WriteLine(playerName + " has chosen lizard.");

            //}

            DisplayPlayerList();


        }

        public void ChooseRandomNumber()
        {
            Random number = new Random();
            ourRandomNumber = number.Next(1, 5);
            computerChoice = ourRandomNumber;


        }
        public void DisplayPlayerList()
        {
            foreach(Item item in turnChoice)
            {
                
                Console.WriteLine($"turn choice is stored at the index : " +
                    $"{turnChoice.IndexOf(item)}");
            }
        }






    }
}
