using BooksWeb.Model;

namespace BooksWeb.Repositories
{
    public interface IBooksRepository
    {
        Task Create(Book book);

        Task<Book?> FindByTitle(string name);
    }
}
