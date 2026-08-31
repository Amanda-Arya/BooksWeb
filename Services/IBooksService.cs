using BooksWeb.Model;

namespace BooksWeb.Services
{
    public interface IBooksService
    {
        Task<Book> Create(Book book);
    }
}
