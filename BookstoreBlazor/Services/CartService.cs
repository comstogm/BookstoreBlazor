using BookstoreDatabase.Entitites;

namespace BookstoreBlazor.Services
{
    public class CartService
    {
        //List of ints to hold item IDs
        public List<Book> Products { get; set; } = new();

        public void AddProductToCart(Book book) 
        {
            Products.Add(book);
        }

        public List<Book> GetProductsFromCart()
        {
            return Products;
        }

        public void RemoveProductFromCart(Book book)
        {
            Products.Remove(book);
        }

        public int GetCount()
        {
            return Products.Count;
        }

    }
}
