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
using BookManagerCUI;
using Microsoft.EntityFrameworkCore;

namespace BookManagerGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_LoadData_Click(object sender, RoutedEventArgs e)
        {
            BookStoreSu25Context context = new BookStoreSu25Context();
            dg_Book.ItemsSource = context.Books.Include("Category").ToList();
        }
    }
}