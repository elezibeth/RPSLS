using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'rock, paper, scissors, lizard, Spok.'" );
            Console.WriteLine();//list rules
           



           
            GamePlay newGame = new GamePlay();
            
            newGame.InstantiatePlayers();
            newGame.PlayersTurns();
            newGame.ReturnPlayerScores();
            
            
            





            Console.ReadLine();
        }
    }
}
