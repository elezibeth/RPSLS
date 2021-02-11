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

            Human me = new Human();
            me.IncrementRoundWinCounter();
            me.DisplayRoundWinCount();
            me.IncrementRoundWinCounter();
            me.DisplayRoundWinCount();
            me.IncrementTurnWinCounter();
            me.IncrementTurnWinCounter();
            me.DisplayTurnWinCount();

            Console.ReadLine();
        }
    }
}
