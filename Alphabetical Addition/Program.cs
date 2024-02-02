namespace Alphabetical_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letters = new char[] { 'a', 'b', 'z' };

            Console.WriteLine(WordsToMarks("love"));
            Console.WriteLine(WordsToMarks("friendship"));
            Console.WriteLine();
            Console.WriteLine(WordsToMarks_V2("love"));
            Console.WriteLine(WordsToMarks_V2("friendship"));
            Console.WriteLine();
            Console.WriteLine(WordsToMarks_V3("love"));
            Console.WriteLine(WordsToMarks_V3("friendship"));
        }

        public static int GetLettersValue(char letter)
        {
            return letter - 96;
        }
        public static int WordsToMarks(string str)
        {
            var valueOfWords = 0;
            foreach (var letter in str)
            {
                valueOfWords += GetLettersValue(letter);
            }
            return valueOfWords;
        }

        public static int WordsToMarks_V2(string str)
        {
            return str.Select(x => x - 96).ToList().Sum();
        }
        public static int WordsToMarks_V3(string str)
        {
            return str.Sum(x => x - 96);
        }
    }
}