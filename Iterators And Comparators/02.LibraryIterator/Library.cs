using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.LibraryIterator
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
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