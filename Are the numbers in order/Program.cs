namespace Are_the_numbers_in_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 1, 2, 4, 7, 19 };
            var arr2 = new int[] { 1, 6, 10, 18, 2, 4, 20 };

            Console.WriteLine(IsAscOrder(arr1));
            Console.WriteLine(IsAscOrder(arr2));



        }
        public static bool IsAscOrder(int[] arr)
        {
            return arr.SequenceEqual(arr.OrderBy(x => x));
        }


    }
}