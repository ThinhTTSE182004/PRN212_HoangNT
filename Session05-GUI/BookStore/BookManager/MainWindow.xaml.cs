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

namespace BookManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///                          class Window có sẵn trong SDK, móc trực tiếp vào hệ điều hành Win để generate ra cửa sổ trên Desktop 
    ///                          Ta chỉ việc kế thừa cửa sổ gốc Win của SDK là có cửa sổ hiện thị riêng của App của mình cùng Style trên Win 
    ///  Ta không cần tự tạo 1 HCN đại diện cho 1 cửa sổ từ con số 0 
    // Java : class MainWindow extends Window 
    //        class Dog        extends Pet 
    // Trên cửa sổ, Class Window của mình ra sẽ khai báo các object khác liên quan đến giao diện Ui : Nút Bấm , Ô nhập , CheckBox , Lưới/table, hộp thông báo popup 
    // Tất cả những món này đều là class và object 
    // ví dụ có 1 class tên là button đại diện cho các nút bấm 
    // bạn khai báo trong class này: 
    // Button btnSave = new Button(); /render
    // Button btnQuit; 2 biến của class MainWindow ở dưới
    //                  khi run, runtime sẽ nhờ Os Render/ làm cho 2 nút bấm xuất hiện trên màn hình 
    public partial class MainWindow : Window
    {
        private List<Book> _bag = new(); // bỏ vế phải

        public MainWindow()
        {
            InitializeComponent();
            _bag.Add(new Book()
            {
                Id = 1,
                Title = "Đời Ngắn Đừng Ngủ Dài",
                Author = "Ms. ?",
                Price = 70000,
                PublishedYear = 2018
            });

            _bag.Add(new Book()
            {
                Id = 2,
                Title = "Cà Phê Cùng Tony",
                Author = "Toney",
                Price = 100000,
                PublishedYear = 2018
            });

            _bag.Add(new Book()
            {
                Id = 2,
                Title = "Lost In Play",
                Author = "Ms.EarthWard",
                Price = 70000,
                PublishedYear = 2020
            });
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //Mọi thứ trong window đều là object , sửa số hỏi đáp cũng là object (thuộc về class nào đó . Câu trả lời yes No cũng alf class , hình ảnh cửa sổ hỏi đáp cũng là object class )
            MessageBoxResult result = MessageBox.Show("Are You Sure to Quit", "Quit?", MessageBoxButton.YesNo,MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown(); // Hàm của hệ thống Shutdown cái app 
            }
            
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo 1 List<Book> rồi nhét vào cái Grid
            //List<Book> bag = new(); // bỏ vế phải
            //bag.Add(new Book()
            //{
            //    Id = 1, 
            //    Title = "Đời Ngắn Đừng Ngủ Dài",
            //    Author = "Ms. ?",
            //    Price = 70000,
            //    PublishedYear = 2018
            //});

            //bag.Add(new Book()
            //{
            //    Id = 2,
            //    Title = "Cà Phê Cùng Tony",
            //    Author = "Toney",
            //    Price = 100000,
            //    PublishedYear = 2018
            //});

            //bag.Add(new Book()
            //{
            //    Id = 2,
            //    Title = "Lost In Play",
            //    Author = "Ms.EarthWard",
            //    Price = 70000,
            //    PublishedYear = 2020
            //});

            //quan trọng , đưa list này cho .ItemSource prop của object Grid 
            BookListDataGrid.ItemsSource = _bag; // đưa cái giỏ có nhiều sách cho cái grid trình bày lên 

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // kiểm tra xem đã chọn đúng 1 dòng có cuốn sách hay chưa
            // ép kiểu 1 object từ dòng được chọn từ cái Grid thành Book
            // Ép không thành công thì là null , toán tử "as"
            // ? được gọi là nullable, đánh dấu 1 biến thuộc class nào đó có thể mang null. Phần này không cần thiết, lí do biến object được quyền gán bằng null mà không cần ?
            // ? này dùng cho int , long , float , double .. kiểu primitive -> học sau

            Book? selectedBook = BookListDataGrid.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show("Please Select A Book before delete","Select One" , MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }
            // dỡ dùng else, viết code tự nhiên gióng lề trái 
            // cpu mà đến đây tức là đã chọn 1 cuốn sách để xóa
            //hỏi confirm đã , không cần viết if lồng , ko confirm là trừ điểm  

            MessageBoxResult result = MessageBox.Show("Do You Want To Delete", "Delete?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                return ;
            }

            _bag.Remove(selectedBook);

            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = _bag;

            // Gọi hàm xóa, xóa database và tải lại cái lưới , F5 grid 
            MessageBox.Show("Xóa Thành Công Rồi");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DetailWindow detail = new DetailWindow();
            detail.Header.Content = "Create";
            detail.ShowDialog(); // show modal , không tắt cửa sổ detail không cho quat về main bấm tiếp
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Book? selectedBook = BookListDataGrid.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show("Please Select A Book before Update", "Select One", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //đã chọn rồi thì mới đến đây
            // gọi form detail truyền selected sang /tham chiếu 
            DetailWindow detail = new DetailWindow();
            detail.Header.Content = "Update";

            //gửi selected sang prop vừa tạo 
            detail.Entity = selectedBook; // gọi hàm set của prop Entity

            detail.ShowDialog();
            
        }
    }

    //class khác here !!!! 
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        public double Price { get; set; }
    }
}