using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookManager
{
    public class Category
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        private List<Category> cate = new List<Category>()
        {
            new Category() {
                CateId = 1,
                CateName = "Lịch Sử",
                Description = "Sách Về Chuyện Năm 19 Hồi Đó"
            },
            new Category() {
                CateId = 2,
                CateName = "Văn Học",
                Description = "Sách Về Chuyện Văn Thơ"
            },
            new Category() {
                CateId = 3,
                CateName = "Đam Mỹ",
                Description = "........"
            }
        };

        // Cần 1 prop để hứng cái thằng book được select bên Grid sang trong mode edit ; còn mode tạo mới/create không care !!!!!!!
        public Book Entity { get; set; } = null;

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CateCombobox.ItemsSource = cate;
            CateCombobox.DisplayMemberPath = "CateName";
            CateCombobox.SelectedValuePath = "CateId";

            // ĐỔ data vào các ô nhập ở đây
            // phải check xem Entity có value không , neewu null mode tạo mới không làm gì cả , show màn hình trắng 
            // nếu khác null tức là edit thì phải fill các ô nhập để edit lại 

            if (Entity != null)
            {
                txt_Id.Text = Entity.Id.ToString();
                txt_Title.Text = Entity.Title;
                txt_Author.Text = Entity.Author;
                txt_Price.Text = Entity.Price.ToString();
                txt_Year.Text = Entity.PublishedYear.ToString();
            }

            // Đổ Data vào combo-box , treo đầu dê lấy thịt heo
            // Show ra cata name nhưng khi select thì túm thằng cateid lại để làm FK cho book 
            //CateCombobox.ItemsSource = cate;
            //CateCombobox.DisplayMemberPath = "CateName";
            //CateCombobox.SelectedValuePath = "CateId";
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            // Bắt thử xem Treo đầu dê, lấy thịt heo là con số mấy 
            // chọn đam mỹ -> show số 3
            // chọn bách hợp -> show số 4
            // show dùng MessageBox.Show(...Are You Sure);
            MessageBox.Show("Bạn Chọn Cate Số " + CateCombobox.SelectedValue);
        }
    }
}
