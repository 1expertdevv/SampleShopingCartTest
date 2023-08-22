using SampleShopingCartLib.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShopingCartLib.Model
{
    public class ShoppingCart
    {
        public List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (IProduct product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
