namespace BasicList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> bag = new List<Student>();
            //có cái túi , mảng chứa nhiều con trỏ Student không cho lộn xộn khác
            bag.Add(new Student()
            {
                Id = "SE1",
                Name = "An Nguyen",
                Yob = 2004,
                Gpa = 8
            });

            bag.Add(new Student()
            {
                Id = "SE2",
                Name = "Binh Nguyen",
                Yob = 2005,
                Gpa = 8
            });

            Console.WriteLine("The List Of Student: ");
            foreach (var item in bag)
            {
                Console.WriteLine(item);
            }

        }


    }

    public class  Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public int Yob { get; set; }

        public double Gpa { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }
    }
}
