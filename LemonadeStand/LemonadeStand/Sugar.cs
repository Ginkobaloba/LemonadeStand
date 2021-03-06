﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        int QuanityOfSugar;
        double SpoilRateSugar;
        double PriceOfSugar;
        int NumberOfSugarInRecipe;
        int perfectNumberOfSugar;

        public Sugar()
        {
            this.QuanityOfSugar = 0;
            this.SpoilRateSugar = 0;
            this.PriceOfSugar = .05;
            this.NumberOfSugarInRecipe = 1;
            this.perfectNumberOfSugar = 6;
        }
        public void SetQuanityOfSugar(int AmountSugarBought)
        {
            this.QuanityOfSugar = this.QuanityOfSugar + AmountSugarBought;
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
        public int GetQuanityOfSugar()
        {
            return this.QuanityOfSugar;
        }
        public double GetPriceOfSugar()
        {
            return this.PriceOfSugar;
        }
        public int GetNumberOfSugarInRecipe()
        {
            return this.NumberOfSugarInRecipe;
        }
        public void SetNumberOfSugarInRecipe(int newNumberOfSugar)
        {
            this.NumberOfSugarInRecipe = newNumberOfSugar;
        }
        public void setPerfectNumberOfSugar(int newPerfectNumber)
        {
            this.perfectNumberOfSugar = newPerfectNumber;
        }
        public int GetPerfectNumberOfSugar()
        {
            return this.perfectNumberOfSugar;
        }

    }
}
