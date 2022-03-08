using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repositories.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class BookServiceImplementation : IBookService
    {

        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookServiceImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        // Method responsible for returning all people,
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one book by ID
        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new book
        public BookVO Create(BookVO book)
        {
            var entity = _converter.Parse(book);
            entity = _repository.Create(entity);
            return _converter.Parse(entity);
        }

        // Method responsible for updating one book
        public BookVO Update(BookVO book)
        {
            var entity = _converter.Parse(book);
            entity = _repository.Update(entity);
            return _converter.Parse(entity);
        }

        // Method responsible for deleting a book from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
