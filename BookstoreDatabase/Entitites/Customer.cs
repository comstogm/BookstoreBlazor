using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreDatabase.Entitites
{
    [Table("Customers")]
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
