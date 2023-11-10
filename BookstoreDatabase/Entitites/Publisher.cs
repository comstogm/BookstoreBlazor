using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreDatabase.Entitites
{
    [Table("Publishers")]
    public class Publisher
    {
        public int PublisherId { get; set; }
        [MaxLength(50)]
        [DisplayName("Publishing Company")]
        public string? PublisherName { get; set; }

        public string? Address { get; set; }
    }
}
