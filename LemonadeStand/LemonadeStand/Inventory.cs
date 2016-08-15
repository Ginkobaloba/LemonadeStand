using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        Lemons Lemons;
        Sugar Sugar;
        IceCubes IceCubes;
        PaperCups PaperCups;
        decimal Money;
        public Inventory(Lemons StoreLemons, Sugar StoreSugar, IceCubes StoreIceCubes, PaperCups StorePaperCups)
        {
            this.Lemons = StoreLemons;
            this.Sugar = StoreSugar;
            this.PaperCups = StorePaperCups;
            this.IceCubes = StoreIceCubes;
            this.Money = 20;
        }
        public Lemons GetInventoryLemons()
        {
            return this.Lemons;
        }
        public Sugar GetInventorySugar()
        {
            return this.Sugar;
        }
        public IceCubes GetInventoryIceCubes()
        {
            return this.IceCubes;
        }
        public PaperCups GetInventoryPaperCups()
        {
            return this.PaperCups;
        }
        public decimal GetInventoryMoney()
        {
            return this.Money;
        }
        public void SetInventoryLemons(Lemons StoreLemons)
        {
            this.Lemons = StoreLemons;
        }
        public void SetInventorySugar(Sugar StoreSugar)
        {
            this.Sugar = StoreSugar;
        }
        public void SetInventoryPaperCups(PaperCups StorePaperCups)
        {
            this.PaperCups = StorePaperCups;
        }
        public void SetInventoryIceCubes(IceCubes StoreIceCubes)
        {
            this.IceCubes = StoreIceCubes;
        }


    }
}
