﻿using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repositories;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class BookServiceImplementation : IBookService
    {

        private readonly IBookRepository _repository;

        public BookServiceImplementation(IBookRepository repository)
        {
            _repository = repository;
        }

        // Method responsible for returning all people,
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one book by ID
        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new book
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        // Method responsible for updating one book
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        // Method responsible for deleting a book from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
