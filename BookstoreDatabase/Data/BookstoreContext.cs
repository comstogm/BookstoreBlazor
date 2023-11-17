using BookstoreDatabase.Entitites;
using Microsoft.EntityFrameworkCore;

namespace BookstoreDatabase.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {

        }   

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLineItem> OrderLineItems { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, BookTitle = "Animal Farm", BookISBN = "  9780582330870", PublisherId = 1, PublisherName = "Longman Publishing Group", Price = 9.0f},
                new Book { BookId = 2, BookTitle = "Fahrenheit 451", BookISBN = "9780345292346", PublisherId = 2, PublisherName = "Del Rey Publishing", Price =12.85f},
                new Book { BookId = 3, BookTitle = "To Kill a Mockingbird", BookISBN = "9780061120084", PublisherId = 3, PublisherName = "J. B. Lippincott & Co.", Price =13.99f},
                new Book { BookId = 4, BookTitle = "The Catcher in the Rye", BookISBN = "9780241950425", PublisherId = 4, PublisherName = "Little Brown & Co Inc", Price =15.95f}
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1,FirstName = "Robert", LastName = "Brown", Address = "1234 Not Real lane", City = "Cincinnati",State = "Ohio",PostalCode = "45337" },
                new Customer { CustomerId = 2, FirstName = "Gabriel", LastName = "Comstock", Address = "5678 Nowhere place", City = "Cincinnati", State = "Ohio", PostalCode = "45212" },
                new Customer { CustomerId = 3, FirstName = "Ryan", LastName = "Durham", Address = "910 Someplace street", City = "Cincinnati", State = "Ohio", PostalCode = "45216" },
                new Customer { CustomerId = 4, FirstName = "Sheel", LastName = "Patel", Address = "1112 Anywhere ave", City = "Cincinnati", State = "Ohio", PostalCode = "45442" }
                );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1,PublisherName = "Longman Publishing Group", Address = " 1185 Avenue Of The Americas New York, NY 10036" },
                new Publisher { PublisherId = 2, PublisherName = "Del Rey Publishing", Address = "1745 Broadway, New York, New York 10019" },
                new Publisher { PublisherId = 3, PublisherName = "J. B. Lippincott & Co.", Address = "227 S. 6th Street in Philadelphia, Pennsylvania" },
                new Publisher { PublisherId = 4, PublisherName = "Little Brown & Co Inc", Address = "1290 Avenue Of The Americas, Suite 6, New York, NY" }
                );
        }
    }
}
