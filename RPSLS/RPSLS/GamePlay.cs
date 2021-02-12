using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        
        public int roundsRemaining;
        
        int turnsRemaining;
        public Player playerOne;
        public Player playerTwo;
        string players;
        Item spok;
        Item rock;
        Item paper;
        Item scisors;
        Item lizard;
        public int playerOneInt;
        public int playerTwoInt;
        
        

        //constructor
        public GamePlay()
        {
            
            roundsRemaining = 1;
            turnsRemaining = 3;
            InstantiateItemsInGame();
            
            
            
        }



        //methods
        public void InstantiateItemsInGame()
        {
            lizard = new Item();
            spok = new Item();
            rock = new Item();
            paper = new Item();
            scisors = new Item();
        }

        public void PlayGame()
        {
            while (roundsRemaining >= 1)
            {
                while (turnsRemaining > 0)
                {
                    //play another round


                    Console.WriteLine(turnsRemaining + "turns remaining");
                    PlayersTurns();
                    turnsRemaining--;
                    Console.WriteLine(turnsRemaining + "turnsRemaining");


                }
                turnsRemaining = 3;
                roundsRemaining = roundsRemaining - 1;
                Console.WriteLine(roundsRemaining + "rounds remaining");

            }
            
               
           
            
            
            
        }


        public void InstantiatePlayers()
        {
            Console.WriteLine("How many people are playing? choose '1' or '2' and press enter");
            string players = (Console.ReadLine());
            int players1 = Convert.ToInt16(players);


            if (players1 == 1)
            {
                //initialize one AI and one Human player
                Console.WriteLine("Please enter your name");
                string userEntry1 = Console.ReadLine();
                playerOne = new Human(userEntry1);
                Console.WriteLine("Please name the computer player");
                string userEntry2 = Console.ReadLine();
                playerTwo = new AI(userEntry2);


            }
            if (players1 == 2)
            {
                Console.WriteLine("Please enter your name");
                string userEntry1 = Console.ReadLine();
                playerOne = new Human(userEntry1);

                Console.WriteLine("Please enter your name");
                string userEntry = Console.ReadLine();
                playerTwo = new Human(userEntry);

            }
            if(players1 == 1 && players1 == 2)
            {
                Console.WriteLine("Please only choose 1 or 2 players");
                InstantiatePlayers();
            }      

        }
        public void ReturnPlayerScores()
        {
            Console.WriteLine("Player one and player two win counts so far");
            playerOne.DisplayTurnWinCount();
            playerTwo.DisplayTurnWinCount();
        }

        public void PlayersTurns()
        {
            //new list in player class for chosen item
            Console.WriteLine("Player one, pleace choose an item from the list. choose 1 for spok, 2 for lizard, 3 for rock, 4 for paper, or 5 for scissors.");
            string input = (Console.ReadLine());
            playerOneInt = Convert.ToInt16(input);




            //choose item
            ChooseItemForPlayerOne();


            //add item to player one item list
            Console.WriteLine("Player one, pleace choose an item from the list. choose 1 for spok, 2 for lizard, 3 for rock, 4 for paper, or 5 for scissors. ");
            string input2 = (Console.ReadLine());
            playerTwoInt = Convert.ToInt16(input2);
            ChooseItemForPlayerTwo();






            Console.WriteLine("Player one, pleace choose an item from the list.");
            

            //choose item

            //AddItemtoturnchoicelist

            


            //use random generator to choose in ai class


            //compare Items in player one turn list and player 2 turn list
            // -------- return bool value for winner
            ///-----------increment win counter in player classes

            //remove items from player one turn choice list

            //remove items from player 2 turn choice list

        }
        public void ChooseItemForPlayerOne()
        {
            if (playerOneInt == 1)
            {
                playerOne.turnChoice.Add(spok);
                Console.WriteLine(playerOne.turnChoice.Count());
            }
            if (playerOneInt == 2)
            {
                playerOne.turnChoice.Add(lizard);
            }
            if (playerOneInt == 3)
            {
                playerOne.turnChoice.Add(rock);
            }
            if (playerOneInt == 4)
            {
                playerOne.turnChoice.Add(paper);
            }
            if (playerOneInt == 5)
            {
                playerOne.turnChoice.Add(scisors);
               
            }
            if(playerOneInt != 1 && playerOneInt != 2 && playerOneInt != 3 && playerOneInt != 4 && playerOneInt != 5)
            {
                Console.WriteLine("scisors will be player one's choice.");
                playerOne.turnChoice.Add(scisors);
            }
        }


        public void ChooseItemForPlayerTwo()
        {
            if (playerTwoInt == 1)
            {
                playerTwo.turnChoice.Add(spok);
                Console.WriteLine(playerTwo.turnChoice.Count());
            }
            if (playerTwoInt == 2)
            {
                playerTwo.turnChoice.Add(lizard);
            }
            if (playerTwoInt == 3)
            {
                playerTwo.turnChoice.Add(rock);
            }
            if (playerTwoInt == 4)
            {
                playerTwo.turnChoice.Add(paper);
            }
            if (playerTwoInt == 5)
            {
                playerTwo.turnChoice.Add(scisors);

            }
            if (playerTwoInt != 1 && playerTwoInt != 2 && playerTwoInt != 3 && playerTwoInt != 4 && playerTwoInt != 5)
            {
                playerTwo.turnChoice.Add(paper);
                Console.WriteLine("paper will be  player two's choice");
            }
        }


    }




}
