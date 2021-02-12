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
            newGame.PlayGame();
            newGame.ReturnPlayerScores();
            Console.WriteLine("player one name:" + newGame.playerOne.playerName + " pplayer two name: " + newGame.playerTwo.playerName);
            Console.WriteLine(newGame.roundsRemaining + "rounds remaining.");

            Console.ReadLine();
        }
    }
}
