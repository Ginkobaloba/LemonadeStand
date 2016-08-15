using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        int WeatherConditionInteger;
        string WeatherConditionString;
        double Temperature;
      
        public Weather()
        {
            SetTemperature();
            SetWeatherConditionInteger();
            SetWeatherConditionString();
        }
      public double GetTemperature()
            {

            return this.Temperature;
            }
        public int GetWeatherConditionInteger()
            {
            return this.WeatherConditionInteger;
            }
        public string GetWeatherConditionString()
            {
            return this.WeatherConditionString;
            }
        public void SetWeatherConditionInteger()
            {
            Random random = new Random();
            this.WeatherConditionInteger = random.Next(1, 4);
            }
        public void SetTemperature()
        {
            Random random = new Random();
            this.Temperature = random.Next(1, 55) + 50;
        }
        public void SetWeatherConditionString()
            {
                if (GetWeatherConditionInteger() == 1)
                {
                this.WeatherConditionString = "Sunny & Clear";
                }
                else if (GetWeatherConditionInteger() == 2)
                {
                this.WeatherConditionString = "Overcast";
                }
                else
                {
                this.WeatherConditionString = "Raining";
                }             
            }
    }
}
