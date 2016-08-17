using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Popularity
    {
        int numberOfCustomers;

    public Popularity()
    {
            this.numberOfCustomers = 100;
    }
    public int GetPopularity()
        {
            return this.numberOfCustomers;
        }
    public void SetPopularity(int numberOfCupsSold)
        {
            this.numberOfCustomers = this.numberOfCustomers + (numberOfCupsSold / 25);
        }
    }
}

