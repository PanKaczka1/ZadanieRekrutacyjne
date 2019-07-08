using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZadanieRekrutacyjne
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private BooksController books;
        public EditWindow(BooksController V)
        {
            books = V;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(price.Text) || string.IsNullOrEmpty(author.Text)))
            {
                decimal d;
                if (!decimal.TryParse(price.Text, out d)) { }
                else if (decimal.Parse(price.Text) == decimal.Round(decimal.Parse(price.Text), 2, MidpointRounding.ToEven))
                {
                    d = decimal.Parse(price.Text);
                    books.Add(name.Text, d, author.Text);
                    this.Close();
                }
            }
        }
    }
}
