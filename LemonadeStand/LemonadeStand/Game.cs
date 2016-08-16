﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Weather myWeather;
        Player playerOne;
        Day day;
        Customers[] customers;
        Store store;
        Popularity popularity;
        public Game()
        {
            myWeather = new Weather();
            playerOne = new Player();
            day = new Day(0);
            store = new Store();

        }

        public void RunGame()
        {
            this.RunIntroduction();
            for (int i = 1; i < (day.GetNumberofDays() + 1); i++)
                {
                this.RunStore();
                Console.WriteLine(i);
                }
            Console.ReadLine();
        }

        public void RunIntroduction()
        {
            Console.WriteLine("Welcome To Lemonade Stand!");
            Console.ReadLine();
            Console.WriteLine("Hello, What is your name?");
            playerOne.SetPlayerName(Console.ReadLine());
            Console.Clear();
            this.PromptSetPlayerName();
            Console.WriteLine("You have 7, 14, or 21 days to make as much money as possible, and you’ve decided to open a lemonade stand!");
            Console.WriteLine("You’ll have complete control over your business, including pricing, quality control, inventory control,");
            Console.WriteLine("and purchasing supplies. Buy your ingredients, set your recipe, and start selling!");
            Console.ReadLine();
            Console.WriteLine("The first thing you’ll have to worry about is your recipe. At first, go with the default recipe,");
            Console.WriteLine("but try to experiment a little bit and see if you can find a better one. Make sure you buy enough");
            Console.WriteLine("of all your ingredients, or you won’t be able to sell!");
            Console.ReadLine();
            Console.WriteLine("You’ll also have to deal with the weather, which will play a big part when customers are deciding");
            Console.WriteLine("whether or not to buy your lemonade. Read the weather report every day!When the temperature drops,");
            Console.WriteLine("or the weather turns bad(overcast, cloudy, rain), don’t expect them to buy nearly as much as they");
            Console.WriteLine("would on a hot, hazy day, so buy accordingly.Feel free to set your prices higher on those hot,");
            Console.WriteLine("muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.");
            Console.ReadLine();
            Console.WriteLine("The other major factor which comes into play is your customer’s satisfaction. As you sell your");
            Console.WriteLine("lemonade, people will decide how much they like or dislike it.  This will make your business more");
            Console.WriteLine("or less popular. If your popularity is low, fewer people will want to buy your lemonade, even if the");
            Console.WriteLine("weather is hot and sunny. But if you’re popularity is high, you’ll do okay, even on a rainy day!");
            Console.ReadLine();
            Console.WriteLine("At the end of 7, 14, or 21 days you’ll see how much money you made. Play again,");
            Console.WriteLine("and try to beat your high score!");
            Console.ReadLine();
            Console.WriteLine("How Long would you like to run your Lemonade Stand? 7, 14 or 21 days");
            this.PromptSetNumberOfDays();
            Console.Clear();
            Console.WriteLine("Thank You, You have Selected to play for {0} days.", day.GetNumberofDays());
            Console.ReadLine();
            Console.Clear();
        }
        public void RunStore()
        {
            
            this.store.GetStoreDisplay(playerOne, myWeather);
            Console.WriteLine("Welcome to the store From this screen you will be able to purchase all the supplies needed to run your stand");
            Console.ReadLine();
            this.store.GetStoreDisplay(playerOne, myWeather);

            this.store.PurchaseLemons(playerOne);
        }

        public void PromptSetPlayerName()
        {
            string answer;
            Console.WriteLine("{0}, is that correct?", playerOne.GetPlayerName());
            answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.Clear();
                Console.WriteLine("Thank You {0}", playerOne.GetPlayerName());
                Console.ReadLine();
                Console.Clear();
            }
            else if (answer.ToLower() == "no")
            {
                Console.Clear();
                Console.WriteLine("PlayerOne, What is your name?");
                playerOne.SetPlayerName(Console.ReadLine());
                this.PromptSetPlayerName();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry Please Type Yes or No.");
                this.PromptSetPlayerName();
            }
        }
        public void PromptSetNumberOfDays()
        {
            string NumberOfDays = Console.ReadLine();
            if (NumberOfDays == "7" || NumberOfDays == "14" || NumberOfDays == "21")
            {
                day.SetNumberOfDays(int.Parse(NumberOfDays));

            }
            else
            {
                Console.WriteLine("I'm sorry, but the response you entered was Invalid. Please Choose 7, 14 or 21 days.");
                PromptSetNumberOfDays();
            }
          }

            public void AddCustomers()
            {
             for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customers(); 
            }
        
        }
    }
}
    

