using BlazorShopCart.Models;

namespace BlazorShopCart.Services
{
    public class ShopService : IShopService
    {
        public IList<Product> cart { get; set; }
        public double OrderTotal { get; set; }

        public event Action OnChange;
        private void NotifyOnChange()
        {
            OnChange?.Invoke();
        }
        //public double total;
        public ShopService()
        {
            cart = new List<Product>();
            OrderTotal = 0;
        }

        public void AddProduct(Product prod)
        {
            cart.Add(prod);
            OrderTotal = OrderTotal + prod.Price;
            //NotifyOnChange();
        }
        public void RemoveProduct(Product prod)
        {
            cart.Remove(prod);
            OrderTotal = OrderTotal - prod.Price;
            NotifyOnChange();
        }

    }
}
