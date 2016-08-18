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
        int NumberOfLemonsInRecipe;
        int PerfectNumberOfLemons;

        public Lemons()
        {
            this.PerfectNumberOfLemons = 4;
            this.QuanityOfLemons = 0;
            this.SpoilRateOfLemons = 0;
            this.PriceOfLemons = .10;
            this.NumberOfLemonsInRecipe = 2;
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
        public int GetNumberOfLemonsInRecipe()
        {
            return this.NumberOfLemonsInRecipe;
        }
        public void SetNumberOfLemonsInRecipe(int newNumberOfLemons)
        {
            this.NumberOfLemonsInRecipe = newNumberOfLemons;
        }
        public void SetPerfectNumberofLemons(int NewPerfectNumber)
        {
            this.PerfectNumberOfLemons = NewPerfectNumber;
        }
        public int GetPerfectNumberOfLemons()
        {
            return this.PerfectNumberOfLemons;
        }
    }
}
