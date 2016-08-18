using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCubes
    {
        int QuanityOfIceCubes;
        double MeltRateIcecubes;
        double PriceOfIceCubes;
        int NumberOfCubesInRecipe;
        int PerfectNumberOfIceCubes;

    public IceCubes()
        {
            this.QuanityOfIceCubes = 0;
            this.MeltRateIcecubes = 100;
            this.PriceOfIceCubes = .01;
            this.NumberOfCubesInRecipe = 1;
            this.PerfectNumberOfIceCubes = 3;
        }
    public void SetQuanityofIceCubes(int AmountIceCubesBought)
        {
            this.QuanityOfIceCubes = this.QuanityOfIceCubes + AmountIceCubesBought;
        }
    public void SetMeltRateOfIceCubes()
        {

        }
    public void SetPriceOfIceCubes(double NewPriceOfIceCubes)
        {
            this.PriceOfIceCubes = NewPriceOfIceCubes;
        }
    public double GetPriceOfIceCubes()
        {
            return this.PriceOfIceCubes;
        }
    public int GetQuanityOfIceCubes()
        {
            return this.QuanityOfIceCubes;
        }
    public double GetMeltRateOfIceCubes()
        {
            return this.MeltRateIcecubes;
        }
    public int GetNumberOfCubesInRecipe()
        {
            return this.NumberOfCubesInRecipe;
        }
        public void SetNumberOfCubesInRecipe(int newNumberOfCubes)
        {
            this.NumberOfCubesInRecipe = newNumberOfCubes;
        }
        public void SetPerfectNumberOfIceCubes(int newPerfectNumber)
        {
            this.PerfectNumberOfIceCubes = newPerfectNumber;
        }
        public int GetPerfectNumberOfIceCubes()
        {
            return this.PerfectNumberOfIceCubes;
        }
    }
}
