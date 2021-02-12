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
        public string name;
        public List<Item> turnChoice;
        public Item spok;
        public Item rock;
        
        public Item paper;
        public Item scisors;
        public Item lizard;
        List<Item> playerListOfItems;

        //ctor

        public Player(string name)
        {
            turnWinCounter = 0;
            RoundWinCounter = 0;
            this.name = name;
            turnChoice = new List<Item>();
            InstantiateItemsInPlayer();
           


        }

        //methods
        public void InstantiateItemsInPlayer()
        {
            lizard = new Item();
            spok = new Item();
            rock = new Item();
            paper = new Item();
            scisors = new Item();
        }
        
      
        public void IncrementTurnWinCounter()
        {
            turnWinCounter += 1;
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
            Console.WriteLine(turnWinCounter);
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
