using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace ZadanieRekrutacyjne
{
    class ViewModel : ViewModelBase
    {
        public ObservableCollection<Book> Books;
        public ViewModel()
        {
            Books = CreateBooks();
        }
        /*public ObservableCollection<Book> Books
        {
            get
            {
                if (this.books == null)
                {
                    this.books = this.CreateBooks();
                }

                return this.books;
            }
            set
            {
            }
        }*/

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

        public void Add()
        {
            Book book = new Book("fdsfds", 54, "gfhg");
            Books.Add(book);
        }

    }
}
