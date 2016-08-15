using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Weather myWeather = new Weather();
        Sugar sugar = new Sugar();
        Player PlayerOne;
        int Days;
        
        public void RunGame()
        {
            this.Introduction();
            sugar.SetSpoilRateSugar(myWeather);
            Console.WriteLine(" Temperature is: {0}",myWeather.GetTemperature());
            Console.WriteLine("The Weather Condition is: {0}",myWeather.GetWeatherConditionString());
            Console.WriteLine(" Sugar Quanity {0} / Price {1}/ SpoilRate {2}", sugar.GetQuanitySugar(),sugar.GetPriceOfSugar(),sugar.GetSpoilRateSugar());
            Console.ReadLine();
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome To Lemonade Stand!");
            Console.ReadLine();
            Console.WriteLine("PlayerOne, What is your name?");
            PlayerOne = new Player(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Thank You {0}", PlayerOne.GetPlayerName());
            Console.ReadLine();
            Console.Clear();
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
            string test = Console.ReadLine();
           if (Console.ReadLine()=="7" || Console.ReadLine()=="14" || Console.ReadLine()=="21")
            {
                Days = int.Parse(Console.ReadLine());
            } 
            else
            {
                int Input;
                do
                {
                    Console.Write("Invalid response. Please type 7, 14 or 21 days");
                    Input = int.Parse(Console.ReadLine());
                }
                while (Input != 7 || Input != 14 || Input != 21);
            }
            
        }
    }
}
