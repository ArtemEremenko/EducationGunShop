using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Store
{
    internal class Seller
    {
        private List<Product> inventory = new List<Product>();
        public int InventorySize => inventory.Count;
       /*public int InventorySizeAlternative 
        { 
            get 
            { 
                return inventory.Count;
            }
        }*/ 

        public void AddProduct(Product product)
        {
            if (product != null)
            {
                inventory.Add(product);
            }
        }
        public Product RemoveProductAt(int index)
        {
            Product product = inventory[index];
            inventory.RemoveAt(index);
            return product;
        }
        public void ShowInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Seller inventory is empty");
                return;
            }
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] - {inventory[i].Name}, calibeer {inventory[i].Caliber}, in Seller Inventory");
            }
        }
    }
}
