using BookstoreBlazor.ViewModels;
using BookstoreDatabase.Entitites;

namespace BookstoreBlazor.Services
{
    public class CartService
    {
        public ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel();

        public void AddProductToCart(Book book) 
        {
            shoppingCartViewModel.BooksInCart.Add(book);
        }

        public List<Book> GetProductsFromCart()
        {
            return shoppingCartViewModel.BooksInCart;
        }

        public void RemoveProductFromCart(Book book)
        {
            shoppingCartViewModel.BooksInCart.Remove(book);
        }

        public int GetCount()
        {
            return shoppingCartViewModel.BooksInCart.Count;
        }

    }
}
