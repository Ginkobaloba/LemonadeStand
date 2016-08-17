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
        { }
        public void GetStoreDisplay(Player playerOne, Weather[] myWeather, int day)
        {
            Console.Clear();
            Console.WriteLine("{6}    $ {7}            Todays Weather: {4}*F {5}    Tomorrow's Weather: {8}*F {9} \nLemons: {0}   Sugar: {1}    Ice: {2}      Cups: {3}     \n \n", playerOne.inventory.lemons.GetQuanityOfLemons(), playerOne.inventory.sugar.GetQuanityOfSugar(), playerOne.inventory.iceCubes.GetQuanityOfIceCubes(), playerOne.inventory.paperCups.GetQuanityOfCups(), myWeather[day].GetTemperature(), myWeather[day].GetWeatherConditionString(), playerOne.GetPlayerName(), playerOne.inventory.GetInventoryMoney(), myWeather[day+1].GetTemperature(), myWeather[day+1].GetWeatherConditionString());
        }
        public void PurchaseGroceries(Player playerOne, Weather[] myWeather, int day, int groceries = 0)
        {
           
            for (; groceries < 4; groceries++)
            {
                groceryType = GetGroceryType(groceries);
                GetStoreDisplay(playerOne,  myWeather, day);
                Console.WriteLine("How many {0} would you like to purchase?", groceryType);
                    if (int.TryParse(Console.ReadLine(), out numberToPurchase))
                        {
                            Console.Clear();
                            numberToPurchase = this.confirmAmountToPurchase(numberToPurchase, groceryType, playerOne, myWeather, day);
                            this.VerifyFunds(playerOne, numberToPurchase, groceryType);
                     }
                else
                {
                    Console.WriteLine("You Have Entered an Invalid Response.");
                    this.PurchaseGroceries(playerOne, myWeather, day, groceries);
                }
            }
        } 
        public string GetGroceryType(int i)
        {
            switch (i)
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
        public int confirmAmountToPurchase(int amount, string groceryType, Player playerOne, Weather[] myWeather, int day)
        {
            string confirm;
            this.GetStoreDisplay(playerOne, myWeather, day);
            Console.WriteLine("You have selected to purchase {0} {1}. Is this correct? Yes or No?", amount, groceryType);
            confirm = Console.ReadLine();
            confirm = confirm.ToLower();
            switch (confirm)
            {
                case "yes":
                    return amount;
                case "no":
                    this.GetStoreDisplay(playerOne, myWeather,day);
                    Console.WriteLine("How many {0} would you like to purchase?", groceryType);
                    if (int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Clear();
                        numberToPurchase = this.confirmAmountToPurchase(amount, groceryType, playerOne, myWeather, day);
                    }
                    else
                    {
                        this.GetStoreDisplay(playerOne, myWeather, day);
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        Console.Clear();
                        this.confirmAmountToPurchase(amount, groceryType, playerOne, myWeather, day);

                    }
                    return amount;
                default:
                    Console.WriteLine("You have entered an invalid Selection");
                    Console.ReadLine();
                    Console.Clear();
                    this.confirmAmountToPurchase(amount, groceryType, playerOne, myWeather, day);
                    return amount;
            }
        }
        public void VerifyFunds(Player playerOne, int NumbertoPurchase, string groceryType)
        {
            double ItemCost;


            switch (groceryType)
            {
                case "lemons":
                    ItemCost = playerOne.inventory.lemons.GetPriceOfLemons();
                    break;
                case "ice Cubes":
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
                playerOne.inventory.SetInventoryMoney((ItemCost * NumbertoPurchase * -1));
                switch (groceryType)
                {
                    case "lemons":
                        playerOne.inventory.lemons.SetQuanityOfLemons(NumbertoPurchase);
                        break;
                    case "ice Cubes":
                        playerOne.inventory.iceCubes.SetQuanityofIceCubes(NumbertoPurchase);
                        break;
                    case "cups":
                        playerOne.inventory.paperCups.SetQuanityOfCups(NumbertoPurchase);
                        break;
                    case "sugar":
                        playerOne.inventory.sugar.SetQuanityOfSugar(NumbertoPurchase);
                        break;
                    default:
                        ItemCost = 0;
                        break;
                }
            }
            else
            {
                Console.WriteLine("I'm");
            }

            }
        }
    }

    
