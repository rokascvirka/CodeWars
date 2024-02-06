namespace Sum_of_array_singles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = Repeats(new List<int> { 9, 10, 19, 13, 19, 13 });
            Console.WriteLine(answer);
        }
        public static int Repeats(List<int> source)
        {
            var answer = source.GroupBy(i => i)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .Sum();

            return answer;
        }
    }
}