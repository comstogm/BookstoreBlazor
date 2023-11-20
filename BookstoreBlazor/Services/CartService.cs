namespace BookstoreBlazor.Services
{
    public class CartService
    {
        //List of ints to hold item IDs
        public List<int> Products { get; set; } = new();

        public void AddProductToCart(int productId) 
        {
            Products.Add(productId);
        }

        public List<int> GetProductsFromCart()
        {
            return Products;
        }

        public void RemoveProductFromCart(int productId)
        {
            //todo
        }

        public int GetCount()
        {
            return Products.Count;
        }

    }
}
