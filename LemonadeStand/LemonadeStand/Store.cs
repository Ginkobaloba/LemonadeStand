using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand

{
    public class Store
    {
        int i;
        int numberToPurchase;
        string groceryType;
        public Store()
        {
        }

        public void GetStoreDisplay(Player player, Weather[] myWeather, int day)
        {
            Console.Clear();
            Console.WriteLine("{6}    ${7:0.00} \nTodays Weather: {4}*F {5}     Tomorrow's Weather: {8}*F {9}          Day: {10} \nLemons: {0}   Sugar: {1}    Ice: {2}      Cups: {3}     \n \n", player.inventory.lemons.GetQuanityOfLemons(), player.inventory.sugar.GetQuanityOfSugar(), player.inventory.iceCubes.GetQuanityOfIceCubes(),
                player.inventory.paperCups.GetQuanityOfCups(), myWeather[day].GetTemperature(), myWeather[day].GetWeatherConditionString(), player.GetPlayerName(), player.inventory.GetInventoryMoney(), myWeather[day + 1].GetTemperature(), myWeather[day + 1].GetWeatherConditionString(), day + 1);
        }
        public void PurchaseGroceries(Player player, Weather[] myWeather, int day, int groceries = 0)
        {
            double itemCost;

            for (; groceries < 4; groceries++)
            {
                groceryType = GetGroceryType(groceries);
                itemCost = GetItemCost(player, groceryType);
                GetStoreDisplay(player, myWeather, day);

                Console.WriteLine("How many {0} would you like? They cost ${1:.00} each.", groceryType, itemCost);
                if (int.TryParse(Console.ReadLine(), out numberToPurchase) && numberToPurchase > 0)
                {
                    Console.Clear();
                    numberToPurchase = this.confirmAmountToPurchase(numberToPurchase, groceryType, player, myWeather, day);
                    this.VerifyFunds(player, numberToPurchase, groceryType);
                }
                else
                {
                    Console.WriteLine("You Have Entered an Invalid Response.");
                    groceries--;
                }
            }
            groceries = 0;
        }
        public string GetGroceryType(int groceries)
        {
            switch (groceries)
            {
                case 0:
                    return "lemons";
                case 1:
                    return "sugar";
                case 2:
                    return "ice Cubes";
                case 3:
                    return "cups";
                default:
                    return "PassionFruit";
            }
        }
        public int confirmAmountToPurchase(int amount, string groceryType, Player player, Weather[] myWeather, int day)
        {
            string confirm;
            this.GetStoreDisplay(player, myWeather, day);
            Console.WriteLine("You have selected to purchase {0} {1}. Is this correct? Yes or No?", amount, groceryType);
            confirm = Console.ReadLine();
            confirm = confirm.ToLower();
            switch (confirm)
            {
                case "yes":
                    return amount;
                case "no":
                    this.GetStoreDisplay(player, myWeather, day);
                    Console.WriteLine("How many {0} would you like to purchase?", groceryType);
                    if (int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Clear();
                        numberToPurchase = this.confirmAmountToPurchase(amount, groceryType, player, myWeather, day);
                    }
                    else
                    {
                        this.GetStoreDisplay(player, myWeather, day);
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        Console.Clear();
                        this.confirmAmountToPurchase(amount, groceryType, player, myWeather, day);

                    }
                    return amount;
                default:
                    Console.WriteLine("You have entered an invalid Selection");
                    Console.ReadLine();
                    Console.Clear();
                    this.confirmAmountToPurchase(amount, groceryType, player, myWeather, day);
                    return amount;
            }
        }
        public void VerifyFunds(Player player, int numberToPurchase, string groceryType)
        {
            double ItemCost;

            ItemCost = this.GetItemCost(player, groceryType);


            if ((player.inventory.GetInventoryMoney() - (ItemCost * numberToPurchase)) > 0)
            {
                player.inventory.SetInventoryMoney((ItemCost * numberToPurchase * -1));

                switch (groceryType)
                {
                    case "lemons":
                        player.inventory.lemons.SetQuanityOfLemons(numberToPurchase);
                        break;
                    case "ice Cubes":
                        player.inventory.iceCubes.SetQuanityofIceCubes(numberToPurchase);
                        break;
                    case "cups":
                        player.inventory.paperCups.SetQuanityOfCups(numberToPurchase);
                        break;
                    case "sugar":
                        player.inventory.sugar.SetQuanityOfSugar(numberToPurchase);
                        break;
                    default:
                        ItemCost = 0;
                        break;
                }
            }
            else
            {
                Console.WriteLine("I'm sorry you don't have enought money available to purchase this many {0}", groceryType);
                Console.WriteLine();
                Console.WriteLine("How many {0} would you like to purchase?", groceryType);
                numberToPurchase = Convert.ToInt32(Console.ReadLine());
                this.VerifyFunds(player, numberToPurchase, groceryType);
            }

        }

        public double GetItemCost(Player player, string groceryType)
        {


            switch (groceryType)
            {
                case "lemons":
                    return player.inventory.lemons.GetPriceOfLemons();
                case "ice Cubes":
                    return player.inventory.iceCubes.GetPriceOfIceCubes();
                case "cups":
                    return player.inventory.paperCups.GetPriceOfPaperCups();
                case "sugar":
                    return player.inventory.sugar.GetPriceOfSugar();
                default:
                    return 0;

            }
        }
    }

}
  


