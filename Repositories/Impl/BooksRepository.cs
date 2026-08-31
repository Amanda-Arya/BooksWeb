using BooksWeb.Model;
using BooksWeb.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace BooksWeb.Repositories.Impl
{
    public class BooksRepository : IBooksRepository
    {
        private SQLContext _context;
        
        public BooksRepository(SQLContext context) 
        {
            _context = context;
        }

        public async Task Create(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public Task<Book?> FindByTitle(string title)
        {
            return _context.Books.FirstOrDefaultAsync(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
