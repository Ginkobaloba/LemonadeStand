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
        public Inventory()
        {
            Lemons = new Lemons();
            Sugar = new Sugar();
            IceCubes = new IceCubes();
            PaperCups = new PaperCups();
   
            this.Lemons = Lemons;
            this.Sugar = Sugar;
            this.PaperCups = PaperCups;
            this.IceCubes = IceCubes;
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
