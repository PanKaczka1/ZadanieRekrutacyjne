using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace ZadanieRekrutacyjne
{
    public class BooksController
    {
        public ObservableCollection<Book> Books;
        public BooksController()
        {
            Books = CreateBooks();
        }

        private ObservableCollection<Book> CreateBooks()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();
            Book book;
            book = new Book("a", 2, "ca");
            books.Add(book);
            book = new Book("aaaaaaaaa", 2, "ca");
            books.Add(book);
            book = new Book("agfgfg", 2, "ca");
            books.Add(book);
            return books;
        }

        public void Add(string name, decimal price, string author)
        {
            Book book = new Book(name, price, author);
            Books.Add(book);
        }
        public StringBuilder Save()
        {
            string[] content = new string[3];
            StringBuilder output = new StringBuilder();
            foreach(var i in Books)
            {
                content[0] = i.Name;
                content[1] = i.Author;
                content[2] = i.Price.ToString();
                output.AppendLine(string.Join(",", content));
            }
            return output;
        }
    }
}
