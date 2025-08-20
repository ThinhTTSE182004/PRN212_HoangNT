using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new(yob: 2004, gpa: 8.6, name: "An Nguyen", id: "SE1");
            Console.WriteLine(an);
        }
    }
}
