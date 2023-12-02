using BookstoreDatabase.Entitites;

namespace BookstoreModels
{
    public class ShoppingCartViewModel
    {
        public List<Book> BooksInCart { get; set; } = new();

        public Order BuildOrder(int CustomerId)
        {
            Order newOrder = new Order
            {
                OrderDate = DateTime.Now,
                CustomerId = CustomerId,
                OrderLineItems = new List<OrderLineItem>()
            };

            foreach (var book in BooksInCart)
            {
                var lineItem = new OrderLineItem
                {
                    BookId = book.BookId,
                    Price = book.Price,
                    BookName = book.BookTitle
                };

                newOrder.OrderLineItems.Add(lineItem);

            }

            return newOrder;
        }

    }
}
