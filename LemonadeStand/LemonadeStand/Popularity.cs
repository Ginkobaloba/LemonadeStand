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

    public Popularity(int numberOfCupsSold)
    {
            this.numberOfCustomers = 100 + (numberOfCupsSold / 2);
    }
    public int GetPopularity()
        {
            return this.numberOfCustomers;
        }
    }
}

