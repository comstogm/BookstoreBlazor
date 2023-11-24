using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreDatabase.Entitites
{
    [Table("OrderLineItems")]
    public class OrderLineItem
    {
        public OrderLineItem() { }
        public OrderLineItem(int bookId, Book? bookName)
        {
            BookId = bookId;
            BookName = bookName;
        }

        public int OrderLineItemId { get; set; }

        public int OrderId { get; set; }

        public int BookId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public Book? BookName { get; set; } = null;
    }
}
