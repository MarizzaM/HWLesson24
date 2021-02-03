using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson24
{
    class MyLibrary
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();

        public MyLibrary()
        {
    
        }

        public bool AddBook(Book b)
        {
            if (books.ContainsKey(b.Title))
                return false;
            else
            {
                books.Add(b.Title, b);
                return true;
            }
        }
        public bool RemoveBook(string t)
        {
            if (books.ContainsKey(t))
            {
                books.Remove(t);
                return true;
            }
            else
                return false;
        }

        public bool HaveThisBook(string t) 
        {
            if (books.ContainsKey(t))
                return true;
            else
                return false;
        }

        public Book GetBook(string t)
        {
            if (books.ContainsKey(t))
                return books[t];
            else
                return null;
        }

        public Book GetBookByAuthor(string a) {
            foreach (Book book in books.Values)
            {
                if (book.Author == a)
                    return book;
            }
            return null;
        }

        public void Clear() 
        {
                books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> autors = new List<string>();
            foreach (Book book in books.Values)
            {
                autors.Add(book.Author);
            }

            return autors;
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> booksSortByAuthorName = new List<Book>();
            foreach (Book book in books.Values)
            {
                booksSortByAuthorName.Add(book);
            }

            booksSortByAuthorName.Sort(); 

            return booksSortByAuthorName;
        }
        public List<string> GetBooksTitleSorted()
        {
            List<string> booksSortByTitles = new List<string>();
            foreach (Book book in books.Values)
            {
                booksSortByTitles.Add(book.Title);
            }

            booksSortByTitles.Sort();

            return booksSortByTitles;
        }

        public int Count
        {
            get
            {
                return books.Count;
            }
        }

        public override string ToString()
        {
            string result = "My favorits books: ";

            foreach (KeyValuePair<string, Book> item in books)
            {
                result += $"\n\n{item.Value}";
            }

            return result;
        }
    }
}
