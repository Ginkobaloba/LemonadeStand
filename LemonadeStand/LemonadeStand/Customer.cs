using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        string customerName;
        int thirstLevel;

        public Customer(string name)
        {
            Random random = new Random();
            this.customerName = name;
            this.thirstLevel = random.Next(1, 11);
        }
      public int GetThirstLevel()
        {
            return this.thirstLevel;
        }
      public void SetThirstLevel()
        {

        }
        public string GetCustomerName()
        {
            return this.customerName;
        }
           
}

}