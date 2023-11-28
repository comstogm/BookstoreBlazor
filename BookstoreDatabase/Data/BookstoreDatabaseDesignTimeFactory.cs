using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookstoreDatabase.Data
{
    internal class BookstoreDatabaseDesignTimeFactory : IDesignTimeDbContextFactory<BookstoreContext>
    {
        public BookstoreContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BookstoreContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BookstoreDB"));

            return new BookstoreContext(optionsBuilder.Options);

        }
    }
}
