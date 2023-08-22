using SampleShopingCartLib.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShopingCartLib.Entity
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
