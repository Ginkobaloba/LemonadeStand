using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCubes
    {
        int QuanityIceCubes;
        double MeltRateIcecubes;
        double PriceOfIceCubes;

    public IceCubes()
        {
            this.QuanityIceCubes = 0;
            this.MeltRateIcecubes = 100;
            this.PriceOfIceCubes = .01;
        }
    public void SetQuanityIceCubes(int AmountIceCubesBought)
        {
            this.QuanityIceCubes = this.QuanityIceCubes + AmountIceCubesBought;
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
    public int GetQuanityIceCubes()
        {
            return this.QuanityIceCubes;
        }
    public double GetMeltRateOfIceCubes()
        {
            return this.MeltRateIcecubes;
        }
    }
}
