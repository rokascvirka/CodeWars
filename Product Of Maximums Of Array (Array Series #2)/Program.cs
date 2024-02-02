namespace Product_Of_Maximums_Of_Array__Array_Series__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 4, 3, 5 };
            var size = 2;
            var answer = MaxProduct(arr, size);
            Console.WriteLine(answer);
        }
        public static int MaxProduct(int[] arr, int size)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            int answer = 1;
            for (var i = 0; i < size; i++)
            {
                answer = answer * arr[i];
            }

            return answer;
        }
    }
}