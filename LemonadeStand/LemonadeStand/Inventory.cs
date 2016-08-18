using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Lemons lemons;
        public Sugar sugar;
        public IceCubes iceCubes;
        public PaperCups paperCups;
        public double money;
        public Inventory()
        {
            lemons = new Lemons();
            sugar = new Sugar();
            iceCubes = new IceCubes();
            paperCups = new PaperCups();
   
            this.money = 20;
        }
        public Lemons GetInventoryLemons()
        {
            return this.lemons;
        }
        public Sugar GetInventorySugar()
        {
            return this.sugar;
        }
        public IceCubes GetInventoryIceCubes()
        {
            return this.iceCubes;
        }
        public PaperCups GetInventoryPaperCups()
        {
            return this.paperCups;
        }
        public double GetInventoryMoney()
        {
            return this.money;
        }
        public void SetInventoryLemons(Lemons storeLemons)
        {
            this.lemons = storeLemons;
        }
        public void SetInventorySugar(Sugar storeSugar)
        {
            this.sugar = storeSugar;
        }
        public void SetInventoryPaperCups(PaperCups storePaperCups)
        {
            this.paperCups = storePaperCups;
        }
        public void SetInventoryIceCubes(IceCubes storeIceCubes)
        {
            this.iceCubes = storeIceCubes;
        }
        public void SetInventoryMoney(double ChangeAmountOfMoney)
        {
            this.money =(this.money + ChangeAmountOfMoney);
        }


    }
}
