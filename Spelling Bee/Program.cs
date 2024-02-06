namespace Dead_Ants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = DeadAntCount("ant ant .... a nt");
            Console.WriteLine(answer);
        }
        public static int DeadAntCount(string ants)
        {
            if(string.IsNullOrWhiteSpace(ants)) return 0;
            var ant = String.Join("", ants.Replace("ant", " ")
                .Replace(".", "")
                .Split(" ")
                .Where(x => x != string.Empty))
                .Select(c => c.ToString())
                .ToList();
                                
            var parts = new List<int>(); 
                
            var containsA = ant.Where(x => x.Contains("a")).Count();
            var containsN = ant.Where(x => x.Contains("n")).Count();
            var containsT = ant.Where(x => x.Contains("t")).Count();

            parts.Add(containsA);
            parts.Add(containsN);
            parts.Add(containsT);


            return parts.Max();
        }

    }
}