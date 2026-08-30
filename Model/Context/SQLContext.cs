using Microsoft.EntityFrameworkCore;

namespace BooksWeb.Model.Context
{
    public class SQLContext :DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options)
            : base(options) { }
        public DbSet<Book> Books { get; set; }

    }
}
