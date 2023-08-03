using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    internal interface ILibrary : IReadOnlyCollection<Book>
    {
        //Add book to library
        public void Add(string title, string author);

        /// <summary>
        /// Remove a Book from the library with the given title.
        /// </summary>
        /// <returns>The Book, or null if not found.</returns>
       public Book Borrow(string title);

        
        /// Return a Book to the library.
        
        public void Return(Book book);

        public Book Search(string title);
    }
}
