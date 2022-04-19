using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.BookComparer
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }
        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            Books.Sort(new BookComparator());
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            int index = -1;
            public List<Book> Books { get; set; }
            public LibraryIterator(params Book[] books)
            {
                Books = books.ToList();
            }

            public Book Current => Books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                if (Books.Count <= index)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}