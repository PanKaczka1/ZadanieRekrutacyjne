using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanieRekrutacyjne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel books;
        public MainWindow()
        {
            InitializeComponent();
            books = new ViewModel();
            this.gridView.ItemsSource = books.Books;
            this.gridView.CellValidating += GridView_CellValidating;
        }

        private void GridView_CellValidating(object sender, Telerik.Windows.Controls.GridViewCellValidatingEventArgs e)
        {
            if(e.Cell.Column.UniqueName == "Price")
            {
                decimal d;

                if (!(decimal.TryParse(e.NewValue.ToString(), out d)))
                {
                    e.IsValid = false;
                    e.ErrorMessage = "Cena musi byc liczba";
                }
                else if (decimal.Parse(e.NewValue.ToString()) != decimal.Round(decimal.Parse(e.NewValue.ToString()), 2, MidpointRounding.ToEven))
                {
                    e.IsValid = false;
                }
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            EditWindow window = new EditWindow(books);
            window.ShowDialog();
        }
    }
}
