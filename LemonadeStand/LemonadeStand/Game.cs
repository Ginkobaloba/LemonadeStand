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
        
        public void RunGame()
        {
            this.Introduction();
            sugar.SetSpoilRateSugar(myWeather);
            Console.WriteLine(" Temperature is: {0}",myWeather.GetTemperature());
            Console.WriteLine("The Weather Condition is: {0}",myWeather.GetWeatherConditionString());
            Console.WriteLine(" Sugar Quanity {0} / Price {1}/ SpoilRate {2}", sugar.GetQuanitySugar(),sugar.GetPriceOfSugar(),sugar.GetSpoilRateSugar());
            Console.ReadLine();
        }


    }
}
