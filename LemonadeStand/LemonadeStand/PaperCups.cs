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

        public PaperCups()
        {
            this.PriceOfPaperCups = .03;
            this.QuanityOfCups = 0;
            this.ChanceOfWetCups = 0;
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
    }
}
