namespace BlazorShopCart.Models
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; } = "";
        public double Price { get; set; }
        public string Image { get; set; } = "";

    }
}
