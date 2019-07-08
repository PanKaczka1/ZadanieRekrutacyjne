using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieRekrutacyjne
{
    public class Book : INotifyPropertyChanged
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
            
        public string ToStringWithSeparator(string separator)
        {
            var props = this.GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach(var i in props)
            {
                var value = i.GetValue(this, null);
                sb.Append(value.ToString() + ", ");
            }
            return sb.ToString();
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            this.PropertyChanged?.Invoke(this, args);
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

    }
}
