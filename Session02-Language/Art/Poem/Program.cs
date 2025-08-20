namespace Poem
{
    internal class Program
    {
        // crtl / là commnet nguyên đoạn , svm + tab là main

        static void Main(string[] args)
        {
            Song.PrintBacBlingLyric(); 
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    Console.WriteLine("...");
        //    PrintJ97();

        //    Program x = new Program();
        //    x.PrintHSH();

        //}

        public static void PrintJ97()
        {
            Console.WriteLine("We alike, dead or alive, your life? Still life\r\nIt's so nice, I missed you a lot\r\nYou're welcome back home, wherever you are\r\nWe alike, dead or alive, your life is still with me\r\nLivin' good life, day or nights\r\nThe highlight, it's about time to rock-on");
        }

        public void PrintHSH()
        {
            Console.WriteLine("Well, I said I would be back\r\nAnd I'd never let you go\r\nPick a petal off a flower\r\nDaze, you love me, nope?\r\nWell, I said I would be back\r\nAnd I'd never let you go\r\nPick a petal off a flower\r\nDo you love me or (stop)");
        }

        public void printHSH2()
        {
            Console.WriteLine(@"두껍아 두껍아 came with the troops
뜯고 맛보고 즐기고 big bang when I shoot
King in the zoo, he gotta do what I do
One of one, not of them (mirror)
Man in the 'Views' aimin' at you
I'm aiming at a man, and amen, achoo (achoo)
Bless you all, cleaned house (fu-)"); //"""...."""
        }
    }
}
