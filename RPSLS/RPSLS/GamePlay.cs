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
        
        
        public Player playerOne;
        public Player playerTwo;
        string players;
      
        public int playerOneInt;
        public int playerTwoInt;
        public string name;
        public int players1;
        
        

        //constructor
        public GamePlay()
        {
            
            roundsRemaining = 1;
            
            //InstantiateItemsInGame();
            
            
            
        }



      

        public void PlayGame()
        {
            PlayersTurns();
        }
       


        
            
               
           
            
            
            
        
        public void VerifyPlayerInput()
        {
            Console.WriteLine("How many people are playing? choose '1' or '2' and press enter");
            string players = (Console.ReadLine());
            if(players != "1" && players != "2")
            {
                Console.WriteLine("try again.");
                VerifyPlayerInput();
            }
            else
            {
                players1 = Convert.ToInt16(players);
            }
           

        }


        public void InstantiatePlayers()
        {
            VerifyPlayerInput();
        


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
            if(players1 != 1 && players1 != 2)
            {
                Console.WriteLine("Please only choose 1 or 2 players");
                InstantiatePlayers();
            }      

        }
        public void ReturnPlayerScores()
        {
            Console.WriteLine($"{playerOne.playerName} score:   {playerOne.turnWinCounter}  {playerTwo.playerName} score:   {playerTwo.turnWinCounter}");
          
        }

        public void PlayersTurns()
        {
            playerOne.MakeGesture();
            playerTwo.MakeGesture();
            ScorePlayers();
            ClearPlayLists();
            ReturnPlayerScores();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            EndGame();
        }
        public void ClearPlayLists()
        {
            playerOne.turnChoice.Remove(playerOne.turnChoice[0]);
            playerTwo.turnChoice.Remove(playerTwo.turnChoice[0]);
         
        }

        public void DisplayTurnChoices()
        {
            foreach (Item x in playerOne.turnChoice)
            {
                Console.WriteLine(x.name + " is the choice of player one.");
            }
            foreach (Item x in playerTwo.turnChoice)
            {
                Console.WriteLine(x.name + " is the choice of player 2.");
            }
        }


        public void ScorePlayers()
        {
       
            
            switch (playerOne.turnChoice[0].name)
            {
                case "lizard":
                    
                    switch (playerTwo.turnChoice[0].name)
                    {
                        case "lizard":
                            Console.WriteLine("try again");
                            
                            playerOne.turnChoice.Remove(playerOne.turnChoice[0]);
                            playerTwo.turnChoice.Remove(playerTwo.turnChoice[0]);
                           
                            break;
                        case "rock":
                            Console.WriteLine("Rock crushes lizard");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "paper":
                            Console.WriteLine("Lizard eats paper");
                            playerOne.turnWinCounter += 1;
                            break;
                        case "scisors":
                            Console.WriteLine("Scisors decapitate lizard");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "spok":
                            Console.WriteLine("Lizard Poisons Spok");
                            playerOne.turnWinCounter += 1;
                            break;

                    }
                   

                    break;
                case "rock":
                    
                    switch (playerTwo.turnChoice[0].name)
                    {
                        case "lizard":
                            Console.WriteLine("Rock crushes lizard");
                            playerOne.turnWinCounter += 1;
                            

                            break;
                        case "rock":
                            Console.WriteLine("Try Again");
                            
                            
                            break;
                        case "paper":
                            Console.WriteLine("Paper covers Rock");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "scisors":
                            Console.WriteLine("Rock crushes Scisors");
                            playerOne.turnWinCounter += 1;
                            break;
                        case "spok":
                            Console.WriteLine("Spok vaporizes rock");
                            playerTwo.turnWinCounter += 1;
                            break;

                    }
                  
                    break;
                case "paper":
                    
                    switch (playerTwo.turnChoice[0].name)
                    {
                        case "lizard":
                            Console.WriteLine("Lizard eats paper");
                            playerTwo.turnWinCounter += 1;
                            

                            break;
                        case "paper":
                            Console.WriteLine("Try Again");
                            

                            break;
                        case "rock":
                            Console.WriteLine("Paper covers Rock");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "scisors":
                            Console.WriteLine("Scisors cuts paper");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "spok":
                            Console.WriteLine("Paper disproves Spok");
                            playerOne.turnWinCounter += 1;
                            break;

                    }
                   
                    break;
                case "scisors":
                    
                    switch (playerTwo.turnChoice[0].name)
                    {
                        case "lizard":
                            Console.WriteLine("Scisors decapitate lizard");
                            playerOne.turnWinCounter += 1;


                            break;
                        case "rock":
                            Console.WriteLine("rock smashes scisors");
                            playerTwo.turnWinCounter += 1;


                            break;
                        case "paper":
                            Console.WriteLine("scisors cut paper");
                            playerOne.turnWinCounter += 1;
                            break;
                        case "scisors":
                            Console.WriteLine("try again");
                            
                            break;
                        case "spok":
                            Console.WriteLine("Spok smashes scisors");
                            playerTwo.turnWinCounter += 1;
                            break;

                    }
                    break;
                case "spok":
                    
                    switch (playerTwo.turnChoice[0].name)
                    {
                        case "lizard":
                            Console.WriteLine("Lizard poisons spok");
                            playerTwo.turnWinCounter += 1;


                            break;
                        case "rock":
                            Console.WriteLine("Spok Vaporizes rock");
                            playerOne.turnWinCounter += 1;



                            break;
                        case "paper":
                            Console.WriteLine("Paper disproves Spok");
                            playerTwo.turnWinCounter += 1;
                            break;
                        case "scisors":
                            Console.WriteLine("Spock smashes scisors");
                            playerOne.turnWinCounter += 1;
                            break;
                        case "spok":
                            Console.WriteLine("try again");
                            
                            break;

                    }
                    break;


            }





        }

        public void EndGame()
        {
            if (playerOne.turnWinCounter >= 3 && playerTwo.turnWinCounter <= 3)
            {
                Console.WriteLine($"{playerOne.playerName} wins!");
                playerOne.RoundWinCounter += 1;
            }
            else if(playerTwo.turnWinCounter >= 3 && playerOne.turnWinCounter <= 3)
            {
                Console.WriteLine($"{playerTwo.playerName} wins!");
                playerTwo.RoundWinCounter += 1;

            }
            else
            {
                PlayersTurns();
            }
        }
       
            
                
            
        
        













}


    




}





