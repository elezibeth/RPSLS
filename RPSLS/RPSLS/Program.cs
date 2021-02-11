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
           



            Human me = new Human("liz");
            me.IncrementRoundWinCounter();
            me.DisplayRoundWinCount();
            me.IncrementRoundWinCounter();
            me.DisplayRoundWinCount();
            me.IncrementTurnWinCounter();
            me.IncrementTurnWinCounter();
            me.DisplayTurnWinCount();
            me.ResetRoundWinCounter();
            me.ResetTurnWinCounter();
            me.DisplayTurnWinCount();
            me.DisplayRoundWinCount();
            GamePlay newGame = new GamePlay();
            newGame.PlayGame();
            newGame.InstantiatePlayers();
            Console.WriteLine("player one name:" + newGame.playerOne.name + " pplayer two name: " + newGame.playerTwo.name);
            Console.WriteLine(newGame.roundsRemaining + "rounds remaining.");

            Console.ReadLine();
        }
    }
}
