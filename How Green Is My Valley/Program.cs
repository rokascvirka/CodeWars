namespace Cats_and_shelves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = 1;
            var finish = 5;
            var diff = finish - start;
            var trippleJump = diff / 3;
            var remainder = diff % 3;

            var totalJumpsNeeded = trippleJump;

            if(remainder == 1 || remainder == 2)
            {
                totalJumpsNeeded += remainder;
            }

            Console.WriteLine(totalJumpsNeeded); 

        }
    }
}