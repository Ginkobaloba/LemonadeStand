using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Weather[] myWeather;
        Player playerOne;
        Day day;
        Customer[] customers;
        Store store;
        Popularity popularity;
        public Game()
        {

            playerOne = new Player();
            day = new Day(0);
            store = new Store();
            popularity = new Popularity();

        }

        public void RunGame()
        {
            this.RunIntroduction();
            this.CreateArrayWeather(day.GetNumberofDays());
            for (int i = 0; i < day.GetNumberofDays(); i++)
            {
                this.CreateCustomerArray();
                this.RunStore(i);
                this.RunDay(3);
                ;
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
        public void RunStore(int day)
        {

            this.store.GetStoreDisplay(playerOne, myWeather, day);
            Console.WriteLine("Welcome to the store From this screen you will be able to purchase all the supplies needed to run your stand");
            Console.ReadLine();
            this.store.GetStoreDisplay(playerOne, myWeather, day);
            this.store.PurchaseGroceries(playerOne, myWeather, day);
            this.store.GetStoreDisplay(playerOne, myWeather, day);
        }

        public void RunDay(int MagicNumber)
        {
            int cupsSold;
            double moneyMade;
            moneyMade = 0;
            cupsSold = 0;

            for (int a = 0; a < customers.Length; a++)
            {
                if (customers[a].GetThirstLevel() >= MagicNumber)
                    {
                    Console.WriteLine("{0} bought a cup of lemonade!", customers[a].GetCustomerName());
                    moneyMade = moneyMade + .25;
                    cupsSold = cupsSold + 1;
                    }
                else
                {
                    Console.WriteLine("{0} walked passed without buying.", customers[a].GetCustomerName());
                }
            }
            Console.WriteLine("Today you made {0}", moneyMade);
            popularity.SetPopularity(cupsSold);
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

        public void CreateArrayWeather(int gameLength)
        {
            myWeather = new Weather[gameLength];
            for (int i = 0; i < myWeather.Length; i++)
            {
                myWeather[i] = new Weather();
                Thread.Sleep(200);

            }
        }
        public void CreateCustomerArray()
        {
            int numberOfCustomers = popularity.GetPopularity();
            customers = new Customer[numberOfCustomers];
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers[i] = new Customer("Customer " + (i + 1));
                Thread.Sleep(15);
            }

        }
    }

}



