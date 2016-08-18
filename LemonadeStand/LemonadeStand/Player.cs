using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        string PlayerName;
        public Inventory inventory;

        public Player()
        {
            Inventory inventory = new Inventory();
            this.PlayerName = "PlayerName";
            this.inventory = inventory;
        }
        public Inventory GetInventory()
        {
            return this.inventory;
        }
        public string GetPlayerName()
        {
            return this.PlayerName;
        }
        public void SetPlayerName(string NewPlayerName)
        {
            this.PlayerName = NewPlayerName;
        }
    }
}
