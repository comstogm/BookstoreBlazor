using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4Lib_Comstock_Gabriel.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = null;
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
