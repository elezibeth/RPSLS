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
        Item scissors;
        Item lizard;
        public int playerOneInt;
        public int playerTwoInt;
        public string name;
        
        

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
            lizard = new Item("lizard");
            spok = new Item("spok");
            rock = new Item("rock");
            paper = new Item("paper");
            scissors = new Item("scissors");
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
            ChooseItemForPlayerOne();
            Console.WriteLine("Player two, pleace choose an item from the list. choose 1 for spok, 2 for lizard, 3 for rock, 4 for paper, or 5 for scissors. ");
            string input2 = (Console.ReadLine());
            playerTwoInt = Convert.ToInt16(input2);
            ChooseItemForPlayerTwo();
            //use random generator to choose in ai class
            foreach (Item x in playerOne.turnChoice)
            {
                Console.WriteLine(x.name + " is the choice of player one.");
            }
            foreach (Item x in playerTwo.turnChoice)
            {
                Console.WriteLine(x.name + " is the choice of player 2.");
            }


            //compare Items in player one turn list and player 2 turn list
            ScorePlayers();
         
         

            //remove items from player one turn choice list
            playerOne.turnChoice.RemoveAt(0);
            playerTwo.turnChoice.RemoveAt(0);


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
                playerOne.turnChoice.Add(scissors);
               
            }
            if(playerOneInt != 1 && playerOneInt != 2 && playerOneInt != 3 && playerOneInt != 4 && playerOneInt != 5)
            {
                Console.WriteLine("scisors will be player one's choice.");
                playerOne.turnChoice.Add(scissors);
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
                playerTwo.turnChoice.Add(scissors);

            }
            if (playerTwoInt != 1 && playerTwoInt != 2 && playerTwoInt != 3 && playerTwoInt != 4 && playerTwoInt != 5)
            {
                playerTwo.turnChoice.Add(paper);
                Console.WriteLine("paper will be  player two's choice");
            }
        }

        // new method, 
        //compare items at playerOne.list[0] and playertwo.list[0], 

        public void ScorePlayers()
        {
            

            string playerUno = playerOne.turnChoice[0].name;
            string playerDos = playerTwo.turnChoice[0].name;
            Console.WriteLine(playerUno);
            Console.WriteLine(playerDos);


            //            Rock crushes Scissors

            switch (playerUno)
            {
                case "scissors":
                    if(playerDos == "rock")
                    {
                        Console.WriteLine("rock crushes scissors");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "paper")
                    {
                        Console.WriteLine("Scissors cut paper");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "scisors")
                    {
                        Console.WriteLine("Scissors cut paper");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "lizard")
                    {
                        Console.WriteLine("Scissors decapitate lizard");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "spok")
                    {
                        Console.WriteLine("Spok smashes scissors");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                case "paper":
                    if (playerDos == "rock")
                    {
                        Console.WriteLine("Paper Covers Rock");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "paper")
                    {
                        Console.WriteLine("Try again");
                        turnsRemaining++;
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "scisors")
                    {
                        Console.WriteLine("Scissors cut paper");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "lizard")
                    {
                        Console.WriteLine("Lizard eats paper");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "spok")
                    {
                        Console.WriteLine("Paper disproves Spok");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                case "rock":
                    if (playerDos == "rock")
                    {
                        Console.WriteLine("try again");
                        turnsRemaining++;
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "paper")
                    {
                        Console.WriteLine("Papaer covers rock");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "scisors")
                    {
                        Console.WriteLine("Rock smashes scissors ");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "lizard")
                    {
                        Console.WriteLine("Rock crushes lizard");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "spok")
                    {
                        Console.WriteLine("Spok vaporizes rock");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;

                case "lizard":
                    if (playerDos == "rock")
                    {
                        Console.WriteLine("Rock crushes lizard");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "paper")
                    {
                        Console.WriteLine("Lizard eats paper");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "scisors")
                    {
                        Console.WriteLine("Scissors decapitate lizard");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "lizard")
                    {
                        Console.WriteLine("Try again");
                        turnsRemaining++;
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "spok")
                    {
                        Console.WriteLine("Lizard poisons Spok");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;

                case "spok":
                    if (playerDos == "rock")
                    {
                        Console.WriteLine("Spok vaporizes Rock");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "paper")
                    {
                        Console.WriteLine("Paper disproves Spok");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "scisors")
                    {
                        Console.WriteLine("Spok smashes scisors");
                        playerOne.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "lizard")
                    {
                        Console.WriteLine("lizard poisons spok");
                        playerTwo.IncrementTurnWinCounter();
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;
                    if (playerDos == "spok")
                    {
                        Console.WriteLine("Try Again");
                        turnsRemaining++;
                        playerOne.DisplayTurnWinCount();
                        playerTwo.DisplayTurnWinCount();
                    }
                    break;

               


            }

            
            //Scissors cuts Paper
            //Paper covers Rock
            //Rock crushes Lizard
            //Lizard poisons Spock
            //Spock smashes Scissors
            //Scissors decapitates Lizard
            //Lizard eats Paper
            //Paper disproves Spock
            //Spock vaporizes Rock

            //            Rock crushes Scissors
            //Scissors cuts Paper
            //Paper covers Rock
            //Rock crushes Lizard
            //Lizard poisons Spock
            //Spock smashes Scissors
            //Scissors decapitates Lizard
            //Lizard eats Paper
            //Paper disproves Spock
            //Spock vaporizes Rock













        }


        // make variable to hold bool statuses for player one and player 2,
        //for true, increase point counter in player class




    }




}
