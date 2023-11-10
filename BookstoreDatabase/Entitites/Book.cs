using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreDatabase.Entitites
{
    [Table("Books")]
    public class Book
    {
        public int BookId { get; set; }
        [MaxLength(50)]
        [DisplayName("Book Title")]
        public string? BookTitle { get; set; }
        [DisplayName("ISBN")]
        public string? BookISBN { get; set; }

        public int PublisherId { get; set; }
        [MaxLength(50)]
        [DisplayName("Publishing Company")]
        public string? PublisherName { get; set; }

        public float Price { get; set; }
    }
}
