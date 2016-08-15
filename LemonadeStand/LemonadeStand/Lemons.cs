using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemons
    {
        int QuanityOfLemons;
        double SpoilRateOfLemons;
        double PriceOfLemons;

        public Lemons()
        {
            this.QuanityOfLemons = 0;
            this.SpoilRateOfLemons = 0;
            this.PriceOfLemons = .10;
        }
        public void SetPriceOfLemons(double NewPriceOfLemons)
        {
            this.PriceOfLemons = NewPriceOfLemons;
        }
        public void SetSpoilRateOfLemons()
        {

        }
        public void SetQuanityOfLemons(int AmountOfLemonsBought)
        {
            this.QuanityOfLemons = this.QuanityOfLemons + AmountOfLemonsBought;
        }
        public int GetQuanityOfLemons()
        {
            return this.QuanityOfLemons;
        }
        public double GetPriceOfLemons()
        {
            return this.PriceOfLemons;
        }
        public double GetSpoilRateOfLemons()
        {
            return this.SpoilRateOfLemons;
        }
    }
}
