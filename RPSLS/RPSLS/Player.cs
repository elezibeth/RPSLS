using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        int turnWinCounter;
        int RoundWinCounter;
        public string playerName;
        public List<Item> turnChoice;
        public Item spok;
        public Item rock;
        
        public Item paper;
        public Item scisors;
        public Item lizard;
        List<Item> playerListOfItems;
        

        //ctor

        public Player(string playerName)
        {
            turnWinCounter = 0;
            RoundWinCounter = 0;
            this.playerName = playerName;
            turnChoice = new List<Item>();
            InstantiateItemsInPlayer();
           


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
        
      
        public void IncrementTurnWinCounter()
        {
            turnWinCounter += 1;
            Console.WriteLine(turnWinCounter);
        }

        public void IncrementRoundWinCounter()
        {
            RoundWinCounter += 1;
        }

        public void ResetTurnWinCounter()
        {
            turnWinCounter = 0;
        }

        public void ResetRoundWinCounter()
        {
            RoundWinCounter = 0;
        }

        public void DisplayRoundWinCount()
        {
            Console.WriteLine(RoundWinCounter);
        }

        public void DisplayTurnWinCount()
        {
            Console.WriteLine("this player's turn win count is: " + turnWinCounter);
        }
        public void AddItemToTurnChoiceList(Item item)
        {
            turnChoice.Add(item);
        }

        public void RemoveItemFromTurnChoiceList(Item item)
        {
            turnChoice.Remove(item);
        }

       

        
    }
}
