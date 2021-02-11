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

        //constructor
        public GamePlay()
        {
            
            roundsRemaining = 3;
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
    }
}
