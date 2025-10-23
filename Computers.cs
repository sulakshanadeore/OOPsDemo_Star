using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    public class Computers:ElectronicProducts
    {
        public string Type { get; set; }
        public int RAMCapacity { get; set; }
        public int HDD { get; set; }
        public Accessories GetAccessories { get; set; }


    }


    public class Cart {
        public double AddToCart(Computers c)
        {
            double compprice = 40000;
            double totalPrice = 0;
            if (c.GetAccessories.MousePad == true && c.GetAccessories.Mouse == true && c.GetAccessories.HDMICable == true && c.GetAccessories.Bag == true)
            {

                double price = 3000;
                totalPrice = price+compprice;   
            }
            else
            {

                totalPrice = compprice;

            }
            return totalPrice;
        }
    
    
    }

    public class Accessories
    {
        public bool Bag { get; set; }
        public bool Mouse { get; set; }
        public bool MousePad { get; set; }

        public bool HDMICable { get; set; }

    }
}
