using System.Collections.Generic;
using System.Linq;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        private readonly LibraryContext _context;

        public LibraryService()
        {
            _context = new LibraryContext();
            _context.Database.EnsureCreated();
        }

        public void AddBook(string title, string author)
        {
            var book = new Book { Title = title, Author = author };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void AddMember(string name)
        {
            var member = new Member { Name = name };
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }
    }
}