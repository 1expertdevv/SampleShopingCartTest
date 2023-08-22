using SampleShopingCartLib.Entity;
using SampleShopingCartLib.Entity.Interface;
using SampleShopingCartLib.Model;

namespace SampleShopintCart
{
    public class UnitTest1
    {
        IProduct product1;
        IProduct product2;
        public UnitTest1()
        {
            product1 = new Product { Name = "T-Shirt", Price = 20 };
            product1 = new Product { Name = "Jeans", Price = 30 };
        }
        [Fact]
        public void CanAddProductToCart()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            Assert.Equal(1, cart.products.Count);
            cart.AddProduct(product2);
            Assert.Equal(2, cart.products.Count);

        }

        [Fact]
        public void CanGetTotalPriceOfCart()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);
            Assert.Equal(50, cart.GetTotalPrice());
        }
    }
}