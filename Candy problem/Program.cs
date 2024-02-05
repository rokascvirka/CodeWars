namespace Candy_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = GetMissingCandies(new int[] { 5, 8, 6, 4 });
            Console.WriteLine(answer);
        }

        //smart solution
        public static int GetMissingCandies_V2(int[] candies)
        {
            if (candies.Count() <= 1) return -1;
            var max = candies.Max();
            return candies.Select(x => max - x).Sum();
        }

        //my first solution
        public static int GetMissingCandies(int[] candies) 
        {
            if(candies.Length <= 1)
            {
                return -1;
            }
            var mostCandies = candies.ToList().Max();
            var candiensNeeded = 0;
            foreach( var cand in candies)
            {
                var candiesToAdd = mostCandies - cand;
                candiensNeeded += candiesToAdd;
            }
            return candiensNeeded;
        }
    }
}