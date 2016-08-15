using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        int QuanitySugar;
        double SpoilRateSugar;
        double PriceOfSugar;

        public Sugar()
        {
            this.QuanitySugar = 0;
            this.SpoilRateSugar = 0;
            this.PriceOfSugar = .05;
        }
        public void SetQuanitySugar(int AmountSugarBought)
        {
            this.QuanitySugar = this.QuanitySugar + AmountSugarBought;
        }
        public void SetSpoilRateSugar(Weather weather)
        {
            this.SpoilRateSugar = weather.GetTemperature() / 100.0;
            this.SpoilRateSugar = 5 / this.SpoilRateSugar;
        }
        public void SetPriceOfSugar(double NewPriceOfIceCubes)
        {
            this.PriceOfSugar = NewPriceOfIceCubes;
        }
        public double GetSpoilRateSugar()
        {
            return this.SpoilRateSugar; 
        }
        public int GetQuanitySugar()
        {
            return this.QuanitySugar;
        }
        public double GetPriceOfSugar()
        {
            return this.PriceOfSugar;
        }

    }
}
