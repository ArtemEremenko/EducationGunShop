using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Store
{
    internal class Seller
    {
        private List<Product> productsInSellerInventory = new List<Product>();
        public void SellerSayHi()
        {
            Console.WriteLine("Look what I got for You ... ");
        }
        public void GetNewSupply()
        {

        }
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                productsInSellerInventory.Add(product);
            }
        }
        public bool RemoveProduct(Product product)
        {
            if (productsInSellerInventory.Remove(product))
            {
                return true;
            }
            return false;
        }
        public void ShowInventory(string y)
        {
            if (y != "Y" && y != "y")
            {
                Console.WriteLine("okay then, get lost...");
                //return false;
            }
            else
            {
                foreach (Product prod in productsInSellerInventory)
                {
                    Console.WriteLine($"{prod.Name}, calibeer {prod.Caliber}, in Seller Inventory");
                }
                //return true;
            }
            if (productsInSellerInventory.Count == 0)
            {
                Console.WriteLine("Seller inventory is empty");
            }
        }
        /*public bool OutOfStock()
        {
            if (0 == 0)
            {
                return true;
            }
            return false;
        }*/
    }
}
