using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Threading.Channels;
using Weapon_Store;

internal class Program
{
    private static Seller seller = new Seller(); 
    private static Player player = new Player();

    private static void Main(string[] args)
    {
        Product gun1 = new Product("AK 74 M", 5.45f);
        Product gun2 = new Product("AR 15", 5.56f);

        Console.WriteLine("Here You can get a gun");
        Console.WriteLine("----------------------");

        seller.AddProduct(gun1);
        seller.AddProduct(gun2);
        seller.AddProduct(gun2.Clone());
        seller.AddProduct(gun2.Clone());

        string inputXSI = " ";

        do
        {
            Console.WriteLine("Enter \n 'X' to exit.\n 'S' to see Seller inventory,\n 'I' to see Player inventory");

            inputXSI = Console.ReadLine();
            if (IsExitInput(inputXSI))
                break;

            switch (inputXSI.ToLower())
            {
                case "s":
                    InteractWithSeller();
                    break;
                case "i":
                    player.ShowInventory();
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    break;
            }
        } 
        while (true);

        Console.ReadKey();
    }

    private static bool IsExitInput(string userInput)
    {
        return userInput.ToLower() == "x";
    }

    private static int GetNumberInput()
    {
        int num;
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Enter integer please");
        }
        return num;
    }

    private static void InteractWithSeller()
    {
        seller.ShowInventory();
        if (seller.InventorySize == 0)
        {
            return;
        }
        Console.WriteLine("Enter number of the product that You want to get.");

        int userInputNum = GetNumberInput();
        if (userInputNum > 0 && userInputNum <= seller.InventorySize)
        {
            var product = seller.RemoveProductAt(userInputNum - 1);
            player.AddProduct(product);
        }
    }
}