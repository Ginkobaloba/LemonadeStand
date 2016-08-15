using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        Lemons StoreLemons;
        Sugar StoreSugar;
        IceCubes StoreIceCubes;
        PaperCups StorePaperCups;
        public Store(Player player, Weather weather)
        {
            StoreLemons = new Lemons();
            StoreSugar = new Sugar();
            StoreIceCubes = new IceCubes();
            StorePaperCups = new PaperCups();
        }
    }
}
