using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Backpack: IBag<Book>
    {
        public List<Book> Storage;
        public void Pack(Book item)
        {
            Storage.Add(item);
        }

        public Book Unpack(int index)
        {
            for (int i = 0; i < Storage.Count; i++) 
            {
                Book currentBook = Storage[i];
                if (index == i)
                {
                    return currentBook;
                }
            }
            return null;
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator() 
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in Storage)
            {
                yield return book;
            }
        }

        public void ViewAll()
        {
            for (int i = 0; i < Storage.Count; i++)
            {
                Console.WriteLine(Storage[i].Title);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
