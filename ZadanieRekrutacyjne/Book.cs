using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private decimal price;
        private string author;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (value != this.author)
                {
                    this.author = value;
                    this.OnPropertyChanged("Author");
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value != this.price)
                {
                    this.price = value;
                    this.OnPropertyChanged("Price");
                }
            }
        }

        public Book (string name, decimal price, string author)
        {
            this.name = name;
            this.price = price;
            this.author = author;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

    }
}
