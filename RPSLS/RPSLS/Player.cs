﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

   abstract class Player
    {


        public int turnWinCounter;
        public int RoundWinCounter;
        public string playerName;
        public List<Item> turnChoice;
        public Item spok;
        public Item rock;

        public Item paper;
        public Item scisors;
        public Item lizard;
        public List<Item> playerListOfItems;
        public int playerInt;


        //ctor

        public Player(string playerName)
        {
            turnWinCounter = 0;
            RoundWinCounter = 0;
            this.playerName = playerName;
            turnChoice = new List<Item>();
            InstantiateItemsInPlayer();
            playerListOfItems = new List<Item>() { spok, rock, paper, scisors, lizard };




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

        public abstract void MakeGesture();

        // abstract method signature



    
        }














    }
        




       

        
    

