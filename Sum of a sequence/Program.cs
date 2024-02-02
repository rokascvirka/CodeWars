namespace Sum_of_a_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var seq = new List<int>() { 2, 6, 2 };
            var sum1 = SequenceSum(seq[0], seq[1], seq[2]);
            Console.WriteLine(sum1);
        }
        public static int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }
            var sum = 0;

            for (int i = start; i <= end; i+= step)
            {
                sum += i;
            }
            return sum;
        }
    }
}