using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_Store
{
    public class Product
    {
        public string Name { get; set; }
        public float Caliber { get; set; }

        public Product (string name, float caliber)
        {
            Name = name;
            Caliber = caliber;
        }
        public Product Clone()
        {
            return new Product (Name, Caliber);
        }
    }


}
