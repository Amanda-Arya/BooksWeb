using BooksWeb.Model;
using BooksWeb.Repositories;

namespace BooksWeb.Services
{
    public class BooksService : IBooksService
    {
        private IBooksRepository _repository;

        public BooksService(IBooksRepository repository)
        {
            _repository = repository;
        }

        public async Task<Book> Create(Book book)
        {
            var existingBook = await _repository.FindByTitle(book.Title);

            if (existingBook is not null)
                throw new Exception("The Book already exists");

            await _repository.Create(book);

            return book;
        }
    }
}
