namespace Smallest_value_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "index");
            Console.WriteLine(answer);
        }

        //smart solution
        public static int FindSmallest_V2(int[] numbers, string toReturn)
        {
            var min = numbers.Min();
            return toReturn == "value" ? min : Array.IndexOf(numbers, min);
        }

        //my first solution
        public static int FindSmallest(int[] numbers, string toReturn)
        {
            switch(toReturn)
            {
                case "value":
                    return SmallestValue(numbers);
                case "index":
                    return IndexOfSmallestValue(numbers);
                default: return 0;
            }
        }

        private static int SmallestValue(int[] numbers)
        {
            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);
            return sorted[0];
        }

        private static int IndexOfSmallestValue(int[] numbers)
        {
            var smallestNumber = SmallestValue(numbers);
            return Array.IndexOf(numbers, smallestNumber);
        }
    }
}