using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Store
{
    internal class Player
    {
        public List<Product> productsInMyInventory = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product != null)
            {
                productsInMyInventory.Add(product);
            }
        }

        public void ShowInventory()
        {
            if (productsInMyInventory.Count != 0)
            {
                foreach (Product prod in productsInMyInventory)
                {
                    Console.WriteLine($"{prod.Name}, calibeer {prod.Caliber}, in Player Inventory");
                }
            }
            else
            {
                Console.WriteLine("Player inventory is empty");
            }
        }
    }
}
