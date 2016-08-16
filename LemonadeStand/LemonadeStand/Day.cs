using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        int numberOfDays;
        int popularity;
        public Day(int numberofdays)
        {
            this.numberOfDays = numberofdays;
            this.popularity = 0;
        }
        public void SetPopularity(int NumberOfCustomersServed)
        {
            this.popularity = NumberOfCustomersServed / 2;
        }
        public void SetNumberOfDays(int NumberofDays)
        {
            this.numberOfDays = NumberofDays;
        }
        public int GetNumberofDays()
        {
            return this.numberOfDays;
        }
    }
}
