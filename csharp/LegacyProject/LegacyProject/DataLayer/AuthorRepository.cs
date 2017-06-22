using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LegacyProject.DataLayer
{
    public sealed class AuthorRepository
    {
        private static AuthorRepository _instance;
        private readonly List<Author> _authors;
        private AuthorRepository()
        {
            _authors = new List<Author>
            {
                new Author(1, "George R.R. Martin", "grrmartin@gmail.com", true),
                new Author(2, "J.K. Rowling", "jkrowling@gmail.com", true),
                new Author(3, "J.R.R. Tolkien", "jrrtolkien@gmail.com", false),
                new Author(4, "C.S. Lewis", "cslewis@gmail.com", false),
            };
        }

        public static AuthorRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AuthorRepository();
            }
            return _instance;
        }

        public IReadOnlyCollection<Author> Authors
        {
            get { return new ReadOnlyCollection<Author>(_authors); } 
        }

        public Author FindAuthorById(int id)
        {
            return _authors.Find(a => a.Id == id);
        }
    }
}