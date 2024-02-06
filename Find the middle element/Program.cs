namespace Find_the_middle_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = Gimme(new double[] { 5, 10, 14});
            Console.WriteLine(answer);
        }
        public static int Gimme_V2(double[] inputArray)
        {
            return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
        }
        public static int Gimme(double[] inputArray)
        {
            var cloned = inputArray.Clone() as double[];
            Array.Sort(cloned);
            var middleElement = cloned[1];

            return Array.IndexOf(inputArray, middleElement);
        }
    }
}