using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreDatabase.Entitites
{
    [Table("Orders")]
    public class Order
    {
        public int Orderid { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();
    }
}
