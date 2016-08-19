using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public void RunDay(double buyLevel, Player player, int dayNumber, Customer[] customers, Store store, Weather[] myWeather)
        {
            bool pitcher;
            int cupsSold;
            double moneyMade;
            double costOfLemonade;
            costOfLemonade = player.GetCostOfLemonade();
            moneyMade = 0;
            cupsSold = 0;
            int numberOfCupsInPitcher = 10;

            for (int a = 0; a < customers.Length; a++)
            {
                if (cupsSold % 10 == 0 && ((player.inventory.lemons.GetQuanityOfLemons() - player.inventory.lemons.GetNumberOfLemonsInRecipe()) >= 0) && ((player.inventory.sugar.GetQuanityOfSugar() - player.inventory.sugar.GetNumberOfSugarInRecipe()) >= 0))
                {
                    pitcher = true;
                }
                else if (cupsSold % 10 != 0)
                {
                    pitcher = true;
                }
                else
                {
                    pitcher = false;
                }
                Thread.Sleep(200);
                if (pitcher == true && customers[a].GetThirstLevel() >= buyLevel && ((player.inventory.iceCubes.GetQuanityOfIceCubes() - player.inventory.iceCubes.GetNumberOfCubesInRecipe()) >= 0) && ((player.inventory.paperCups.GetQuanityOfCups() - player.inventory.paperCups.GetNumberOfCupsInRecipe()) >= 0))
                {
                    Console.Clear();
                    store.GetStoreDisplay(player, myWeather, dayNumber);
                    Console.WriteLine("{0} bought a cup of lemonade!", customers[a].GetCustomerName());
                    player.inventory.iceCubes.SetQuanityofIceCubes(-1 * (player.inventory.iceCubes.GetNumberOfCubesInRecipe()));
                    player.inventory.paperCups.SetQuanityOfCups(-1 * (player.inventory.paperCups.GetNumberOfCupsInRecipe()));
                    player.inventory.SetInventoryMoney(costOfLemonade);
                    moneyMade = moneyMade + costOfLemonade;
                    if (cupsSold % numberOfCupsInPitcher == 0 && ((player.inventory.lemons.GetQuanityOfLemons() - player.inventory.lemons.GetNumberOfLemonsInRecipe()) >= 0) && ((player.inventory.sugar.GetQuanityOfSugar() - player.inventory.sugar.GetNumberOfSugarInRecipe()) >= 0))
                    {
                        pitcher = true;
                        player.inventory.lemons.SetQuanityOfLemons(-1 * (player.inventory.lemons.GetNumberOfLemonsInRecipe()));
                        player.inventory.sugar.SetQuanityOfSugar(-1 * (player.inventory.sugar.GetNumberOfSugarInRecipe()));
                    }

                    cupsSold = cupsSold + 1;
                }
                else
                {
                    Console.Clear();
                    store.GetStoreDisplay(player, myWeather, dayNumber);
                    Console.WriteLine("{0} walked passed without buying.", customers[a].GetCustomerName());
                }
            }
            Console.WriteLine("Today you sold{0}", cupsSold);
            Console.WriteLine("Today you made {0}", moneyMade);

            Console.ReadLine();
        }
     }
 }
