using System.Threading.Tasks.Dataflow;

namespace Offload_Your_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[][] { new[] { 1, 55 }, new[] { 0, 25 } };
            var arr2 = new int[][] { new[] { 0, 0 } };
            var projectMinutes = 141;
            var projectminutes2 = 60;
            var result =  WorkNeeded(projectminutes2, arr2);
            Console.WriteLine(result);
        }
        public static string WorkNeeded(int projectMinutes, int[][] freelancers)
        {
            var minutesCovered = freelancers.Sum(f => f[0] * 60 + f[1]);

            if (projectMinutes > minutesCovered)
            {
                var timeLeft = projectMinutes - minutesCovered;
                var time = TimeSpan.FromMinutes(timeLeft);
                return $"I need to work {time.Hours} hour(s) and {time.Minutes} minute(s)";
            }
            else
            {
                return "Easy Money!";
            }
            
        }
    }
}