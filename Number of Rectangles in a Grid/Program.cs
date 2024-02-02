namespace Number_of_Rectangles_in_a_Grid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 3;
            var y = 2;

            var asnwer = NumberOfRectangles(x, y);
            Console.WriteLine(asnwer);
        }
        public static int NumberOfRectangles(int m, int n)
        {
            int mWays = m * (m + 1) / 2;
            int nways = n * (n + 1) / 2;

            return nways * mWays;
        }
    }
}

