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
        

        //constructor
        public GamePlay()
        {
            
            roundsRemaining = 1;
            turnsRemaining = 3;
        }



        //methods

        public void PlayGame()
        {
            while (roundsRemaining >= 1)
            {
                while (turnsRemaining > 0)
                {
                    //play another round

                    Console.WriteLine(turnsRemaining + "turns remaining");
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
            players = (Console.ReadLine());

            if (players == "1")
            {
                //initialize one AI and one Human player
                Console.WriteLine("Please enter your name");
                string userEntry1 = Console.ReadLine();
                playerOne = new Human(userEntry1);
                Console.WriteLine("Please name the computer player");
                string userEntry2 = Console.ReadLine();
                playerTwo = new AI(userEntry2);


            }
            if (players == "2")
            {
                Console.WriteLine("Please enter your name");
                string userEntry1 = Console.ReadLine();
                playerOne = new Human(userEntry1);

                Console.WriteLine("Please enter your name");
                string userEntry = Console.ReadLine();
                playerTwo = new Human(userEntry);

            }
            else
            {
                Console.WriteLine("Please only choose 1 or 2 players");
                InstantiatePlayers();
            }      

        }

        public void PlayersSelectItems()
        {

        }
    }
        
    
}
