using System;
using System.Collections;
using System.Reflection.Metadata;
using Weapon_Store;

internal class Program
{
    private static void Main(string[] args)
    {
        Product gun1 = new Product("AK 74 M", 5.45f);
      /*gun1.Count = 1;
        gun1.Name = "AK 74 M";
        gun1.Caliber = 5.45f;*/
        Product gun2 = new Product("AR 15", 5.56f);
      /*un2.Count = 3;
        gun2.Name = "AR 15";
        gun2.Caliber = 5.56f;*/
        Seller seller = new Seller();
        Player player = new Player();

        Console.WriteLine("Here You can get a gun");
        Console.WriteLine("----------------------");

        seller.AddProduct(gun1);
        seller.AddProduct(gun2);
        seller.AddProduct(gun2.Clone());
        seller.AddProduct(gun2.Clone());
        
        string exitInput = " ";
        while (exitInput != "x" && exitInput != "X") // винести в окремий метод перевірку IsExitInput
        {
            seller.SellerSayHi();
            
            // swich на інпут якщо Х то вихід якщо S то в магазин  І в інвентар
            Console.WriteLine("if you want to see Seller inventory, enter 'Y' ");
            string userInputChar = Console.ReadLine();

            seller.ShowInventory(userInputChar);
           
            Console.WriteLine("to get a gun choose and enter a number '1' for AK-74 or '2' for AR-15");
            string usrInputNum = Console.ReadLine();
            if (usrInputNum == "1") // по індексу наприклад з 0-20 
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
            }
            
            Console.WriteLine("if you want to see Player inventory, enter '0' ");
            string userInputChar2 = Console.ReadLine();
            if (userInputChar2 == "0")
            {
                player.ShowInventory();
            }
            Console.WriteLine("To EXIT enter 'X' or any other 'key' to continue");
            exitInput = Console.ReadLine();
        }

        Console.ReadKey();

        //Sale();

        /*
        GetNewSupply(1);
        ShowSellerInventory();
        ShowMyInventory();
        BuyProduct();*/
    }
}