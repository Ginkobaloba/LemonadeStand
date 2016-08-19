using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        string materialType;


        public Recipe()
        { }
        public void RunRecipeScreen(Player player, Weather[] myWeather, int day)
        {
            Console.Clear();
            if (day == 0)
            {
                Console.WriteLine("Welcome to your recipe screen. Since its your first time here allow me to explain a few things.");
                Console.ReadLine();
                Console.WriteLine("You will be asked to select an amount for each ingredients lemons, Sugar, Ice and Cups.");
                Console.ReadLine();
                Console.WriteLine("It's important to remember that the number you select for ice cubes and cups is the amount that will be used per glass.");
                Console.WriteLine("While lemons and sugar are the amount put in each pitcher 10 glasses to a pitcher.");
                Console.ReadLine();
                Console.WriteLine("Good Luck");
                Console.ReadLine();
                Console.Clear();
                this.GetRecipeDisplay(player, myWeather, day);
                this.RecipePrompt(player, myWeather, day);
            }
            else
            {
                Console.WriteLine("Welcome back. Keep trying different recipes till you figure out what works best.");
                Console.ReadLine();
                Console.Clear();
                this.RecipePrompt(player, myWeather, day);
            }

        }

        public void RecipePrompt(Player player, Weather[] myWeather, int day, int material = 0)
        {
            int amountInRecipe;
            string confirm;
            for (; material < 5; material++)
            {
                materialType = GetMaterialType(material);
                GetRecipeDisplay(player, myWeather, day);
                if (material == 0)
                {
                    Console.WriteLine("How many {0} would you like in each pitcher?", materialType);
                }
                else if (material == 1)
                {
                    Console.WriteLine("How many {0}s would you like in each pitcher?", materialType);
                }
                else if (material == 2)
                {
                    Console.WriteLine("How many {0} would you like in each cup?", materialType);
                }
                else if (material == 3)
                {
                    Console.WriteLine("How many {0} would you like to give each customer?", materialType);
                }
                else
                {
                    Console.WriteLine("What would you like to set the {0} of your lemonade?", materialType);
                    confirm = Console.ReadLine();
                    this.ConfirmCostOfLemonade(player, confirm);
                    break;
                }
                    if (int.TryParse(Console.ReadLine(), out amountInRecipe) && amountInRecipe > 0)
                    {
                        Console.Clear();
                        amountInRecipe = this.confirmAmountInRecipe(amountInRecipe, materialType, player, myWeather, day);
                        SetRecipeValues(player, materialType, amountInRecipe);
                    }
                    else{
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        material--;
                    }
                }
            }
        
        public string GetMaterialType(int i)
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
                case 4:
                    return "price";
                default:
                    return "PassionFruit";
            }
        }
        public int confirmAmountInRecipe(int amount, string materialType, Player player, Weather[] myWeather, int day)
        {
            string confirm;
            this.GetRecipeDisplay(player, myWeather, day);
            Console.WriteLine("You have selected to use {0} {1}. Is this correct? Yes or No?", amount, materialType);
            confirm = Console.ReadLine();
            confirm = confirm.ToLower();
            switch (confirm)
            {
                case "yes":
                    return amount;
                case "no":
                    this.GetRecipeDisplay(player, myWeather, day);
                    Console.WriteLine("How many {0} would you like to purchase?", materialType);
                    if (int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Clear();
                        amount = this.confirmAmountInRecipe(amount, materialType, player, myWeather, day);
                    }
                    else
                    {
                        this.GetRecipeDisplay(player, myWeather, day);
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        Console.Clear();
                        this.confirmAmountInRecipe(amount, materialType, player, myWeather, day);

                    }
                    return amount;
                default:
                    Console.WriteLine("You have entered an invalid Selection");
                    Console.ReadLine();
                    Console.Clear();
                    this.confirmAmountInRecipe(amount, materialType, player, myWeather, day);
                    return amount;
            }
        }
        public void GetRecipeDisplay(Player player, Weather[] myWeather, int day)
        {
            Console.Clear();
            Console.WriteLine("{6}    ${7:0.00} \nTodays Weather: {4}*F {5}     Tomorrow's Weather: {8}*F {9}          Day: {10} \nLemons: {0}   Sugar: {1}    Ice: {2}      Cups: {3}     \n \n", player.inventory.lemons.GetQuanityOfLemons(), player.inventory.sugar.GetQuanityOfSugar(), player.inventory.iceCubes.GetQuanityOfIceCubes(),
                player.inventory.paperCups.GetQuanityOfCups(), myWeather[day].GetTemperature(), myWeather[day].GetWeatherConditionString(), player.GetPlayerName(), player.inventory.GetInventoryMoney(), myWeather[day + 1].GetTemperature(), myWeather[day + 1].GetWeatherConditionString(), day + 1);
        }
        public void SetRecipeValues(Player player, string materialType, int amountInRecipe)
        {

            switch (materialType)
            {
                case "lemons":
                    player.inventory.lemons.SetNumberOfLemonsInRecipe(amountInRecipe);
                    break;
                case "ice Cubes":
                    player.inventory.iceCubes.SetNumberOfCubesInRecipe(amountInRecipe);
                    break;
                case "cups":
                    player.inventory.paperCups.SetNumberOfCupsInRecipe(amountInRecipe);
                    break;
                case "sugar":
                    player.inventory.sugar.SetNumberOfSugarInRecipe(amountInRecipe);
                    break;
                case "Price":
                    player.SetCostofLemonade(amountInRecipe);
                    break;
                default:
                    break;
            }
        }
        public void ConfirmCostOfLemonade(Player player, string confirm)
        {
            double amountInRecipeDouble;

        if (double.TryParse(confirm, out amountInRecipeDouble) && amountInRecipeDouble > 0)

                Console.WriteLine("Please confirm that you would like to charge ${0} per cup.", amountInRecipeDouble);
                confirm = Console.ReadLine();
                confirm = confirm.ToLower();

                switch (confirm)
                {
                    case "yes":
                        player.SetCostofLemonade(amountInRecipeDouble);
                        break;
                    case "no":
                    Console.WriteLine("How much would you like to charge for a cup of your lemonade?");
                    confirm = Console.ReadLine();
                    ConfirmCostOfLemonade(player, confirm);
                        break;

                    default:
                        Console.WriteLine("You Have Entered an Invalid Response.");
                        Console.ReadLine();
                        this.ConfirmCostOfLemonade(player, confirm);
                        break;

                }
            }
    }
}