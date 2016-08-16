using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
       int numberToPurchase;
        string groceryType;
        public Store()
        { }
        public void GetStoreDisplay(Player playerOne, Weather myWeather)
        {
            Console.Clear();
            Console.WriteLine("{6}    $ {7}  \nLemons: {0}   Sugar: {1}    Ice: {2}      Cups: {3}    Weather: {4}*F {5} \n \n", playerOne.inventory.lemons.GetQuanityOfLemons(), playerOne.inventory.sugar.GetQuanityOfSugar(), playerOne.inventory.iceCubes.GetQuanityOfIceCubes(), playerOne.inventory.paperCups.GetQuanityOfCups(), myWeather.GetTemperature(), myWeather.GetWeatherConditionString(), playerOne.GetPlayerName(), playerOne.inventory.GetInventoryMoney());
        }
        public void PurchaseLemons(Player playerOne)
        {
            for (int i = 0; i < 4; i++)
            {

                groceryType = GetGroceryType(i);
                Console.WriteLine("How many {0} would you like to purchase?",groceryType);
                if (int.TryParse(Console.ReadLine(), out numberToPurchase))
                {
                    Console.Clear();
                    numberToPurchase = this.confirmAmountToPurchase(numberToPurchase, groceryType);
                    this.VerifyFunds(playerOne, numberToPurchase, groceryType);
                }
                else
                {
                    Console.WriteLine("You Have Entered an Invalid Response.");
                    this.PurchaseLemons(playerOne);
                }
            }
        }
        public string GetGroceryType(int i)
        {
            switch (i)
            {
                case 0:
                 return "Lemons";
                case 1:
                  return "sugar";
                case 2:
                  return "iceCubes";
                case 3:
                    return "cups";
                default:
                    return "PassionFruit";
            }
        }
        //amountToPurchase = Console.ReadLine();
        //switch (amountToPurchase)
        //{
        //    case "5":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {
        //                    numberToPurchase = int.Parse(amountToPurchase);
        //                    PlayerOne.inventory.set
        //                    PlayerOne.inventory.lemons.SetQuanityOfLemons(numberToPurchase);
        //                }
        //                break;
        //            case "no":
        //                {
        //                    this.PurchaseLemons(PlayerOne);
        //                }
        //                break;
        //            default:
        //                {
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                }
        //                break;
        //        }
        //        break;
        //    case "10":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {

        //                }
        //                break;
        //            case "no":
        //                    this.PurchaseLemons(PlayerOne);
        //                break;
        //            default:
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                break;
        //        }
        //        break;
        //    case "25":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {

        //                }
        //                break;
        //            case "no":
        //                {
        //                    this.PurchaseLemons(PlayerOne);
        //                }
        //                break;
        //            default:
        //                {
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                }
        //                break;
        //        }
        //        break;
        //    case "50":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {

        //                }
        //                break;
        //            case "no":
        //                {
        //                    this.PurchaseLemons(PlayerOne);
        //                }
        //                break;
        //            default:
        //                {
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                }
        //                break;
        //        }
        //        break;
        //    case "100":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {

        //                }
        //                break;
        //            case "no":
        //                {
        //                    this.PurchaseLemons(PlayerOne);
        //                }
        //                break;
        //            default:
        //                {
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                }
        //                break;
        //        }
        //        break;
        //    case "200":
        //        Console.WriteLine("You Have Selected to Purchase {0} lemons are you sure? Yes or No?", amountToPurchase);
        //        confirm = Console.ReadLine();
        //        confirm = confirm.ToLower();
        //        switch (confirm)
        //        {
        //            case "yes":
        //                {

        //                }
        //                break;
        //            case "no":
        //                    this.PurchaseLemons(PlayerOne);
        //                break;
        //            default:
        //                    Console.WriteLine("You have entered an invalid Selection");
        //                break;
        //        }
        //        break;
        //    default:
        //        Console.WriteLine("You have entered an invalid selection");
        //        break;



        //    }
        //}
        //public void PurchaseSugar(Player PlayerOne)
        //{
        //    Console.WriteLine("How many Lemons would you like to purchase? 5, 10, 25, 50 or 100?");

        //}
        //public void PurchaseIceCubes(Player PlayerOne)
        //{
        //    Console.WriteLine("How many Lemons would you like to purchase? 5, 10, 25, 50 or 100?");
        //}
        //public void PurchaseCupslayer(Player PlayerOne)
        //{
        //    Console.WriteLine("How many Lemons would you like to purchase? 5, 10, 25, 50 or 100?");
        //}
        public int confirmAmountToPurchase(int amount, string groceryType)
        {
            string confirm;
            Console.WriteLine("You have selected to purchase {0} {1}. Is this correct? Yes or No?", amount, groceryType);
            confirm = Console.ReadLine();
            confirm = confirm.ToLower();
            switch (confirm)
            {
                case "yes":
                    return amount;
                case "no":
                    Console.WriteLine("How many {0} would you like to purchase?", groceryType);
                    if (int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Clear();
                        numberToPurchase = this.confirmAmountToPurchase(amount, groceryType);
                    }
                    else
                    {
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        Console.Clear();
                        this.confirmAmountToPurchase(amount, groceryType);

                    }
                    return amount;
                default:
                    Console.WriteLine("You have entered an invalid Selection");
                    Console.ReadLine();
                    Console.Clear();
                    this.confirmAmountToPurchase(amount, groceryType);
                    return amount;
            }
        }
                public void VerifyFunds(Player playerOne, int NumbertoPurchase, string groceryType)
                {
                    double ItemCost;


                    switch(groceryType)
                    {
                        case "lemons":
                            ItemCost = playerOne.inventory.lemons.GetPriceOfLemons();
                        break;
                        case "iceCubes":
                            ItemCost = playerOne.inventory.iceCubes.GetPriceOfIceCubes();
                        break;
                        case "cups":
                            ItemCost = playerOne.inventory.paperCups.GetPriceOfPaperCups();
                        break;
                        case "sugar":
                            ItemCost = playerOne.inventory.sugar.GetPriceOfSugar();
                        break;
                        default:
                            ItemCost = 0;
                        break;

                      }
            if ((playerOne.inventory.GetInventoryMoney() - (ItemCost * NumbertoPurchase)) > 0)
            {
            
}
            
      }
   }
}
    
