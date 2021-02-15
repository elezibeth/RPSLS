using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //member variables

        //public int playerInt;
       


        //ctor

        public Human(string playerName)
            :base(playerName)
        {


            Console.WriteLine("you made a human player");
        }

        //methods

        //chooseitemfromlist
        public override void MakeGesture()
        {
            Console.WriteLine("Player " + playerName + ", please choose an item from the list.");
            DisplayListOfItems();
            VerifyInput();

            
            AddItemToTurnChoiceList();

        }
        public void VerifyInput()
        {
           
            string input = (Console.ReadLine());
            if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("try again");
                VerifyInput();
            }
            else
            {
                playerInt = Convert.ToInt32(input);
            }
            
           
            

        }
        public void AddItemToTurnChoiceList()
        {
            if (playerInt == 1)
            {
                turnChoice.Add(spok);
                Console.WriteLine(playerName + " has chosen spok.");

            }
            else if (playerInt == 2)
            {
                turnChoice.Add(rock);
                Console.WriteLine(playerName + " has chosen rock.");

            }
            else if (playerInt == 3)
            {
                turnChoice.Add(paper);
                Console.WriteLine(playerName + " has chosen paper.");

            }
            else if (playerInt == 4)
            {
                turnChoice.Add(scisors);
                Console.WriteLine(playerName + " has chosen scisors.");

            }
            else if (playerInt == 5)
            {
                turnChoice.Add(lizard);
                Console.WriteLine(playerName + " has chosen lizard.");

            }
         

            
        }
        public void DisplayListOfItems()
        {
            foreach (Item item in playerListOfItems)
            {
                int index = playerListOfItems.IndexOf(item);
                int indexNumber = index + 1;
                Console.WriteLine($"{indexNumber} {playerListOfItems[index].name}");
            }
            
        }

        

        



    }
}
