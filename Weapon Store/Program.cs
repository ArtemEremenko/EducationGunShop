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
                    Console.WriteLine("Case S is working.");
                    InteractWithSeller();
                    break;
                case "i":
                    Console.WriteLine("Case I is working.");
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
        Console.WriteLine("new text 1-20 ");

        int userInputNum = GetNumberInput();
        if (userInputNum > 0 && userInputNum <= seller.InventorySize)
        {
            var product = seller.RemoveProductAt(userInputNum - 1);
            player.AddProduct(product);
        }
        


        /*
        if (userInputNum == 1) // по індексу наприклад з 0-20 1
        {
            if (seller.RemoveProduct(gun1))
            {
                player.AddProduct(gun1);
            }
            else
            {
                Console.WriteLine("position 1 out of stock");
            }
        }
        else if (usrInputNum == "2")
        {
            if (seller.RemoveProduct(gun2))
            {
                player.AddProduct(gun2);
            }
            else
            {
                Console.WriteLine("position 2 out of stock");
            }
        }
        else
        {
            Console.WriteLine("incorrect input, enter a number '1' or '2'");
        }*/
    }
    
}