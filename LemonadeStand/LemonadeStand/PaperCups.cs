using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class PaperCups
    {
        double PriceOfPaperCups;
        double ChanceOfWetCups;
        int QuanityOfCups;
        int NumberOfCupsInRecipe;
        int perfectNumberOfCups;
        public PaperCups()
        {
            this.PriceOfPaperCups = .03;
            this.QuanityOfCups = 0;
            this.ChanceOfWetCups = 0;
            this.NumberOfCupsInRecipe = 1;
            this.perfectNumberOfCups = 10;
        }
        public void SetPriceOfPaperCups(double NewPriceOfPaperCups)
        {
            this.PriceOfPaperCups = NewPriceOfPaperCups;
        }
        public void SetQuanityOfCups(int AmountOfCupsBought)
        {
            this.QuanityOfCups = this.QuanityOfCups + AmountOfCupsBought;
        }
        public void SetChanceOfWetCups(Weather weather)
        {
            if (weather.GetWeatherConditionInteger() == 3)
            {
                this.ChanceOfWetCups = 33;
            }
            else
            {
                this.ChanceOfWetCups = 0;
            }
        }
        public double GetPriceOfPaperCups()
        {
            return this.PriceOfPaperCups;
        }
        public double GetChanceOfWetCups()
        {
            return this.ChanceOfWetCups;
        }
        public int GetQuanityOfCups()
        {
            return this.QuanityOfCups;
        }
        public int GetNumberOfCupsInRecipe()
        {
            return this.NumberOfCupsInRecipe;
        }
        public void SetNumberOfCupsInRecipe(int NewNumberOfCups)
        {
            this.NumberOfCupsInRecipe = NewNumberOfCups;
        }
        public void SetPerfectNumberOfCups(int newPerfectNumber)
        {
            this.perfectNumberOfCups = newPerfectNumber;
        }
        public  int GetPerfectNumberOfCups()
        {
            return this.perfectNumberOfCups;
        }
    }
}
