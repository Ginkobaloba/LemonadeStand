﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Recipe recipe;
        Weather[] myWeather;
        Player playerOne;
        Player playerTwo;
        Day day;
        Customer[] customers;
        Store store;
        double buyLevel;
        public Game()
        {

            playerOne = new Player();
            playerTwo = new Player();
            recipe = new Recipe();
            day = new Day(0);
            store = new Store();

        }

        public void RunGame()
        {
            string playAgain;
            this.RunIntroduction();
            this.CreateArrayWeather(day.GetNumberofDays());


            for (int dayNumber = 0; dayNumber < day.GetNumberofDays(); dayNumber++)
            {
                this.CreateCustomerArray(playerOne);
                Console.Clear();
                this.recipe.RunRecipeScreen(playerOne, myWeather, dayNumber);
                this.RunStore(playerOne, myWeather, dayNumber);
                this.SetBuyLevel(playerOne,dayNumber);
                day.RunDay(buyLevel, playerOne, dayNumber, customers, store, myWeather);
                day.EndDay(buyLevel, playerOne, dayNumber, customers, store, myWeather);
                //Two player Modifications need to start here
            }
            Console.WriteLine("Congratulations, You have completed your game.");
            Console.WriteLine("You played for {0} days.",day.GetNumberofDays());
            Console.WriteLine("You ended the game with {0}", playerOne.inventory.GetInventoryMoney());
            Console.WriteLine("Would you like to play again?");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();

            if (playAgain == "yes")
            {
                RunGame();
            }
            else
            {
               for (int A = 0; A < 10000; A++)
                {
                    Console.WriteLine("Thanks for Playing!");
                }
            }
        }
        public void RunIntroduction()
        {
            Console.WriteLine("Welcome To Lemonade Stand! Please press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Hello, What is your name?");
            playerOne.SetPlayerName(Console.ReadLine());
            Console.Clear();
            this.PromptSetPlayerName(playerOne);
            Console.WriteLine("You have 7, 14, or 21 days to make as much money as possible, and you’ve decided to open a lemonade stand!");
            Console.WriteLine("You’ll have complete control over your business, including pricing, quality control, inventory control,");
            Console.WriteLine("and purchasing supplies. Buy your ingredients, set your recipe, and start selling!");
            Console.ReadLine();
            Console.WriteLine("The first thing you’ll have to worry about is your recipe.");
            Console.WriteLine("but try to experiment a little bit and see if you can find a better one. Make sure you buy enough");
            Console.WriteLine("of all your ingredients, or you won’t be able to sell!");
            Console.ReadLine();
            Console.WriteLine("You’ll also have to deal with the weather, which will play a big part when customers are deciding");
            Console.WriteLine("whether or not to buy your lemonade. Read the weather report every day! When the temperature drops,");
            Console.WriteLine("or the weather turns bad (sunny, overcast, raining), don’t expect them to buy nearly as much as they");
            Console.WriteLine("would on a hot, so buy accordingly. Feel free to set your prices higher on those hot,");
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
            Console.WriteLine("Now Loading");
        }
        public void RunStore(Player player, Weather[] myWeather, int day)
        {

            this.store.GetStoreDisplay(player, myWeather, day);
            if (day == 0)
            {
                Console.WriteLine("Welcome to the store From this screen you will be able to purchase all the supplies needed to run your stand");
            }
            else if (day == 1)
            {
                Console.WriteLine("Welcome back! I do hope that your first day was a profitable one!");
            }
            else
            {
                Console.WriteLine("Welcome, you know what to do. Don't forget ice");
            }
            this.store.GetStoreDisplay(player, myWeather, day);
            this.store.PurchaseGroceries(player, myWeather, day);
            this.store.GetStoreDisplay(player, myWeather, day);

        }

        public void PromptSetPlayerName(Player player)
        {
            string answer;
            Console.WriteLine("{0}, is that correct?", player.GetPlayerName());
            answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.Clear();
                Console.WriteLine("Thank You {0}", player.GetPlayerName());
                Console.ReadLine();
                Console.Clear();
            }
            else if (answer.ToLower() == "no")
            {
                Console.Clear();
                Console.WriteLine("What is your name?");
                player.SetPlayerName(Console.ReadLine());
                this.PromptSetPlayerName(player);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry Please Type Yes or No.");
                this.PromptSetPlayerName(player);
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

        public void CreateArrayWeather(int gameLength)
        {
            myWeather = new Weather[gameLength + 1];
            for (int i = 0; i < myWeather.Length; i++)
            {
                myWeather[i] = new Weather();
                Thread.Sleep(200);

            }
        }
        public void CreateCustomerArray(Player player)
        {
            int numberOfCustomers = player.popularity.GetPopularity();
            customers = new Customer[numberOfCustomers];
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers[i] = new Customer("Customer " + (i + 1));
                Thread.Sleep(15);
            }
        }
        public void SetBuyLevel(Player player, int day)
        {
            int weatherFactor;
            int recipeFactor;
            double costfactor;
            costfactor = GetCostFactor(player);
            weatherFactor = GetWeatherFactor(myWeather, day);
            recipeFactor = GetPerfectRecipeFactor(player);
            if (recipeFactor == -5)
            {
                buyLevel = weatherFactor + recipeFactor;
            }
            else
            {
                buyLevel = (weatherFactor + recipeFactor) * costfactor;
            }
            
        }
        public double GetBuyLevel()
        {
            return this.buyLevel;
        }
        public int GetWeatherFactor(Weather[] myWeather, int day)
        {
            int numberToReturn;
            int convertedWeatherNumber;

            convertedWeatherNumber = myWeather[day].GetTemperature();

            if (myWeather[day].GetWeatherConditionInteger() == 1)
            {
                convertedWeatherNumber = convertedWeatherNumber + 10;
            }

            else if (myWeather[day].GetWeatherConditionInteger() == 1)
            {
                convertedWeatherNumber = convertedWeatherNumber - 5;
            }
            else
            {
                convertedWeatherNumber = convertedWeatherNumber - 10;
            }

            if (convertedWeatherNumber > 95)
            {
                numberToReturn = 0;
            }
            else if (convertedWeatherNumber > 80)
            {
                numberToReturn = 1;
            }
            else if (convertedWeatherNumber > 70)
            {
                numberToReturn = 2;
            }
            else if (convertedWeatherNumber > 60)
            {
                numberToReturn = 3;
            }
            else if (convertedWeatherNumber > 50)
            {
                numberToReturn = 4;
            }
            else
            {
                numberToReturn = 5;
            }
            return numberToReturn;
        }

        public int GetPerfectRecipeFactor(Player player)
        {
            int cupVariance;
            int lemonVariance;
            int sugarVariance;
            int iceCubeVariance;
            int totalVariance;

            lemonVariance = Math.Abs(player.inventory.lemons.GetPerfectNumberOfLemons() - player.inventory.lemons.GetNumberOfLemonsInRecipe());
            sugarVariance = Math.Abs(player.inventory.sugar.GetPerfectNumberOfSugar() - player.inventory.sugar.GetNumberOfSugarInRecipe());
            iceCubeVariance = Math.Abs(player.inventory.iceCubes.GetPerfectNumberOfIceCubes() - player.inventory.iceCubes.GetPerfectNumberOfIceCubes());
            cupVariance = player.inventory.paperCups.GetNumberOfCupsInRecipe();
            totalVariance = iceCubeVariance + lemonVariance + sugarVariance;


            if (cupVariance == 10)
            {
                return -5;
            }
            if (totalVariance == 0)
            {
                return -1;
            }
            else if (totalVariance < 2)
            {
                return 0;
            }
            else if (totalVariance < 4)
            {
                return 1;
            }
            else if (totalVariance < 6)
            {
                return 2;
            }
            else if (totalVariance < 8)
            {
                return 3;
            }
            else if (totalVariance < 10)
            {
                return 4;
            }
            else if (totalVariance < 12)
            {
                return 5;
            }
            else if (totalVariance < 14)
            {
                return 6;
            }
            else
            {
                return 7;
            }


        }
        public double GetCostFactor(Player player)
        {
            double price;
            price = player.GetCostOfLemonade();
            // magic numbers represent price points and influence on buyrate
            if (price < .30)
            {
                return .5;
            }
            else if (price < .51)
            {
                return 1;
            }
            else if (price < .99)
            {
                return 1.5;
            }
            else
            {
                return 10;
            }

        }
    }
}



            // Not\Needed but saved for ceiling method(int cupsSold, double MoneyMade)
            //{
            //    double x = Convert.ToDouble(cupsSold);
            //    int pitchersMade = Convert.ToInt32(Math.Ceiling(x / 10));
            //    playerOne.inventory.SetInventoryMoney(MoneyMade);
            //    playerOne.inventory.paperCups.SetQuanityOfCups(cupsSold * -1);
            //    playerOne.inventory.iceCubes.SetQuanityofIceCubes(cupsSold * playerOne.inventory.iceCubes.GetNumberOfCubesInRecipe());

//}