using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookStoreModels
{
    public class CustomerViewModels
    {
        public int CustomerId { get; set; }
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [DisplayName]
        public string? FullName => $"{LastName}, {FirstName}";

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }
        [DisplayName("Zip Code")]
        public string? PostalCode { get; set; }
    }
}
