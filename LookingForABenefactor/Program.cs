namespace LookingForABenefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 14, 30, 5, 7, 9, 11, 15 };
            var avg = 92;
            var res = NewAvg(numbers, avg);
            Console.WriteLine($"Result: {res}");
        }
        public static long NewAvg(double[] arr, double navg)
        {
            var sum = arr.Sum();
            var result = navg * (arr.Length + 1) - sum;
            if (result <= 0)
            {
                throw new ArgumentException("Donation must be a positive number.");
            }
            var ceiling = Math.Ceiling(result);
            return Convert.ToInt64(ceiling);
        }
    }
}

