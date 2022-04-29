using BlazorShopCart.Models;

namespace BlazorShopCart.Services
{
    public interface IShopService
    {
        public IList<Product> cart { get; set; }
        public void AddProduct(Product product);
        public void RemoveProduct(Product product);
        public double OrderTotal { get; set; }

    }
}
