using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

   abstract class Player
    {


        public int turnWinCounter;
        public int RoundWinCounter;
        public string playerName;
        public List<Item> turnChoice;
        public Item spok;
        public Item rock;

        public Item paper;
        public Item scisors;
        public Item lizard;
        public List<Item> playerListOfItems;
        public int playerInt;


        //ctor

        public Player(string playerName)
        {
            turnWinCounter = 0;
            RoundWinCounter = 0;
            this.playerName = playerName;
            turnChoice = new List<Item>();
            InstantiateItemsInPlayer();
            playerListOfItems = new List<Item>() { spok, rock, paper, scisors, lizard };




        }



        //methods
        public void InstantiateItemsInPlayer()
        {
            lizard = new Item("lizard");
            spok = new Item("spok");
            rock = new Item("rock");
            paper = new Item("paper");
            scisors = new Item("scisors");
        }

        public abstract void MakeGesture();

        // abstract method signature



        public void IncrementTurnWinCounter()
        {
            turnWinCounter += 1;
            Console.WriteLine(turnWinCounter);
        }

        //public void ChooseItemForPlayer()
        //{
        //    if (playerInt == 1)
        //    {
        //        player.turnChoice.Add(spok);
        //        Console.WriteLine(playerTwo.turnChoice.Count());
        //    }
        //    if (playerInt == 2)
        //    {
        //        playerTwo.turnChoice.Add(playerTwo.lizard);
        //    }
        //    if (playerInt == 3)
        //    {
        //        playerTwo.turnChoice.Add(playerTwo.rock);
        //    }
        //    if (playerInt == 4)
        //    {
        //        playerTwo.turnChoice.Add(playerTwo.paper);
        //    }
        //    if (playerInt == 5)
        //    {
        //        playerTwo.turnChoice.Add(playerTwo.scisors);

        //    }
        //    if (playerInt != 1 && playerTwoInt != 2 && playerTwoInt != 3 && playerTwoInt != 4 && playerTwoInt != 5)
        //    {
        //        playerTwo.turnChoice.Add(playerTwo.spok);
        //        Console.WriteLine("Spok will be  player two's choice");
        //    }
        }














    }
        




       

        
    

