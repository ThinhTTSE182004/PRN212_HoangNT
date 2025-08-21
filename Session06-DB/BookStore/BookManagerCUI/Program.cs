using BookManagerCUI.Entities;

namespace BookManagerCUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowAllBook();
        }

        public static void ShowAllBook()
        {
            // in toàn bộ sách trong table
            // gọi db context giúp 
            BookStoreSu25Context context = new();
            List<Book> bag = context.Books.ToList();
            // select * from Book rồi đó 
            Console.WriteLine("The List Of Books: ");
            foreach (var item in bag)
            {
                Console.WriteLine($"{item.BookId} {item.BookName} {item.Price}");
            }
        }
    }
}
